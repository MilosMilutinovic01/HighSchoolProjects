using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace DVD_kolekcija
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        OleDbConnection konekcija;
        OleDbCommand komanda;
        OleDbDataAdapter da;
        DataTable dt;

        void Konekcija()
        {
            konekcija = new OleDbConnection();
            konekcija.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\DVD_kolekcija.mdb";
            komanda = new OleDbCommand();
            da = new OleDbDataAdapter();
            komanda.Connection = konekcija;
        }

        private void izlazToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Konekcija();
                konekcija.Open();
                komanda.CommandText = "ALTER TABLE Producent ADD Web_sajt CHAR(50)";
                komanda.Connection = konekcija;
                komanda.ExecuteNonQuery();
                komanda.CommandText = @"CREATE TABLE Nagrade(
                                    NagradaID NUMBER PRIMARY KEY,
                                    Naziv_nagrade CHAR(50),
                                    Datum DATE,
                                    FilmID NUMBER REFERENCES Film(FilmID))";  //ZASTO OVAJ DEO PRAVI PROBLEM PRI IZVRSAVANJU KODA!!!!!!!!!
                
                komanda.ExecuteNonQuery();
                konekcija.Close();
                MessageBox.Show("Baza je uspesno azurirana");
            }
            catch
            {
                MessageBox.Show("Baza je vec azurirana");
            }
        }

        private void glumciToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Glumci g = new Glumci();
            g.Show();
        }

        private void producentiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Producenti p = new Producenti();
            p.Show();
        }

        private void poZanrovimaIGlumcimaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Zanrovi_glumci zg = new Zanrovi_glumci();
            zg.Show();
        }

        private void poTipuUlogeIProducentuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Producent_uloga pu = new Producent_uloga();
            pu.Show();
        }
    }
}
