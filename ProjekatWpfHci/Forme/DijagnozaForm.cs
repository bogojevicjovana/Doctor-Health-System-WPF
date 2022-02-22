using MaterialDesignThemes.Wpf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Navigation;

namespace ProjekatWpfHci
{
    public partial class DijagnozaForm : Form
    {

        public MedicinskiKarton karton;
  

        public DijagnozaForm()
        {
            InitializeComponent();
            MedicinskiKarton karton = new MedicinskiKarton();
           
        }

        public class Unos
        {
            public string sifra { get; set; }
            public string oznaka { get; set; }
            public string nazivD { get; set; }
            public string nazivL { get; set; }

        }

        private void button1_Click(object sender, EventArgs e)
        {

            MedicinskiKarton md = new MedicinskiKarton();

            Unos unos = new Unos();

            unos.sifra = textBox1.Text;


            md.DijagnozaDataGrid.Items.Add(unos);

            this.Close();
        }

    }
}
