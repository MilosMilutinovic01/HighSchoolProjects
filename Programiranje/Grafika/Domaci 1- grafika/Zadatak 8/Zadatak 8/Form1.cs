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
            this.Refresh();
            SolidBrush flomaster = new SolidBrush(Color.Red);
            Random r = new Random();
            Graphics g = this.CreateGraphics();
            g.FillEllipse(flomaster, r.Next(this.ClientSize.Width - 30), r.Next(this.ClientSize.Height - 30), 30, 30);
        }
    }
}
