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

        int a, x, y, x1, y1;
        Random r = new Random();

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Refresh();
            a = Convert.ToInt32(numericUpDown1.Value);
            y = pictureBox1.Height / a;
            y1 = 0;
            if (radioButton1.Checked)
            {
                Graphics g = pictureBox1.CreateGraphics();
                while (y1 <= pictureBox1.Height)
                {
                    Pen olovka = new Pen(Color.FromArgb(r.Next(256), r.Next(256), r.Next(256)), 3);
                    g.DrawLine(olovka, 0, 0, pictureBox1.Width, y1);
                    y1 = y1 + y;
                }
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Refresh();
            a = Convert.ToInt32(numericUpDown1.Value);
            x = pictureBox1.Width / a;
            x1 = 0;
            if (radioButton2.Checked)
            {
                Graphics g = pictureBox1.CreateGraphics();
                while (x1 <= pictureBox1.Width)
                {
                    Pen olovka = new Pen(Color.FromArgb(r.Next(256), r.Next(256), r.Next(256)), 3);
                    g.DrawLine(olovka, 0, 0, x1, pictureBox1.Height);
                    x1 = x1 + x;
                }
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Refresh();
            a = Convert.ToInt32(numericUpDown1.Value);
            x = pictureBox1.Width / a;
            x1 = 0;
            if (radioButton3.Checked)
            {
                Graphics g = pictureBox1.CreateGraphics();
                while (x1 <= pictureBox1.Width)
                {
                    Pen olovka = new Pen(Color.FromArgb(r.Next(256), r.Next(256), r.Next(256)), 3);
                    g.DrawLine(olovka, pictureBox1.Width / 2, 0, x1, pictureBox1.Height / 2);
                    g.DrawLine(olovka, x1, pictureBox1.Height / 2, pictureBox1.Width / 2, pictureBox1.Height);
                    x1 = x1 + x;
                }
            }
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Refresh();
            a = Convert.ToInt32(numericUpDown1.Value);
            y = pictureBox1.Height / a;
            y1 = 0;
            if (radioButton4.Checked)
            {
                Graphics g = pictureBox1.CreateGraphics();
                while (y1 <= pictureBox1.Height)
                {
                    Pen olovka = new Pen(Color.FromArgb(r.Next(256), r.Next(256), r.Next(256)), 3);
                    g.DrawLine(olovka, pictureBox1.Width, pictureBox1.Height, 0, y1);
                    y1 = y1 + y;
                }
            }
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Refresh();
            a = Convert.ToInt32(numericUpDown1.Value);
            x = pictureBox1.Width / a;
            x1 = 0;
            if (radioButton5.Checked)
            {
                Graphics g = pictureBox1.CreateGraphics();
                while (x1 <= pictureBox1.Width)
                {
                    Pen olovka = new Pen(Color.FromArgb(r.Next(256), r.Next(256), r.Next(256)), 3);
                    g.DrawLine(olovka, pictureBox1.Width, pictureBox1.Height, x1, 0);
                    x1 = x1 + x;
                }
            }
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Refresh();
            a = Convert.ToInt32(numericUpDown1.Value);
            y = pictureBox1.Height / a;
            y1 = 0;
            if (radioButton6.Checked)
            {
                Graphics g = pictureBox1.CreateGraphics();
                while (y1 <= pictureBox1.Height)
                {
                    Pen olovka = new Pen(Color.FromArgb(r.Next(256), r.Next(256), r.Next(256)), 3);
                    g.DrawLine(olovka, 0, pictureBox1.Height / 2, pictureBox1.Width / 2, y1);
                    g.DrawLine(olovka, pictureBox1.Width / 2, y1, pictureBox1.Width, pictureBox1.Height / 2);
                    y1 = y1 + y;
                }
            }
        }
    }
}
