using ProjekatWpfHci.Forme;
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
using System.ComponentModel;
using System.Drawing;
using Syncfusion.Pdf;
using Syncfusion.Pdf.Graphics;
using Syncfusion.Pdf.Grid;
using System.Data;

namespace ProjekatWpfHci
{
    /// <summary>
    /// Interaction logic for Profil.xaml
    /// </summary>
    public partial class Profil : Page
    {
        public Profil()
        {
            InitializeComponent();
        }

        private void ReceptClick(object sender, RoutedEventArgs e)
        {
            Recept rp = new Recept();
            rp.ShowDialog();

        }

        private void NazadClick(object sender, RoutedEventArgs e)
        {
            Termini back = new Termini();
            NavigationService.Navigate(back);
        }

        private void AnamnezaClick(object sender, RoutedEventArgs e)
        {
            PodaciPacijent.Content = new Anamneza();
        }

        private void MedicinskiKartonClick(object sender, RoutedEventArgs e)
        {
            PodaciPacijent.Content = new MedicinskiKarton();
        }


        private void UputnicaClick(object sender, RoutedEventArgs e)
        {
            Uputnica uputnica = new Uputnica();
            uputnica.ShowDialog();
        }

        private void OperacioneSale(object sender, RoutedEventArgs e)
        {
            OperacioneSale op = new OperacioneSale();
            NavigationService.Navigate(op);
        }

        private void LekoviClick(object sender, RoutedEventArgs e)
        {
            Lekkovixaml lekovi = new Lekkovixaml();
            NavigationService.Navigate(lekovi);
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            Rasspored r = new Rasspored();
            NavigationService.Navigate(r);

        }
    }
}
