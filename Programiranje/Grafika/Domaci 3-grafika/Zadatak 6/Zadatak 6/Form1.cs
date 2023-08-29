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

        int x=200, x1=200, y = 150, y1 = 250, a = 100, b = 100;

        private void Form1_Shown(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Refresh();
            Graphics g = this.CreateGraphics();
            SolidBrush cetka1 = new SolidBrush(Color.Red);
            SolidBrush cetka2 = new SolidBrush(Color.Black);
            Point[] kola ={
                        new Point(x+a/2,y),
                        new Point(x-a/2,y),
                        new Point(x-a/2,y-a/4),
                        new Point(x-a/4,y-a/4),
                        new Point(x-a/4,y-a/2),
                        new Point(x+a/4,y-a/2),
                        new Point(x+a/4,y-a/4),
                        new Point(x+a/2,y-a/4),
                        };
            g.FillPolygon(cetka1, kola);
            g.FillEllipse(cetka2, x - a / 4 - a / 6, y - a / 6, a / 3, a / 3);
            g.FillEllipse(cetka2, x + a / 4 - a / 6, y - a / 6, a / 3, a / 3);
            if (x >= this.ClientSize.Width)
                x = -20;
            x = x + 25;
            Point[] kola1 ={
                        new Point(x1+a/2,y1),
                        new Point(x1-a/2,y1),
                        new Point(x1-a/2,y1-a/4),
                        new Point(x1-a/4,y1-a/4),
                        new Point(x1-a/4,y1-a/2),
                        new Point(x1+a/4,y1-a/2),
                        new Point(x1+a/4,y1-a/4),
                        new Point(x1+a/2,y1-a/4),
                        };
            g.FillPolygon(cetka1, kola1);
            g.FillEllipse(cetka2, x1 - a / 4 - a / 6, y1 - a / 6, a / 3, a / 3);
            g.FillEllipse(cetka2, x1 + a / 4 - a / 6, y1 - a / 6, a / 3, a / 3);
            if (x1 <= 0)
                x1 = 420;
            x1 = x1 - 15;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
