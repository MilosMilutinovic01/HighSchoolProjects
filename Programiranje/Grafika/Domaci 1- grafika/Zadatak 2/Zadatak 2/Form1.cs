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
            int b;
            b =Convert.ToInt32(textBox1.Text);
            if (i < 10)
            {
                if (a == b)
                    MessageBox.Show("Pogodio si " + a);
                if (a > b)
                    label2.Text = "Zamisljen broj je veci";
                if (a < b)
                    label2.Text = "Zamisljen broj je manji";
                i++;
            }
            else
                MessageBox.Show("Nisi pogodio tacan broj je " + a);
        }

        int a, i = 0;

        private void Form1_Load(object sender, EventArgs e)
        {
            Random r = new Random();
            a = r.Next(1, 100);
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
        }
    }
}
