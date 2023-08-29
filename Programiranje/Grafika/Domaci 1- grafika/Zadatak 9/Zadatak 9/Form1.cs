using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Collections;
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
            timer1.Enabled = true;
        }

        Random r = new Random();
        
        private void button2_Click_1(object sender, EventArgs e)
        {
            ArrayList a = new ArrayList();
            int i = 0;
            timer1.Enabled = false;
            foreach (Control x in panel1.Controls)
            {
                a.Add(Convert.ToInt32(x.Text));
            }
            foreach (Control x in panel1.Controls)
            {
                if (a.IndexOf(a[i], i + 1) != -1)
                {
                    MessageBox.Show("Pokrenite ponovo");
                    break;
                }
                i++;
            }
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            foreach (Control x in panel1.Controls)
            {
                x.Text = r.Next(0, 39).ToString();
            }
        }
    }
}
