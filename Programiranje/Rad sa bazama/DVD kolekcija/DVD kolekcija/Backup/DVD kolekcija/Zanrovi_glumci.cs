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
    public partial class Zanrovi_glumci : Form
    {
        public Zanrovi_glumci()
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

        private void Zanrovi_glumci_Load(object sender, EventArgs e)
        {
            Konekcija();
            dt = new DataTable();
            komanda.CommandText = "SELECT * FROM Zanr ORDER BY NazivZanra ASC";
            da.SelectCommand = komanda;
            da.Fill(dt);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                comboBox1.Items.Add(dt.Rows[i]["NazivZanra"]);
            }
            dt.Clear();
            komanda.CommandText = "SELECT Ime,Prezime FROM Glumac";
            da.SelectCommand = komanda;
            da.Fill(dt);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                textBox1.AutoCompleteCustomSource.Add(dt.Rows[i]["Ime"].ToString());
                textBox2.AutoCompleteCustomSource.Add(dt.Rows[i]["Prezime"].ToString());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            Konekcija();
            komanda.CommandText = @"SELECT Film.NazivFilma,Zanr.NazivZanra,Uloga.ImeLika,Tip_Uloge.TipUloge
                                    FROM (((Film INNER JOIN Zanr ON Film.ZanrID=Zanr.ZanrID)
                                    INNER JOIN Uloga on Film.FilmID=Uloga.FilmID)
                                    INNER JOIN Glumac ON Uloga.GlumacID=GLumac.GlumacID)
                                    INNER JOIN Tip_Uloge ON Uloga.TipUlogeID=Tip_Uloge.TipUlogeID
                                    WHERE NazivZanra=@zanr AND Glumac.Ime=@ime AND Glumac.Prezime=@prezime
                                    ORDER BY Trajanje DESC";
            komanda.Parameters.AddWithValue("@zanr", comboBox1.Text);
            komanda.Parameters.AddWithValue("@ime", textBox1.Text);
            komanda.Parameters.AddWithValue("@prezime", textBox2.Text);
            dt = new DataTable();
            da.SelectCommand = komanda;
            da.Fill(dt);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                listBox1.Items.Add("Naziv filma: " + dt.Rows[i]["NazivFilma"] + " Ime lika: " + dt.Rows[i]["ImeLika"].ToString() + " Tip uloge: " + dt.Rows[i]["TipUloge"]);
            }
        }
    }
}
