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
    /// Interaction logic for Termini.xaml
    /// </summary>
    public partial class Termini : Page
    {
        public Termini()
        {
            InitializeComponent();
        }

        private void ProfilClick(object sender, RoutedEventArgs e)
        {
            TerminFrame.Content = new Profil();
        }

        private void PocetnaClick(object sender, RoutedEventArgs e)
        {
            StartPage back = new StartPage();
            NavigationService.Navigate(back);
        }

        private void OperacioneClick(object sender, RoutedEventArgs e)
        {
            OperacioneSale sale = new OperacioneSale();
            NavigationService.Navigate(sale);
        }

        private void LekoviClick(object sender, RoutedEventArgs e)
        {
            Lekkovixaml lekovi = new Lekkovixaml();
            NavigationService.Navigate(lekovi);

        }
    }
}
