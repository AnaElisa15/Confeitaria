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
    /// Lógica interna para ExcluirCliente.xaml
    /// </summary>
    public partial class ExcluirCliente : Window
    {
        public ExcluirCliente()
        {
            InitializeComponent();
        }

        private void btnPesquisarCliente_Click(object sender, RoutedEventArgs e)
        {
            Clientes cliente = ClienteController.PesquisarPorID(int.Parse(txtIDCliente.Text));
            PreencheDados(cliente);
        }

        private void btnExcluirCliente_Click(object sender, RoutedEventArgs e)
        {
            ClienteController.ExcluirCliente(int.Parse(txtIDCliente.Text));
            MessageBox.Show("Cliente Excluído com Sucesso!");
            LimparTextBoxes();

        }
        private void PreencheDados(Models.Clientes Dadoscliente)
        {
            txtNomeCliente.Text = Dadoscliente.Nome;
            txtCpfCliente.Text = Dadoscliente.Cpf;
            txtTelefoneCliente.Text = Dadoscliente.Telefone;
            txtRuaCliente.Text = Dadoscliente._Endereco.Rua;
            txtBairroCliente.Text = Dadoscliente._Endereco.Bairro;
            txtNumeroCliente.Text = Convert.ToString(Dadoscliente._Endereco.Numero);
            txtComplementoCliente.Text = Dadoscliente._Endereco.Complemento;
        }

        private void LimparTextBoxes()
        {
            txtIDCliente.Text = string.Empty;
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
    }
}
