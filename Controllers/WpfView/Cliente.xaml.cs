using Controllers;
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
using System.Windows.Navigation;
using System.Windows.Shapes;
using Models;

namespace WpfView
{
    /// <summary>
    /// Lógica interna para Cliente.xaml
    /// </summary>
    public partial class Cliente : Window
    {
        public Cliente()
        {
            InitializeComponent();
           
        }

        private void btnListarCli_Click(object sender, RoutedEventArgs e)
        {
            List<Clientes> dg = ClienteController.ListarTodosClientes();
            if (dg != null)
            {
                dgCliente.ItemsSource = dg.ToList();
            }
        }

        private void btnExcluirCli_Click(object sender, RoutedEventArgs e)
        {
            ExcluirCliente ec = new ExcluirCliente();
            ec.Show();
        }

        private void btnEditarCli_Click(object sender, RoutedEventArgs e)
        {
            EditarCliente edc = new EditarCliente();
            edc.Show();
        }

        private void btnNovoCli_Click(object sender, RoutedEventArgs e)
        {
            CadastrarCliente ccl = new CadastrarCliente();
            ccl.Show();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
