using Controllers;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WpfView
{
    /// <summary>
    /// Lógica interna para EditarCliente.xaml
    /// </summary>
    public partial class EditarCliente : Window
    {
        public EditarCliente()
        {
            InitializeComponent();
        }

        private void btnSalvarCliente_Click(object sender, RoutedEventArgs e)
        {
            Endereco endnovo = SalvarEndereco(txtRuaCliente.Text,txtBairroCliente.Text, int.Parse(txtNumeroCliente.Text), txtComplementoCliente.Text);
            Clientes clinovo = SalvarCliente(txtNomeCliente.Text, txtCpfCliente.Text, txtTelefoneCliente.Text, endnovo.EnderecoID);
            ClienteController.EditarCliente(int.Parse(txtIdCliente.Text), clinovo);
            Clientes idend = ObterDados();
            EnderecoController.EditarEndereco(idend.EnderecoID, endnovo);
            MessageBox.Show("Cliente alterado.");
            LimparTextBoxes();
        }

        private void btnPesquisarCliente_Click(object sender, RoutedEventArgs e)
        {
            Clientes cliente = ClienteController.PesquisarPorID(int.Parse(txtIDCliente.Text));
            PreencheDados(cliente);
        }

        private Clientes ObterDados()
        {
            Clientes cli = ClienteController.PesquisarPorID(int.Parse(txtIdCliente.Text));
            return cli;
        }

        private void PreencheDados(Clientes Dadoscliente)
        {
            txtNomeCliente.Text = Dadoscliente.Nome;
            txtCpfCliente.Text = Dadoscliente.Cpf;
            txtTelefoneCliente.Text = Dadoscliente.Telefone;
            txtRuaCliente.Text = Dadoscliente._Endereco.Rua;
            txtNumeroCliente.Text = Convert.ToString(Dadoscliente._Endereco.Numero);
            txtComplementoCliente.Text = Dadoscliente._Endereco.Complemento;
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

        private Endereco SalvarEndereco(string Rua,string Bairro, int Num, string Compl)
        {
            Endereco end = new Endereco();
            end.Rua = Rua;
            end.Bairro = Bairro;
            end.Numero = Num;
            end.Complemento = Compl;
            return end;
        }

        private void LimparTextBoxes()
        {
            txtNomeCliente.Text = string.Empty;
            txtCpfCliente.Text = string.Empty;
            txtTelefoneCliente.Text = string.Empty;
            txtRuaCliente.Text = string.Empty;
            txtBairroCliente.Text = string.Empty;
            txtNumeroCliente.Text = string.Empty;
            txtComplementoCliente.Text = string.Empty;
        }

        private void btnVoltarCliente_Click(object sender, RoutedEventArgs e)
        {
            Cliente c = new Cliente();
            c.Show();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}