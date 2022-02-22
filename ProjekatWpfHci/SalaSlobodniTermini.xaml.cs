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
    /// Interaction logic for SalaSlobodniTermini.xaml
    /// </summary>
    public partial class SalaSlobodniTermini : Page
    {
        public SalaSlobodniTermini()
        {
            InitializeComponent();
        }

        private void ZakazivanjeClick(object sender, RoutedEventArgs e)
        {
            Operacija operacija = new Operacija();
            operacija.ShowDialog();
        }
    }
}
