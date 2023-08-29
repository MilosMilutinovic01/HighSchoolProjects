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
            this.Refresh();
            Graphics g = pictureBox1.CreateGraphics();
            Pen olovka = new Pen(Color.Red, 3);
            int x, a, b, c, d;
            x = Convert.ToInt32(numericUpDown1.Value);
            c = pictureBox1.Width / x;
            a=0;
            d = pictureBox1.Height / x;
            b=0;
            if (checkBox1.Checked == true)
            {
                while (pictureBox1.Height >= b)
                {
                    g.DrawLine(olovka, 0, b, pictureBox1.Width, b);
                    b = b + d;
                }
            }
            if (checkBox2.Checked == true)
            {
                while (pictureBox1.Width >= a)
                {
                    g.DrawLine(olovka, a, 0, a, pictureBox1.Width);
                    a = a + c;
                }
            }
            if (checkBox1.Checked == true && checkBox2.Checked == true)
            {
                while (pictureBox1.Height >= b || pictureBox1.Width >= a)
                {
                    g.DrawLine(olovka, 0, b, pictureBox1.Width, b);
                    b = b + d;
                    g.DrawLine(olovka, a, 0, a, pictureBox1.Width);
                    a = a + c;
                }
            }
        }
    }
}
