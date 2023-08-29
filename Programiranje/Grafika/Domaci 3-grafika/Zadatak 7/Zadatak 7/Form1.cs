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
            int r = Convert.ToInt32(textBox1.Text);
            int k = Convert.ToInt32(textBox2.Text);
            int[,] a = new int[r, k];
            dataGridView1.RowCount = r;
            dataGridView1.ColumnCount = k;
            dataGridView1.ScrollBars = ScrollBars.None;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.ColumnHeadersVisible = false;
        } 

        private void button2_Click(object sender, EventArgs e)
        {
            int z = 0;
            int r = Convert.ToInt32(textBox1.Text);
            int k = Convert.ToInt32(textBox2.Text);
            int[,] a = new int[r, k];
            for (int j = 0; j < r; j++)
            {
                for (int i = 0; i < k; i++)
                {
                    a[i, j] = Convert.ToInt32(dataGridView1[j, i].Value);
                    z += a[i, j];
                }
            }
            textBox3.Text = z.ToString();
        }
    }
}
