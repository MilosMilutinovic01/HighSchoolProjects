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

        int i = 0;

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Refresh();
            Graphics g = this.CreateGraphics();
            SolidBrush cetka1 = new SolidBrush(Color.White);
            SolidBrush cetka2 = new SolidBrush(Color.Brown);
            Pen olovka = new Pen(Color.Brown, 6);
            Point[] trup ={
            new Point(200+i, 230),
            new Point(370+i, 230),
            new Point(350+i, 250),
            new Point(220+i, 250),
            new Point(200+i, 230),   
            };
            Point[] jarbol ={
            new Point(283+i, 150),
            new Point(310+i, 180),
            new Point(283+i, 200),
            new Point(283+i, 150)
            };
            g.FillPolygon(cetka2, trup);
            g.FillPolygon(cetka1, jarbol);
            g.DrawLine(olovka, 285+i, 230, 285+i, 150);
            i=i-5;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
            timer2.Stop();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            this.Refresh();
            Graphics g = this.CreateGraphics();
            SolidBrush cetka1 = new SolidBrush(Color.White);
            SolidBrush cetka2 = new SolidBrush(Color.Brown);
            Pen olovka = new Pen(Color.Brown, 6);
            Point[] trup ={
            new Point(200+i, 230),
            new Point(370+i, 230),
            new Point(350+i, 250),
            new Point(220+i, 250),
            new Point(200+i, 230),   
            };
            Point[] jarbol ={
            new Point(283+i, 150),
            new Point(310+i, 180),
            new Point(283+i, 200),
            new Point(283+i, 150),   
            };
            g.FillPolygon(cetka2, trup);
            g.FillPolygon(cetka1, jarbol);
            g.DrawLine(olovka, 285+i, 230, 285+i, 150);
            i=i+5;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            timer2.Start();
            timer1.Stop();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            timer2.Stop();
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            SolidBrush cetka1 = new SolidBrush(Color.White);
            SolidBrush cetka2 = new SolidBrush(Color.Brown);
            Pen olovka = new Pen(Color.Brown, 6);
            Point[] trup ={
            new Point(200+i, 230),
            new Point(370+i, 230),
            new Point(350+i, 250),
            new Point(220+i, 250),
            new Point(200+i, 230),   
            };
            Point[] jarbol ={
            new Point(283+i, 150),
            new Point(310+i, 180),
            new Point(283+i, 200),
            new Point(283+i, 150),   
            };
            g.FillPolygon(cetka2, trup);
            g.FillPolygon(cetka1, jarbol);
            g.DrawLine(olovka, 285 + i, 230, 285 + i, 150);
        }
    }
}
