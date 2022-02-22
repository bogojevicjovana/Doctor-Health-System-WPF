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
    /// Interaction logic for Lekkovixaml.xaml
    /// </summary>
    public partial class Lekkovixaml : Page
    {
        public Lekkovixaml()
        {
            InitializeComponent();
            List<Lek> items = new List<Lek>();
            items.Add(new Lek() { nazivLeka = "Ranitidin", sifraLeka = "1A01" }); ;
            items.Add(new Lek() { nazivLeka = "Acetium", sifraLeka = "1A02" });
            items.Add(new Lek() { nazivLeka = "Pressing", sifraLeka = "1A03" });
            items.Add(new Lek() { nazivLeka = "Brotizolam", sifraLeka = "1A04" });
            items.Add(new Lek() { nazivLeka = "Midazolam", sifraLeka = "1A05" });
            items.Add(new Lek() { nazivLeka = "Nitrazepam", sifraLeka = "1A06" });
            items.Add(new Lek() { nazivLeka = "Alprazolam", sifraLeka = "1A07" });
            items.Add(new Lek() { nazivLeka = "Prazepam", sifraLeka = "1A08" });
            items.Add(new Lek() { nazivLeka = "Bromazepam", sifraLeka = "1A09" });
            items.Add(new Lek() { nazivLeka = "Klorazepat", sifraLeka = "1A10" });
            items.Add(new Lek() { nazivLeka = "Diazepam", sifraLeka = "1B01" });
            items.Add(new Lek() { nazivLeka = "Tiroid", sifraLeka = "1B02" });
            items.Add(new Lek() { nazivLeka = "Herbateria", sifraLeka = "1B03" });
            items.Add(new Lek() { nazivLeka = "Paracetamol", sifraLeka = "1B04" });






            lvUsers.ItemsSource = items;

            CollectionView view = (CollectionView)CollectionViewSource.GetDefaultView(lvUsers.ItemsSource);
            view.Filter = UserFilter;

        }

        private bool UserFilter(object item)
        {
            if (String.IsNullOrEmpty(txtFilter.Text))
                return true;
            else
                return ((item as Lek).nazivLeka.IndexOf(txtFilter.Text, StringComparison.OrdinalIgnoreCase) >= 0);
        }

        private void txtFilter_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {
            CollectionViewSource.GetDefaultView(lvUsers.ItemsSource).Refresh();
        }
    

        public class Lek
        {
            public string nazivLeka { get; set; }

            public string sifraLeka { get; set; }
        }

        private void ListViewClick(object sender, MouseButtonEventArgs e)
        {
            var item = (sender as ListView).SelectedItem;
            if (item != null)
            {
                LekoviFrame.NavigationService.Navigate(new Uri("Lek.xaml", UriKind.Relative));
            }
        }

        private void LekoviOdobravanje(object sender, RoutedEventArgs e)
        {
            LekoviFrame.Content = new LekoviOdobravanje();
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            StartPage st = new StartPage();
            NavigationService.Navigate(st);
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
            Termini termini = new Termini();
            NavigationService.Navigate(termini);
        }
    }
}
