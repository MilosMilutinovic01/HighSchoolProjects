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

        int r, k, i, j;
        int[,] niz;

        private void unosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
            textBox1.Visible = true;
            button1.Visible = true;
            listBox1.Visible = false;
            groupBox1.Visible = false;
        }

        private void izlazToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = true;
            button2.Visible = true;
            dataGridView1.ScrollBars = ScrollBars.None;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.ColumnHeadersVisible = false;
            r = Convert.ToInt32(textBox1.Text);
            k = r;
            dataGridView1.ColumnCount = r;
            dataGridView1.RowCount = k;
            for (i = 0; i < k; i++)
            {
                dataGridView1.Columns[i].Width = 30;
            }
            for (j = 0; j < r; j++)
            {
                dataGridView1.Rows[j].Height = 30;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            niz = new int[r, k];
            for (i = 0; i < k; i++)
                for (j = 0; j < r; j++)
                {
                    niz[i, j] = Convert.ToInt32(dataGridView1[j, i].Value);
                }
        }

        private void prikazToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listBox1.Visible = true;
            groupBox1.Visible = true;
            label1.Visible = false;
            dataGridView1.Visible = false;
            button2.Visible = false;
            textBox1.Visible = false;
            button1.Visible = false;
            string s = "";
            for (i = 0; i < k; i++)
            {
                for (j = 0; j < r; j++)
                {
                    s = s + niz[i, j].ToString() + " ";
                }
                listBox1.Items.Add(s);
                s = "";
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                int n = 0;
                for (i = 0; i < k; i++)
                {
                    for (j = 0; j < r; j++)
                    {
                        n = n + niz[i, j];
                    }
                    textBox2.Text = n.ToString();
                }
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            int n=0;
            for (i = 0; i < k; i++)
            {
                for (j = 0; j < r; j++)
                {
                    if (i == j)
                        n = n + niz[i, j];
                }
                textBox3.Text = n.ToString();
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            int n = 0;
            for (i = 0; i < k; i++)
            {
                for (j = 0; j < r; j++)
                {
                    if (i + j == i + 1)
                        n = n + niz[i, j];
                }
                textBox4.Text = n.ToString();
            }
        }
    }
}
