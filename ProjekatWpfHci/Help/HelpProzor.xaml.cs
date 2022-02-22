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
using System.Windows.Shapes;

namespace ProjekatWpfHci.Help
{
    /// <summary>
    /// Interaction logic for HelpProzor.xaml
    /// </summary>
    public partial class HelpProzor : Window
    {
        public HelpProzor()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Window2 page = new Window2();
            page.Show();
            this.Close();
        }
    }
}
