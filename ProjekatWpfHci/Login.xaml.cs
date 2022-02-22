using System;
using System.Collections.Generic;
using System.ComponentModel;
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

namespace ProjekatWpfHci
{
    /// <summary>
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : Window
    {
        public Login()
        {
            InitializeComponent();
        }

        private void submit_Button(object sender, RoutedEventArgs e)
        {

            if (password.Password == "" || user.Text == "")
            {
                MessageBox.Show("Niste unijeli podatke. Pokušajte ponovo!");
            }
            else if (password.Password != "lozinka" || user.Text != "ivanivanovic"){

                MessageBox.Show("Pogrešno korisničko ime ili lozinka. Unesite ponovo podatke.");
            }
            else
            {
                MainWindow main = new MainWindow();
                main.Show();
                this.Close();
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
