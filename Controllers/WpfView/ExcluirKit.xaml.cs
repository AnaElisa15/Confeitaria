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
    /// Lógica interna para ExcluirKit.xaml
    /// </summary>
    public partial class ExcluirKit : Window
    {
        public ExcluirKit()
        {
            InitializeComponent();
        }

        private void btnPesquisar_Click(object sender, RoutedEventArgs e)
        {
            Kits kits = KitController.PesquisarPorID(int.Parse(txtIdKit.Text));
            PreencheDados(kits);
        }


        private void btnExcluirKit_Click(object sender, RoutedEventArgs e)
        {
            KitController.ExcluirKit(int.Parse(txtIdKit.Text));
            MessageBox.Show("Cliente Excluído");
            LimparTextBoxes();
        }

        private void PreencheDados(Kits Dadoskit)
        {
            txtNomeKit.Text = Dadoskit.Nome;
            txtDescricaoKit.Text = Dadoskit.Descricao;
            txtQtdPessoaKit.Text = Dadoskit.QtdPessoa.ToString();
            txtPrecoKit.Text = Dadoskit.Preco.ToString();
        }

        private void LimparTextBoxes()
        {
            txtIdKit.Text = string.Empty;
            txtNomeKit.Text = string.Empty;
            txtDescricaoKit.Text = string.Empty;
            txtQtdPessoaKit.Text = string.Empty;
            txtPrecoKit.Text = string.Empty;
            
        }

        private void btnVoltarKit_Click(object sender, RoutedEventArgs e)
        {
                Kit k = new Kit();
                k.Show();
        }
    }
       
      
 }

