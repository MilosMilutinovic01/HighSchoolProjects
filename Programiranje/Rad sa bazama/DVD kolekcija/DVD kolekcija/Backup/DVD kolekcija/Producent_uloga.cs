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
    public partial class Producent_uloga : Form
    {
        public Producent_uloga()
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

        private void Producent_uloga_Load(object sender, EventArgs e)
        {
            Konekcija();
            dt = new DataTable();
            komanda.CommandText = "SELECT * FROM Tip_Uloge ORDER BY TipUloge ASC";
            da.SelectCommand = komanda;
            da.Fill(dt);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                comboBox1.Items.Add(dt.Rows[i]["TipUloge"]);
            }
            dt.Clear();
            komanda.CommandText = "SELECT * FROM Producent ORDER BY Ime ASC";
            da.SelectCommand = komanda;
            da.Fill(dt);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                comboBox2.Items.Add(dt.Rows[i]["Ime"]);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                listBox1.Items.Clear();
                Konekcija();
                komanda.CommandText = @"SELECT Film.NazivFilma,Zanr.NazivZanra,Glumac.Ime,Glumac.Prezime
                                    FROM (((((Film INNER JOIN Producirao ON Film.FilmID=Producirao.FilmID)
                                    INNER JOIN Uloga on Film.FilmID=Uloga.FilmID)
                                    INNER JOIN Glumac ON Uloga.GlumacID=Glumac.GlumacID)
                                    INNER JOIN Tip_Uloge ON Uloga.TipUlogeID=Tip_Uloge.TipUlogeID)
                                    INNER JOIN Producent ON Producirao.ProducentID=Producent.ProducentID)
                                    INNER JOIN Zanr ON Film.ZanrID=Zanr.ZanrID
                                    WHERE Tip_Uloge.TipUloge=@tip AND Producent.Ime=@producent
                                    ORDER BY Film.NazivFilma ASC";
                komanda.Parameters.AddWithValue("@tip", comboBox1.Text);
                komanda.Parameters.AddWithValue("@producent", comboBox2.Text);
                dt = new DataTable();
                da.SelectCommand = komanda;
                da.Fill(dt);
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    listBox1.Items.Add("Naziv filma: " + dt.Rows[i]["NazivFilma"].ToString() + ", Zanr: " + dt.Rows[i]["NazivZanra"].ToString() + ", Ime: " + dt.Rows[i]["Ime"].ToString() + ", Prezime: " + dt.Rows[i]["Prezime"]);
                }
            }
            catch
            {
                MessageBox.Show("Ne postoji producent sa datim tipom uloge");
            }
        }
    }
}
