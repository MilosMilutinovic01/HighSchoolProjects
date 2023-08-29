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
            int a;
            Random r = new Random();
            Graphics g = pictureBox1.CreateGraphics();
            SolidBrush cetka = new SolidBrush(Color.Red);
            a = r.Next(1, 7);
            label1.Text = "Bacena je kocka " + a.ToString();
            pictureBox1.Refresh();
            if (a == 1)
            {
                g.FillEllipse(cetka, 85, 85, 30, 30);
            }
            if (a == 2)
            {
                g.FillEllipse(cetka, 30, 30, 30, 30);
                g.FillEllipse(cetka, pictureBox1.Width - 60, pictureBox1.Height - 60, 30, 30);
            }
            if (a == 3)
            {
                g.FillEllipse(cetka, 85, 85, 30, 30);
                g.FillEllipse(cetka, 30, 30, 30, 30);
                g.FillEllipse(cetka, pictureBox1.Width - 60, pictureBox1.Height - 60, 30, 30);
            }
            if (a == 4)
            {
                g.FillEllipse(cetka, 30, 30, 30, 30);
                g.FillEllipse(cetka, pictureBox1.Width - 60, pictureBox1.Height - 60, 30, 30);
                g.FillEllipse(cetka, pictureBox1.Width - 60, 30, 30, 30);
                g.FillEllipse(cetka, 30, pictureBox1.Height - 60, 30, 30);
            }
            if (a == 5)
            {
                g.FillEllipse(cetka, 30, 30, 30, 30);
                g.FillEllipse(cetka, pictureBox1.Width - 60, pictureBox1.Height - 60, 30, 30);
                g.FillEllipse(cetka, pictureBox1.Width - 60, 30, 30, 30);
                g.FillEllipse(cetka, 30, pictureBox1.Height - 60, 30, 30);
                g.FillEllipse(cetka, 85, 85, 30, 30);
            }
            if (a == 6)
            {
                g.FillEllipse(cetka, 30, 30, 30, 30);
                g.FillEllipse(cetka, pictureBox1.Width - 60, pictureBox1.Height - 60, 30, 30);
                g.FillEllipse(cetka, pictureBox1.Width - 60, 30, 30, 30);
                g.FillEllipse(cetka, 30, pictureBox1.Height - 60, 30, 30);
                g.FillEllipse(cetka, 30, 85, 30, 30);
                g.FillEllipse(cetka, pictureBox1.Width-60, 85, 30, 30);
            }
        }
    }
}
