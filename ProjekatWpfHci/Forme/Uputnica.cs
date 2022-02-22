using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjekatWpfHci.Forme
{
    public partial class Uputnica : Form
    {
        public Uputnica()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void Uputnica_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_Validating(object sender, CancelEventArgs e)
        {

            if (textBox1.Text == string.Empty)
            {
                MessageBox.Show("Unesite šifru");
            }
        }

        private void textBox2_Validating(object sender, CancelEventArgs e)
        {
            if (textBox1.Text == string.Empty)
            {
                MessageBox.Show("Unesite podatke");
            }
        }

        private void textBox4_Validating(object sender, CancelEventArgs e)
        {
            if (textBox1.Text == string.Empty)
            {
                MessageBox.Show("Unesite podatke");
            }
        }

        private void textBox5_Validating(object sender, CancelEventArgs e)
        {
            if (textBox1.Text == string.Empty)
            {
                MessageBox.Show("Unesite podatke");
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
           
        }
    }
}
