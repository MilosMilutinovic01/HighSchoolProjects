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
            timer1.Start();
            x = r.Next(pictureBox1.Width);
            y = r.Next(pictureBox1.Height);
            a = 0;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Refresh();
        }

        int x = 0, y = 0, a = 0;
        Random r = new Random();

        private void timer1_Tick(object sender, EventArgs e)
        {
            Graphics g = pictureBox1.CreateGraphics();
            Pen olovka = new Pen(Color.Blue);
            a = a + 5;

            g.DrawEllipse(olovka, x - a, y - a, 2 * a, 2 * a);
        }
    }
}
