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

        private void btnSalvarCliente_Click(object sender, RoutedEventArgs e)
        {
            if (VerificarItens() == true)
            {
                Endereco end = SalvarEndereco(txtRuaCliente.Text, int.Parse(txtNumeroCliente.Text.Trim()), txtBairroCliente.Text, txtComplementoCliente.Text);
                Clientes clinovo = SalvarCliente(txtNomeCliente.Text, txtCpfCliente.Text.Trim().Replace("-", "").Replace("(", "").Replace(")", ""), txtTelefoneCliente.Text.Trim().Replace("-", "").Replace("(", "").Replace(")", ""), end.EnderecoID);
                ClienteController.SalvarCliente(clinovo);
                MessageBox.Show("Cadastro relizado");
            }

        }
        private bool VerificarItens()
        {
            string caracter = txtNumeroCliente.Text.Substring(0, 1);
            string verifica = "^[0-9]";

            if (!Regex.IsMatch(txtNomeCliente.Text, @"^[a-zA-Z]+$") || (txtNomeCliente.Text == null))
            {
                MessageBox.Show("Informação invalida. Só é aceito letras.");
                return false;
            }
            else if ((!Regex.IsMatch(caracter, verifica) || txtCpfCliente.Text.Length.Equals(11) == false) || (txtCpfCliente.Text == null))
            {
                MessageBox.Show("Informação invalida. O CPF deve conter 11 números.");
                return false;
            }
            else if (!Regex.IsMatch(txtTelefoneCliente.Text, verifica) || (txtTelefoneCliente.Text == null))
            {
                return false;
            }
            else if ((txtRuaCliente.Text == null))
            {
                return false;
            }
            else if (!Regex.IsMatch(txtNumeroCliente.Text, verifica) || (txtNumeroCliente.Text == null))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private Clientes SalvarCliente(string Nome, string CPF, string Telefone, int ID)
        {
            Clientes cli = new Clientes();
            cli.Nome = Nome;
            cli.Cpf = CPF;
            cli.Telefone = Telefone;
            cli.EnderecoID = ID;

            return cli;
        }

        private Endereco SalvarEndereco(string Rua, int Num, string Bairro, string Compl)
        {
            Endereco end = new Endereco();
            end.Rua = Rua;
            end.Numero = Num;
            end.Bairro = Bairro;
            end.Complemento = Compl;

            EnderecoController.SalvarEndereco(end);

            return end;
        }


        private void btnVoltarCliente_Click(object sender, RoutedEventArgs e)
        {
            Cliente c = new Cliente();
            c.Show();
        }
    }
}
