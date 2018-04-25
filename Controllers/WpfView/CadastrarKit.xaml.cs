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
    /// Interação lógica para CadastrarKit.xam
    /// </summary>
    public partial class CadastrarKit : Window

    {
        public CadastrarKit()
        {
            InitializeComponent();
        }

        private void btnVoltar_Click(object sender, RoutedEventArgs e)
        {
            MainWindow m = new MainWindow();
            this.Close();
            m.ShowDialog();
        }

        private void btnSalvar_Click(object sender, RoutedEventArgs e)
        {
            {
                MessageBox.Show("Cadastro relizado");
            }

        }
        
        private Kit SalvarKit (string Nome, string Descricao, double Preco, int QtdPessoa)
        {
            Kit kit = new Kit();
            kit.Nome = Nome;
            kit.Descricao = Descricao;
            kit.QtdPessoa = QtdPessoa;
            kit.Preco = Preco;

            return kit;
        }
    }
}
