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
    /// Interaction logic for LekoviOdobravanje.xaml
    /// </summary>
    public partial class LekoviOdobravanje : Page
    {
        public LekoviOdobravanje()
        {
            

            InitializeComponent();
            List<Lek> items = new List<Lek>();
            items.Add(new Lek() { nazivLeka = "Ranitidin" });
            items.Add(new Lek() { nazivLeka = "Acetium" });
            items.Add(new Lek() { nazivLeka = "Pressing" });
            items.Add(new Lek() { nazivLeka = "Brotizolam" });
            items.Add(new Lek() { nazivLeka = "Midazolam" });
            items.Add(new Lek() { nazivLeka = "Nitrazepam" });
            items.Add(new Lek() { nazivLeka = "Alprazolam" });
            items.Add(new Lek() { nazivLeka = "Brotiozolam" });
            items.Add(new Lek() { nazivLeka = "Alprazolam" });
            items.Add(new Lek() { nazivLeka = "Brotizolam" });
            items.Add(new Lek() { nazivLeka = "Midazoplam" });
            items.Add(new Lek() { nazivLeka = "Prassig" });
            items.Add(new Lek() { nazivLeka = "Presing" });
            items.Add(new Lek() { nazivLeka = "Netrazapam" });
            items.Add(new Lek() { nazivLeka = "Ranitidin" });
            items.Add(new Lek() { nazivLeka = "Ranitidian" });


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
        }

        private void LekoviOdobravanjeClick(object sender, MouseButtonEventArgs e) 
        {
            var item = (sender as ListView).SelectedItem;
            if (item != null)
            {
                OdobravanjeFrame.NavigationService.Navigate(new Uri("LekZaOdobravanje.xaml", UriKind.Relative));
            }
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            Lekkovixaml lekovi = new Lekkovixaml();
            NavigationService.Navigate(lekovi);
        
        }

        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
            OperacioneSale sale = new OperacioneSale();
            NavigationService.Navigate(sale);
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

