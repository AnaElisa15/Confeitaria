using Controllers;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfView
{
    /// <summary>
    /// Interação lógica para EditarCliente.xam
    /// </summary>
    public partial class EditarCliente : Page
    {
        private Cliente cliEdicao;

        public EditarCliente()
        {
            InitializeComponent();
        }

        private void btnEditar_Click(object sender, RoutedEventArgs e)
        {
            if (VerificarItens() == true)
            {
                EditarEndereco(txtRua.Text, int.Parse(txtNumero.Text), txtBairro.Text, txtComplemento.Text,  cliEdicao.EnderecoID);
                EnviarClienteEditado(txtNomeCliente.Text, txtCpfCliente.Text.Replace("-", "").Replace("(", "").Replace(")", ""), txtTelefone.Text.Replace("-", "").Replace("(", "").Replace(")", ""));
                MessageBox.Show("Cliente editado");
              
            }
        }

        

        private void btnVoltar_Click(object sender, RoutedEventArgs e)
        {
            MainWindow m = new MainWindow();
            m.ShowDialog();
        }

        public void EditarNome(Cliente cli)
        {
            txtNomeCliente.Text = cli.Nome;
            txtCpfCliente.Text = cli.Cpf;
            txtTelefone.Text = cli.Telefone;
            txtRua.Text = cli._Endereco.Rua;
            txtNumero.Text = Convert.ToString(cli._Endereco.Numero);
            txtBairro.Text = cli._Endereco.Bairro;
            txtComplemento.Text = cli._Endereco.Complemento;
            cliEdicao = cli;
        }

        private void EnviarClienteEditado(string Nome, string CPF, string Telefone)
        {
            Cliente cli = new Cliente();
            cli.Nome = Nome;
            cli.Cpf = CPF;
            cli.Telefone = Telefone;

            ClienteController.EditarCliente(cliEdicao.ClienteID, cli);
        }

        private Endereco EditarEndereco(string Rua, int Num, string Bairro, string Compl, string Refe, int id)
        {
            Endereco end = new Endereco();
            end.Rua = Rua;
            end.Numero = Num;
            end.Bairro = Bairro;
            end.Complemento = Compl;
            
            EnderecoController.EditarEndereco(id, end);

            return end;
        }

        private bool VerificarItens()
        {
            string caracter = txtNumero.Text.Substring(0, 1);
            string verifica = "^[0-9]";

            if (!Regex.IsMatch(txtNomeCliente.Text, @"^[a-zA-Z]+$") || (txtNomeCliente.Text == null))
            {
                MessageBox.Show("ERRO, digite apenas caracter");
                return false;
            }
            else if ((!Regex.IsMatch(caracter, verifica) || txtCpfCliente.Text.Length.Equals(11) == false) || (txtCpfCliente.Text == null))
            {
                MessageBox.Show("Erro ! Digite 11 dígitos no CPF e apenas números");
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

        private void btnLimparCampos_Click(object sender, RoutedEventArgs e)
        {
            txtNomeCliente.Text = "";
            txtCpfCliente.Text = "";
            txtTelefone.Text = "";
            txtRua.Text = "";
            txtNumero.Text = "";
            txtBairro.Text = "";
            txtComplemento.Text = "";
        }
    }
}