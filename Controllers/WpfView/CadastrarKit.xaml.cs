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
using System.Windows.Shapes;

namespace WpfView
{
    /// <summary>
    /// Lógica interna para CadastrarKit.xaml
    /// </summary>
    public partial class CadastrarKit : Window
    {
        public CadastrarKit()
        {
            InitializeComponent();
        }

        private void btnSalvarKit_Click(object sender, RoutedEventArgs e)
        {
            Models.Kits k = SalvarKit(txtNomeKit.Text, txtDescricaoKit.Text, double.Parse(txtPrecoKit.Text), int.Parse(txtQtdPessoaKit.Text));
            MessageBox.Show("Cadastro relizado");
        }

        private Models.Kits SalvarKit(string Nome, string Descricao, double Preco, int QtdPessoa)
        {
            Models.Kits kit = new Models.Kits();
            kit.Nome = Nome;
            kit.Descricao = Descricao;
            kit.QtdPessoa = QtdPessoa;
            kit.Preco = Preco;

            KitController.SalvarKit(kit);

            return kit;
        }

        private void btnVoltarKit_Click(object sender, RoutedEventArgs e)
        {
            Kit k = new Kit();
            k.Show();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
