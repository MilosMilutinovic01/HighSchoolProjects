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

        Random r = new Random();
        int[] a = new int[10];
        int[] b = new int[10];
        int[] x = new int[10];
        int[] y = new int[10];

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Refresh();
            Graphics g = this.CreateGraphics();
            Pen olovka = new Pen(Color.White, 4);
            for (int i = 0; i < 10; i++)
            {
                if (y[i] - 30 >= this.ClientSize.Height)
                {
                    y[i] = -30;
                    a[i] = r.Next(15, 35);
                    b[i] = r.Next(4, 10);
                }
                g.DrawLine(olovka, x[i] - a[i], y[i] - a[i], x[i] + a[i], y[i] + a[i]);
                g.DrawLine(olovka, x[i] - a[i], y[i] + a[i], x[i] + a[i], y[i] - a[i]);
                g.DrawLine(olovka, x[i] - 5, y[i], x[i] + 5, y[i]);
                g.DrawLine(olovka, x[i], y[i] - 5, x[i], y[i] + 5);
                y[i] = y[i] + b[i];
            }
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                a[i] = r.Next(15, 35);
            }
            for (int i = 0; i < 10; i++)
            {
                b[i] = r.Next(4, 10);
            }
            for (int i = 1; i < 10; i++)
            {
                int z;
                x[0] = 50;
                z=x[0];
                x[i] = x[i - 1] + z;
            }
            for (int i = 0; i < 10; i++)
            {
                y[i] = -30;
            }
            timer1.Enabled = true; ;
        }
    }
}
