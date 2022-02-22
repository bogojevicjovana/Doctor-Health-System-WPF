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
    /// Interaction logic for Anamneza.xaml
    /// </summary>
    public partial class Anamneza : Page
    {
        public Anamneza()
        {
            InitializeComponent();
        }

        private void saveClick(object sender, RoutedEventArgs e)
        {
            if (text1.Text == string.Empty || text2.Text == string.Empty || text3.Text == string.Empty || text4.Text == string.Empty || text5.Text == string.Empty || text6.Text == string.Empty || text7.Text == string.Empty)
            {
                MessageBox.Show("Popunite sva polja");
            }
            else
            {
                text1.Clear();
                text2.Clear();
                text3.Clear();
                text4.Clear();
                text5.Clear();
                text6.Clear();
                text7.Clear();

                MessageBox.Show("Promene sačuvane");

            }
        }

        private void discardClick(object sender, RoutedEventArgs e)
        {
            text1.Clear();
            text2.Clear();
            text3.Clear();
            text4.Clear();
            text5.Clear();
            text6.Clear();
            text7.Clear();

        }
    }
}
