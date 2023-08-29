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

        int x1, x2, y1, y2;
        
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            x1 = e.X;
            y1 = e.Y;
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            Graphics g = this.CreateGraphics();
            Pen olovka = new Pen(Color.Black, 2);
            x2 = e.X;
            y2 = e.Y;
            g.DrawLine(olovka, x1, y1, x2, y1);
            g.DrawLine(olovka, x2, y1, x2, y2);
            g.DrawLine(olovka, x2, y2, x1, y2);
            g.DrawLine(olovka, x1, y2, x1, y1);
        }
    }
}
