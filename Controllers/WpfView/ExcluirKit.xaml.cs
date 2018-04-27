﻿using Controllers;
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
            Kit kit = KitController.PesquisarPorID(int.Parse(txtIdKit.Text));
            PreencheDados(kit);
        }


        private void btnExcluirKit_Click(object sender, RoutedEventArgs e)
        {
            KitController.ExcluirKit(int.Parse(txtIdKit.Text));
            MessageBox.Show("Cliente Excluído com Sucesso!");
            LimparTextBoxes();
        }

        private void PreencheDados(Cliente Dadoscliente)
        {
            txtNomeKit.Text = Dadoskit.Nome;
            txtDescricaoKit.Text = Dadoskit.Descricao;
            txtQtdPessoaCliente.Text = Dadoskit.QtdPesso;
            txtPrecoCliente.Text = Dadoskit.Preco;
        }

        private void LimparTextBoxes()
        {
            txtIdKit.Text = string.Empty;
            txtNomeKit.Text = string.Empty;
            txtDescricaoKit.Text = string.Empty;
            txtQtdPessoaKit.Text = string.Empty;
            txtPrecoKit.Text = string.Empty;
            
        }
    }

        private void btnVoltarKit_Click(object sender, RoutedEventArgs e)
        {
            Kit k = new Kit();
            k.Show();
        }
    }
}
