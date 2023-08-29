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

        int a, b;

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                textBox1.ReadOnly = true;
                textBox2.ReadOnly = true;
                textBox3.ReadOnly = true;
                timer1.Interval = Convert.ToInt32(textBox1.Text);
                a = Convert.ToInt32(textBox2.Text);
                b = Convert.ToInt32(textBox3.Text);
                timer1.Enabled = true;
            }
            catch (FormatException)
            {
                MessageBox.Show("Pogresan unos");
            }
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            if (a <= b)
            {
                textBox2.Text = a.ToString();
                textBox3.Text = b.ToString();
                a++;
            }
            else
            {
                timer1.Enabled = false;
                MessageBox.Show("Kraj");
                textBox1.ReadOnly = false;
                textBox2.ReadOnly = false;
                textBox3.ReadOnly = false;
            }
        }
    }
}
