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

        bool a = true;

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.Refresh();
            Graphics g = pictureBox1.CreateGraphics();
            Pen olovka=new Pen(Color.Red,10);
            SolidBrush flomaster = new SolidBrush(Color.Blue);
            if (a == true)
                g.DrawLine(olovka, 0, 0, pictureBox1.ClientSize.Width, pictureBox1.ClientSize.Height);
            if(a==false)
                g.FillEllipse(flomaster, 0, 0, pictureBox1.ClientSize.Width, pictureBox1.ClientSize.Height);
            a =! a;
        }
    }
}
