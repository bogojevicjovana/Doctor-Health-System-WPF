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

namespace ProjekatWpfHci
{
    /// <summary>
    /// Interaction logic for OperacioneSale.xaml
    /// </summary>
    public partial class OperacioneSale : Page
    {
        public OperacioneSale()
        {
            InitializeComponent();
        }

        private void SaleClick(object sender, RoutedEventArgs e)
        {
            OperacijeFrame.Content = new SalaSlobodniTermini();
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            StartPage st = new StartPage();
            NavigationService.Navigate(st);
        }

        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
            Lekkovixaml lek = new Lekkovixaml();
            NavigationService.Navigate(lek);
        }

        private void MenuItem_Click_2(object sender, RoutedEventArgs e)
        {

        }

        private void MenuItem_Click_3(object sender, RoutedEventArgs e)
        {
            Termini termini = new Termini();
            NavigationService.Navigate(termini);
        }
    }
}
