using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FudbalLiga
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void izadjiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void unosMecevaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Unos_meceva um = new Unos_meceva();
            um.Show();
        }
    }
}
