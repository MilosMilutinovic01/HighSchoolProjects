using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int x, a, b, c, i = 0;
                x = Convert.ToInt32(textBox1.Text);
                a = x / 100;
                b = (x % 100) / 10;
                c = x % 10;
                textBox3.Text = a.ToString();
                textBox4.Text = b.ToString();
                textBox5.Text = c.ToString();
                if (a.ToString() == textBox2.Text)
                    i++;
                if (c.ToString() == textBox2.Text)
                    i++;
                if (b.ToString() == textBox2.Text)
                    i++;
                if (i != 0)
                    label6.Text = "U broju " + textBox1.Text + " cifra " + textBox2.Text + " se pojavljuje " + i + " puta";
                else
                    label6.Text = "U broju " + textBox1.Text + " cifra " + textBox2.Text + " se ne pojavljuje ";
            }
            catch (FormatException)
            {
                MessageBox.Show("Pogresan unos");
            }
        }
    }
}
