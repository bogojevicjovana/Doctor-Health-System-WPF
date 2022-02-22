using ProjekatWpfHci.SvojstvaSastojci;
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
    /// Interaction logic for Lek.xaml
    /// </summary>
    public partial class Lek : Page
    {
        public Lek()
        {
        }

        public Lek(Lek lek)
        {
            InitializeComponent();
        }

        public string nazivLeka { get; internal set; }
        public string sifraLeka { get; internal set; }

        private void SastojciClick(object sender, RoutedEventArgs e)
        {
            LekoviGrid.Content = new Svojstva();
        }

        private void KarakteristikeClick(object sender, RoutedEventArgs e)
        {
            LekoviGrid.Content = new Karakteristike();
        }

        private void ProgressBar_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            LekoviGrid.Content = new Karakteristike();
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            Lekkovixaml l = new Lekkovixaml();
            NavigationService.Navigate(l);
        }

        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
            OperacioneSale op = new OperacioneSale();
            NavigationService.Navigate(op);
        }

        private void MenuItem_Click_2(object sender, RoutedEventArgs e)
        {

        }

        private void MenuItem_Click_3(object sender, RoutedEventArgs e)
        {
            Termini t = new Termini();
            NavigationService.Navigate(t);
        }
    }
}
