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
    /// Lógica interna para MontarPedido.xaml
    /// </summary>
    public partial class MontarPedido : Window
    {
        public MontarPedido()
        {
            InitializeComponent();
        }

        private void btnPesquisarKit_Click(object sender, RoutedEventArgs e)
        {
            Kits kit = KitController.PesquisarPorID(int.Parse(txtIdKit.Text));
            PreencheDados(kit);
        }

        private void btnPesquisarCliente_Click(object sender, RoutedEventArgs e)
        {
            Clientes clientes = ClienteController.PesquisarPorID(int.Parse(txtIdCliente.Text));
            Preenche(clientes);
        }
        private void PreencheDados(Kits Dadoskit)
        {
            txtDescricaoKit.Text = Dadoskit.Descricao;
            txtPrecoKit.Text = Dadoskit.Preco.ToString();
        }
        private void Preenche(Clientes Dadoscliente)
        {
            txtNomeCliente.Text = Dadoscliente.Nome;

        }

        private void btnVoltar_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mw = new MainWindow();
            mw.Show();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnSalvarP_Click(object sender, RoutedEventArgs e)
        {
            Pedidos novopedido = SalvarPedido(txtEntrega.Text, int.Parse(txtIdCliente.Text), int.Parse(txtIdKit.Text));
            MessageBox.Show("Pedido Salvo com Sucesso");
            LimparTextBoxes();
        }

        private Pedidos SalvarPedido(string DataEntrega, int IdCliente, int IdKit)
        {
            Pedidos p = new Pedidos();
            
            p.DataEntrega = DataEntrega;
            p.ClienteID = IdCliente;
            p.KitID = IdKit;

            PedidoController.SalvarPedido(p);

            return p;
        }

        private void LimparTextBoxes()
        {
            txtIdCliente.Text = string.Empty;
            txtIdKit.Text = string.Empty;
            txtEntrega.Text = string.Empty;
        }
    }
}