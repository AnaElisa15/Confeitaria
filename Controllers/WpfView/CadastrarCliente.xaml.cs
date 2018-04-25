using System;
using System.Windows;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using Controllers;
using System.Text.RegularExpressions;
using Models;

namespace WpfView
{
    /// <summary>
    /// Interação lógica para CadastrarCliente.xam
    /// </summary>
    public partial class CadastrarCliente : Window
    {
        public CadastrarCliente()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, RoutedEventArgs e)
        {
            if (VerificarItens() == true)
            {
                Endereco end = SalvarEndereco(txtRua.Text, int.Parse(txtNumero.Text.Trim()), txtBairro.Text, txtComplemento.Text);
                Cliente clinovo = SalvarCliente(txtNomeCliente.Text, txtCpfCliente.Text.Trim().Replace("-", "").Replace("(", "").Replace(")", ""), txtTelefone.Text.Trim().Replace("-", "").Replace("(", "").Replace(")", ""), end.EnderecoID);
                ClienteController.SalvarCliente(clinovo);
                MessageBox.Show("Cadastro relizado");
            }

        }
        private bool VerificarItens()
        {
            string caracter = txtNumero.Text.Substring(0, 1);
            string verifica = "^[0-9]";

            if (!Regex.IsMatch(txtNomeCliente.Text, @"^[a-zA-Z]+$") || (txtNomeCliente.Text == null))
            {
                MessageBox.Show("Invalido, só é aceito caracter.");
                return false;
            }
            else if ((!Regex.IsMatch(caracter, verifica) || txtCpfCliente.Text.Length.Equals(11) == false) || (txtCpfCliente.Text == null))
            {
                MessageBox.Show("Invalido! O CPF deve conter 11 números.");
                return false;
            }
            else if (!Regex.IsMatch(txtTelefone.Text, verifica) || (txtTelefone.Text == null))
            {
                return false;
            }
            else if ((txtRua.Text == null))
            {
                return false;
            }
            else if (!Regex.IsMatch(txtNumero.Text, verifica) || (txtNumero.Text == null))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private Cliente SalvarCliente(string Nome, string CPF, string Telefone, int ID)
        {
            Cliente cli = new Cliente();
            cli.Nome = Nome;
            cli.Cpf = CPF;
            cli.Telefone = Telefone;
            cli.EnderecoID = ID;

            return cli;
        }

        private Endereco SalvarEndereco(string Rua, int Num, string Bairro, string Compl, string Refe)
        {
            Endereco end = new Endereco();
            end.Rua = Rua;
            end.Numero = Num;
            end.Bairro = Bairro;
            end.Complemento = Compl;

            EnderecoController.SalvarEndereco(end);

            return end;
        }
    }
}
