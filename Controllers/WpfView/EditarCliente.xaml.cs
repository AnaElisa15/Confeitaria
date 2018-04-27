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
            Cliente clinovo = SalvarCliente(txtNomeCliente.Text, txtCpfCliente.Text, txtTelefoneCliente.Text, endnovo.EnderecoID);
            ClienteController.EditarCliente(int.Parse(txtIdCliente.Text), clinovo);
            Cliente idend = ObterDados();
            EnderecoController.EditarEndereco(idend.EnderecoID, endnovo);
            MessageBox.Show("Dados do cliente alterados com sucesso!");
            LimparTextBoxes();
        }

        private void btnPesquisarCliente_Click(object sender, RoutedEventArgs e)
        {
            PreencheDados(ObterDados());
        }

        private Cliente ObterDados()
        {
            Cliente cli = ClienteController.PesquisarPorID(int.Parse(txtIdCliente.Text));
            return cli;
        }

        private void PreencheDados(Cliente Dadoscliente)
        {
            txtNomeCliente.Text = Dadoscliente.Nome;
            txtCpfCliente.Text = Dadoscliente.Cpf;
            txtTelefoneCliente.Text = Dadoscliente.Telefone;
            txtRuaCliente.Text = Dadoscliente._Endereco.Rua;
            txtNumeroCliente.Text = Convert.ToString(Dadoscliente._Endereco.Numero);
            txtComplementoCliente.Text = Dadoscliente._Endereco.Complemento;
        }
        private Cliente SalvarCliente(string Nome, string CPF, string Email, string Telefone, int ID)
        {
            Cliente cli = new Cliente();
            cli.Nome = Nome;
            cli.Cpf = CPF;
            cli.Telefone = Telefone;
            cli.Email = Email;
            cli.EnderecoID = ID;

            return cli;
        }

        private Endereco SalvarEndereco(string Rua, int Num, string Compl)
        {
            Endereco end = new Endereco();
            end.Rua = Rua;
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
    }

        private void btnVoltarCliente_Click(object sender, RoutedEventArgs e)
        {
            Cliente c = new Cliente();
            c.Show();
        }
    }
}