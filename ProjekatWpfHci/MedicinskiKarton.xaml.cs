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
    /// Interaction logic for MedicinskiKarton.xaml
    /// </summary>
    public partial class MedicinskiKarton : Page
    {

        public MedicinskiKarton()
        {
            InitializeComponent();



            Dijagnoza d1 = new Dijagnoza();
            Dijagnoza d2 = new Dijagnoza();
            Dijagnoza d3 = new Dijagnoza();
            Dijagnoza d4 = new Dijagnoza();
            Dijagnoza d5 = new Dijagnoza();
            Dijagnoza d6 = new Dijagnoza();

            d1.sifra = "14321";
            d1.oznaka = "PS10";
            d1.nazivD = "Druge infekcije uzrkovane salmonelama";
            d1.nazivL = "Sallmoneloses aliae";

            DijagnozaDataGrid.Items.Add(d1);

            d2.sifra = "15671";
            d2.oznaka = "AD10";
            d2.nazivD = "Šigeloza neoznačena";
            d2.nazivL = "Shigelloses, non specificata";

            DijagnozaDataGrid.Items.Add(d2);

            d3.sifra = "12334";
            d3.oznaka = "ADAR";
            d3.nazivD = "Bakterijska infekcija";
            d3.nazivL = "Infection bacterias";

            DijagnozaDataGrid.Items.Add(d3);

            d4.sifra = "12334";
            d4.oznaka = "ADAR";
            d4.nazivD = "Bakterijska infekcija";
            d4.nazivL = "Infection bacterias";

            DijagnozaDataGrid.Items.Add(d4);

            d5.sifra = "12334";
            d5.oznaka = "ADAR";
            d5.nazivD = "Bakterijska infekcija";
            d5.nazivL = "Infection bacterias";

            DijagnozaDataGrid.Items.Add(d5);

         


    }

        public class Dijagnoza
        {
            public string oznaka { get; set; }
            public string sifra { get; set; }
            public string nazivD { get; set; }

            public string nazivL { get; set; }

        }

        private void DijagnozaClick(object sender, RoutedEventArgs e)
        {
            Dijagnoza d = new Dijagnoza();

            if (A1.Text == string.Empty || A2.Text == string.Empty || A3.Text == string.Empty || A4.Text == string.Empty)
            {
                MessageBox.Show("Popunite sva polja.");
            }
            else {
                d.sifra = A1.Text;
                d.oznaka = A2.Text;
                d.nazivD = A3.Text;
                d.nazivL = A4.Text;

                DijagnozaDataGrid.Items.Add(d);

                A1.Clear();
                A2.Clear();
                A3.Clear();
                A4.Clear();
            }   

           

        }

    }
}
