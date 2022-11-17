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

namespace Biblioteca_Bernabini
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Biblioteca mondadori = new Biblioteca();
        public MainWindow()
        {
           
            InitializeComponent();
            
        }

        private void BtnAggiungiLibro_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnRicercaAutore_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnContaLibri_Click(object sender, RoutedEventArgs e)
        {
            BlkNumero.Text = mondadori.ContaLibri().ToString();
        }

        private void BtnRicercaLibro_Click(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
