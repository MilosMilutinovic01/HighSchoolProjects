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
            timer1.Stop();
        }

        int x, y;

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            Random r=new Random();
            Graphics g = this.CreateGraphics();
            Pen olovka=new Pen(Color.FromArgb(r.Next(256),r.Next(256),r.Next(256)),2);
            g.DrawLine(olovka,x,y,r.Next(x-100,x+100),r.Next(y-100,y+100));
        }

        private void Form1_Shown_1(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void Form1_MouseClick_1(object sender, MouseEventArgs e)
        {
            x = e.X;
            y = e.Y;
            timer1.Start();
        }
    }
}
