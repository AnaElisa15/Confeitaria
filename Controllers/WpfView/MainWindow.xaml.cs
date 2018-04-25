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
    /// Interação lógica para MainWindow.xam
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        
        private void BtnCliente_Click(object sender, RoutedEventArgs e)
        {
            EspacoCliente ec = new EspacoCliente();
            ec.ShowDiaLog();
        }

        private void btnKit_Click(object sender, RoutedEventArgs e)
        {
            EspacoKit ek = new EspacoKit();

        }

        private void btnPedido_Click(object sender, RoutedEventArgs e)
        {
            PedidoCliente pc = new PedidoCliente();
        }
    }
    }
}
