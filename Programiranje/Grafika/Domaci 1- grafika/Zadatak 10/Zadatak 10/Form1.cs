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

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            Random r = new Random();
            Font a = new Font(FontFamily.Families[r.Next(0, FontFamily.Families.Length)], Convert.ToSingle(comboBox1.Text));
            richTextBox1.SelectionFont = a;
        }
    }
}
