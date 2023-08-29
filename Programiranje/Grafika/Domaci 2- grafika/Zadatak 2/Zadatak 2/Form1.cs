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

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                textBox1.ReadOnly = true;
                label2.Text = "Ucenik je nedovoljan";
            }
            else
            {
                textBox1.ReadOnly = false;
                label2.Text = "";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
                double a;
                a = Convert.ToDouble(textBox1.Text);
                if (a < 1 || a > 5)
                    MessageBox.Show("Prosek mora biti veci od 5 ili manji od 1");
                if (a >= 4.5)
                    label2.Text = "Ucenik je odlican";
                if (a >= 3.5 && a < 4.5)
                    label2.Text = "Ucenik je vrlo dobar";
                if (a >= 2.5 && a < 3.5)
                    label2.Text = "Ucenik je dobar";
                if (a >= 1.5 && a < 2.5)
                    label2.Text = "Ucenik je dovoljan";
        }
    }
}
