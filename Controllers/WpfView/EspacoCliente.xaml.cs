﻿using System;
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
    /// Interação lógica para EspacoCliente.xam
    /// </summary>
    public partial class EspacoCliente : Page
    {
        public EspacoCliente()
        {
            InitializeComponent();
        }

        private void btnNovo_Click(object sender, RoutedEventArgs e)
        {
            CadastrarCliente cc = new CadastrarCliente();
            this.Close();
            cc.ShowDialog();

        }

        private void btnLista_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnEditar_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnExcluir_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
