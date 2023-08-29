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

        int x, y;
        bool x1, y1;
        SolidBrush cetka = new SolidBrush(Color.Black);
        
        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            x = e.X;
            y = e.Y;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Refresh();
            Graphics g = this.CreateGraphics();
            Random r=new Random();
            if (x > this.ClientSize.Width - 20)
            {
                x1 = false;
                cetka.Color = Color.FromArgb(r.Next(0, 255), r.Next(0, 255), r.Next(0, 255));
            }
            if (x < 0)
            {
                x1 = true;
                cetka.Color = Color.FromArgb(r.Next(0, 255), r.Next(0, 255), r.Next(0, 255));
            }
            if (y > this.ClientSize.Height - 20)
            {
                y1 = false;
                cetka.Color = Color.FromArgb(r.Next(0, 255), r.Next(0, 255), r.Next(0, 255));
            }
            if (y < 0)
            {
                y1 = true;
                cetka.Color = Color.FromArgb(r.Next(0, 255), r.Next(0, 255), r.Next(0, 255));
            }
            g.FillEllipse(cetka, x, y, 20, 20);
            if (x1)
                x += 10;
            else
                x -= 10;
            if (y1)
                y += 10;
            else
                y -= 10;
        }
    }
}
