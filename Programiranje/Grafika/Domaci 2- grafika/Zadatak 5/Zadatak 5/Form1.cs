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

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            Graphics g = this.CreateGraphics();
            Pen olovka = new Pen(Color.Red, 2);
            int x, y;
            x = e.X;
            y = e.Y;
            g.DrawLine(olovka, x - 15, y - 15, x + 15, y - 15);
            g.DrawLine(olovka, x + 15, y - 15, x + 15, y + 15);
            g.DrawLine(olovka, x + 15, y + 15, x - 15, y + 15);
            g.DrawLine(olovka, x - 15, y + 15, x - 15, y - 15);
            g.DrawLine(olovka, x - 15, y - 15, x + 15, y + 15);
            g.DrawLine(olovka, x - 15, y + 15, x + 15, y - 15);
        }
    }
}
