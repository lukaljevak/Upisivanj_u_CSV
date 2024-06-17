using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Upisivanje_u.csv
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sendet, EventArgs e)
        {
            string ime = textBox1.Text;
            string prezime = textBox2.Text;
            int godinaRodenja = (int)numericUpDown1.Value;
            string email = textBox3.Text;

            string[] lines = { $"{ime},{prezime},{godinaRodenja},{email}" };

            File.AppendAllLines("user_data.csv", lines);

            MessageBox.Show("Usplješno spremljeni podatci!", "Uspijeh", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
