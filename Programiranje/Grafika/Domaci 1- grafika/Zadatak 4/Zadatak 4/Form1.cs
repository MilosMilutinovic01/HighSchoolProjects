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
        Point a = new Point();
        Point b = new Point();

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Enabled = !timer1.Enabled;
            a.X = r.Next(this.ClientSize.Width);
            a.Y = r.Next(this.ClientSize.Height);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Pen olovka=new Pen(Color.FromArgb(r.Next(256),r.Next(256),r.Next(256)),2);
            Graphics g = this.CreateGraphics();
            b.X = r.Next(0, this.ClientSize.Width);
            b.Y = r.Next(0, this.ClientSize.Height);
            g.DrawLine(olovka, a, b);
            a = b;
        }
    }
}
