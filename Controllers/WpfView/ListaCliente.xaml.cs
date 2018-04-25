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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfView
{
    /// <summary>
    /// Interação lógica para ListaCliente.xam
    /// </summary>
    public partial class ListaCliente : Page
    {
        public ListaCliente()
        {
            InitializeComponent();
            MostrarClientes();
        }

        private void btnVoltar_Click(object sender, RoutedEventArgs e)
        {
            MainWindow m = new MainWindow();
            m.ShowDialog();
        }

        private void MostrarClientes()
        {
            List<Cliente> dt = ClienteController.ListarTodosClientes();
            if (dt != null)
            {
                gridCliente.ItemsSource = dt;
            }

        }

    }
}
