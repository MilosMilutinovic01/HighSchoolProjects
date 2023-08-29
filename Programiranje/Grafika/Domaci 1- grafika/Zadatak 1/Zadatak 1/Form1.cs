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
            
            Pen olovka1 = new Pen(Color.Red, 10);
            Pen olovka2 = new Pen(Color.Blue, 5);
            

        private void Form1_Shown(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            g.DrawLine(olovka2, new Point(this.ClientSize.Width / 2), new Point(this.ClientSize.Width / 2, this.ClientSize.Height));
            g.DrawLine(olovka2, new Point(this.ClientSize.Width / 4, this.ClientSize.Height / 3), new Point(this.ClientSize.Width - this.ClientSize.Width / 4, this.ClientSize.Height / 3));
            g.DrawLine(olovka1, new Point(this.ClientSize.Width / 2), new Point(this.ClientSize.Width / 4, this.ClientSize.Height / 3));
            g.DrawLine(olovka1, new Point(this.ClientSize.Width / 4, this.ClientSize.Height / 3), new Point(this.ClientSize.Width / 2, this.ClientSize.Height));
            g.DrawLine(olovka1, new Point(this.ClientSize.Width / 2, this.ClientSize.Height), new Point(this.ClientSize.Width - this.ClientSize.Width / 4, this.ClientSize.Height / 3));
            g.DrawLine(olovka1, new Point(this.ClientSize.Width - this.ClientSize.Width / 4, this.ClientSize.Height / 3), new Point(this.ClientSize.Width / 2));
            g.DrawLine(olovka1, 0, this.ClientSize.Height/2, this.ClientSize.Width, this.ClientSize.Height / 2);
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            this.Refresh();
            g.DrawLine(olovka2, new Point(this.ClientSize.Width / 2), new Point(this.ClientSize.Width / 2, this.ClientSize.Height));
            g.DrawLine(olovka2, new Point(this.ClientSize.Width / 4, this.ClientSize.Height / 3), new Point(this.ClientSize.Width - this.ClientSize.Width / 4, this.ClientSize.Height / 3));
            g.DrawLine(olovka1, new Point(this.ClientSize.Width / 2), new Point(this.ClientSize.Width / 4, this.ClientSize.Height / 3));
            g.DrawLine(olovka1, new Point(this.ClientSize.Width / 4, this.ClientSize.Height / 3), new Point(this.ClientSize.Width / 2, this.ClientSize.Height));
            g.DrawLine(olovka1, new Point(this.ClientSize.Width / 2, this.ClientSize.Height), new Point(this.ClientSize.Width - this.ClientSize.Width / 4, this.ClientSize.Height / 3));
            g.DrawLine(olovka1, new Point(this.ClientSize.Width - this.ClientSize.Width / 4, this.ClientSize.Height / 3), new Point(this.ClientSize.Width / 2));
        }
    }
}
