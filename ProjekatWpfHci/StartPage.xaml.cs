using Org.BouncyCastle.Crypto.Engines;
using ProjekatWpfHci.Help;
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
    /// Interaction logic for StartPage.xaml
    /// </summary>
    public partial class StartPage : Page
    {
        public StartPage()
        {
            InitializeComponent();
        }

        private void TerminiView(object sender, RoutedEventArgs e)
        {
            MainFrame.NavigationService.Navigate(new Uri("Termini.xaml", UriKind.Relative));
        }

        private void OperacioneSaleView(object sender, RoutedEventArgs e)
        {
            MainFrame.NavigationService.Navigate(new Uri("OperacioneSale.xaml", UriKind.Relative));
        }

        private void LekoviClick(object sender, RoutedEventArgs e)
        {
            MainFrame.NavigationService.Navigate(new Uri("Lekkovixaml.xaml", UriKind.Relative));
        }


        private void B2_Click(object sender, RoutedEventArgs e)
        {
            Rasspored r = new Rasspored();
            r.Show();
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            HelpProzor hp = new HelpProzor();
            hp.Show();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Content = new Logout();
        }
    }
}
