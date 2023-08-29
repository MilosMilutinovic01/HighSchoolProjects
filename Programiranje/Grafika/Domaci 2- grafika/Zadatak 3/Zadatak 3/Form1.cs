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

        bool x = true;

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.Refresh();
            Graphics g = pictureBox1.CreateGraphics();
            Pen olovka = new Pen(Color.White, 5);
            if (x == true)
            {
                g.DrawLine(olovka, 30, 30, pictureBox1.Width - 30, 30);
                g.DrawLine(olovka, pictureBox1.Width - 30, 30, pictureBox1.Width - 30, pictureBox1.Height - 30);
                g.DrawLine(olovka, pictureBox1.Width - 30, pictureBox1.Height - 30, 30, pictureBox1.Height - 30);
                g.DrawLine(olovka, 30, pictureBox1.Height - 30, 30, 30);
                x =! x;
            }

            else if (x == false)
            {
                g.DrawLine(olovka, 130, 30, pictureBox1.Width - 30, pictureBox1.Height - 30);
                g.DrawLine(olovka, pictureBox1.Width - 30, pictureBox1.Height - 30, 30, pictureBox1.Height - 30);
                g.DrawLine(olovka, 30, pictureBox1.Height - 30, 130, 30);
                x = true;
            }
        }
    }
}
