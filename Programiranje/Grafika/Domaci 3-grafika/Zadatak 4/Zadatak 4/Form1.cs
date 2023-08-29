using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int i = 0, n = 0, max = 0;
        double sv;
        List<int> a = new List<int>();


        private void button1_Click(object sender, EventArgs e)
        {
            i++;
            a.Add(Convert.ToInt32(textBox1.Text));
            richTextBox1.AppendText("x[" + i + "] = " + textBox1.Text + "\n");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button3.Enabled = true;
            label2.Text = "Niz ima " + i.ToString() + " elemenata";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                i = 0;
                n = 0;
                foreach (int x in a)
                {
                    n = n + a[i];
                    i++;
                }
                richTextBox2.AppendText("Suma elemenata niza je " + n.ToString() + "\n");
            }
            if (checkBox2.Checked)
            {
                i = 0;
                n = 0;
                foreach (int x in a)
                {
                    n = n + a[i];
                    i++;
                }
                sv = (double)n / i;
                richTextBox2.AppendText("Srednja vrednost niza je " + sv.ToString("F") + "\n");
            }
            if (checkBox3.Checked)
            {
                i = 0;
                n = 0;
                foreach (int x in a)
                {
                    if(a[i]%2==0)
                    n = n + a[i];
                    i++;
                }
                richTextBox2.AppendText("Suma parnih elemenata niza je " + n.ToString() + "\n");
            }
            if (checkBox4.Checked)
            {
                i = 0;
                n = 0;
                for (i = 0; i < a.Count; i++ )
                {
                    if (a[i] % 5 == 0 && a[i] != 0)
                        n++;
                }
                richTextBox2.AppendText("Broj elemenata deljivih sa 5 je " + n.ToString() + "\n");
            }
            if (checkBox5.Checked)
            {
                i = 0;
                n = 0;
                a[1] = max;
                foreach (int x in a)
                {
                    if (a[i] > max)
                        max = a[i];
                        i++;
                }
                richTextBox2.AppendText("Maksimalan element niza je " + max.ToString() + "\n");
            }
            if (checkBox6.Checked)
            {
                i = 0;
                n = 0;
                for (i = 0; i < a.Count;i++ )
                {
                    if (a[i] < 0)
                        n++;
                }
                richTextBox2.AppendText("Broj negativnih elemenata je " + n.ToString() + "\n");
            }
        }
    }
}
