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
            richTextBox1.ResetText();
            int a, b = 0, i = 1, max = 0, pon = 0;
            a=Convert.ToInt32(textBox1.Text);
            if (checkBox1.Checked == true)
            {
                while (a/10 != 0)
                {
                    i++;
                    a = a / 10;
                }
                richTextBox1.AppendText("Broj cifara je " + i.ToString());
            }
            a = Convert.ToInt32(textBox1.Text);
            if (checkBox2.Checked == true)
            {
                while (a / 10 != 0)
                {
                    b = b + a % 10;
                    a = a / 10;
                }
                b = b + a;
                richTextBox1.AppendText("\nSuma cifara je " + b.ToString());
            }
            a = Convert.ToInt32(textBox1.Text);
            if (checkBox3.Checked == true)
            {
                while (a / 10 != 0)
                {
                    b = a % 10;
                    if (b > max)
                        max = b;
                    a = a / 10;
                }
                richTextBox1.AppendText("\nMaksimalna cifra je " + max.ToString());
            }
            a = Convert.ToInt32(textBox1.Text);
            if (checkBox4.Checked == true)
            {
                while (a / 10 != 0)
                {
                    b = a % 10;
                    if (b == 5)
                        pon++;
                    a = a / 10;
                }
                richTextBox1.AppendText("\nBroj pojavljivanja cifre 5 je " + pon.ToString());
            }
            a = Convert.ToInt32(textBox1.Text);
            int x, r=0;
            x = a;
            if (checkBox5.Checked == true)
            {
                while (x > 0)
                {
                    int y = x % 10;
                    r = (r * 10) + y;
                    x = x / 10;
                }
                richTextBox1.AppendText("\nBroj zapisan istim ciframa u obrnutom poretku je " + r.ToString());
            }
        }
    }
}
