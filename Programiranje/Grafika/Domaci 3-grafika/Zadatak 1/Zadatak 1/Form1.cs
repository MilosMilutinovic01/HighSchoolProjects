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

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        int i = 0;

        private void timer1_Tick(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            Random r = new Random();
            SolidBrush cetka = new SolidBrush(Color.FromArgb(r.Next(256), r.Next(256), r.Next(256)));
            int a, b;
            a = r.Next(30,120);
            b = a;
            g.FillEllipse(cetka, r.Next(a, this.ClientSize.Width) - a, r.Next(b, this.ClientSize.Height) - b, a, b);
            i++;
            this.Text = i.ToString();
        }
    }
}
