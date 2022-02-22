using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjekatWpfHci
{
    public partial class Operacija : Form
    {
        public Operacija()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_Validating(object sender, CancelEventArgs e)
        {
            if(textBox1.Text == string.Empty)
            {
                MessageBox.Show("Popunite polja");
            }
        }

        private void textBox2_Validating(object sender, CancelEventArgs e)
        {
            if (textBox2.Text == string.Empty)
            {
                MessageBox.Show("Popunite polja");
            }
        }

        private void textBox3_Validating(object sender, CancelEventArgs e)
        {
            if (textBox3.Text == string.Empty)
            {
                MessageBox.Show("Popunite polja");
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Uspešno ste zakazali operaciju!");
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
