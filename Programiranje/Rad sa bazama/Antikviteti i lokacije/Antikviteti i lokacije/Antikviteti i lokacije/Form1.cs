using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Antikviteti_i_lokacije
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        OleDbConnection konekcija;
        OleDbCommand komanda;
        DataTable dt;
        OleDbDataAdapter da;

        void Konekcija()
        {
            konekcija = new OleDbConnection();
            konekcija.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\Antikviteti i lokacije.mdb";
            komanda = new OleDbCommand();
            komanda.Connection = konekcija;
        }

        private void tipAntikvitetaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tip_antikviteta ta = new Tip_antikviteta();
            ta.Show();
        }

        private void izlazToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Konekcija();
            try
            {
                konekcija.Open();
//                komanda.CommandText = @"CREATE TABLE Grad(
//                                GradID NUMBER PRIMARY KEY,
//                                Grad CHAR(30),
//                                PozivniBroj CHAR(30),
//                                PostanskiBroj CHAR(30),
//                                BrojStanovnika CHAR(30),
//                                DrzavaID NUMBER)";
//                komanda.ExecuteNonQuery();
                komanda.CommandText = @"ALTER TABLE Lokalitet
                                    ADD FOREIGN KEY(NajbliziGrad) REFERENCES Grad(GradID)";
                komanda.ExecuteNonQuery();
                komanda.CommandText = @"CREATE TABLE Drzava(
                                    DrzavaID NUMBER PRIMARY KEY,
                                    Drzava CHAR(30),
                                    PozivniBroj CHAR(30),
                                    BrojStanovnika CHAR(30))";
                komanda.ExecuteNonQuery();
                komanda.CommandText = @"ALTER TABLE Grad
                                    ADD FOREIGN KEY(DrzavaID) REFERENCES Drzava(DrzavaID)";
                komanda.ExecuteNonQuery();
                konekcija.Close();
                MessageBox.Show("Baza je uspesno azurirana.");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void poArheologuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Po_arheologu pa = new Po_arheologu();
            pa.Show();
        }

        private void periodiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Period p = new Period();
            p.Show();
        }

        private void poTipuAntikvitetaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Po_tipu_antikviteta pta = new Po_tipu_antikviteta();
            pta.Show();
        }
    }
}
