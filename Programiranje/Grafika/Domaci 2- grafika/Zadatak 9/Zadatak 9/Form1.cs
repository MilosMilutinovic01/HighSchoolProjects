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

        int x, y, a, b, c, d;

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            this.Refresh();
            x = e.X;
            y = e.Y;
            a = Convert.ToInt32(textBox1.Text);
            b = a;
            c = a;
            d = a;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            Pen olovka = new Pen(Color.Red, 1);
            g.DrawLine(olovka, x, y, 0, 0);
            g.DrawLine(olovka, x, y, a, 0);
            g.DrawLine(olovka, x, y, 0, c);
            a = a + b;
            c = c + d;
            if (a >= this.ClientSize.Width || c >= this.ClientSize.Height)
                timer1.Stop();
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            timer1.Stop();
        }
    }
}
