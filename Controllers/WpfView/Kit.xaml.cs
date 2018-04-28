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
using Controllers;
using Models;


namespace WpfView
{
    /// <summary>
    /// Interação lógica para EspacoKit.xam
    /// </summary>
    public partial class Kit : Window
    {
        public Kit()
        {
            InitializeComponent();
        }

        private void btnNovoKit_Click(object sender, RoutedEventArgs e)
        {
            CadastrarKit ck = new CadastrarKit();
            ck.Show();
        }

        private void btnListarKit_Click(object sender, RoutedEventArgs e)
        {
            List<Models.Kits> dg = KitController.ListarTodosKits();
            if (dg != null)
            {
                dgKit.ItemsSource = dg.ToList();
            }
        }

        private void btnExcluirKit_Click(object sender, RoutedEventArgs e)
        {
            ExcluirKit ek = new ExcluirKit();
            ek.Show();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

    }
}
