using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Kolekcija_knjiga
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void izlazToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void knjigeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Unos_knjiga uk = new Unos_knjiga();
            uk.Show();
        }

        private void poKategorijamaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Po_kategorijama pk = new Po_kategorijama();
            pk.Show();
        }
    }
}
