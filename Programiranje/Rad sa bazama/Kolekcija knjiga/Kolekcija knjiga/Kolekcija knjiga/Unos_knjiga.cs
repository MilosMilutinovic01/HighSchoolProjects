using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Kolekcija_knjiga
{
    public partial class Unos_knjiga : Form
    {
        public Unos_knjiga()
        {
            InitializeComponent();
        }

        OleDbCommand komanda;
        OleDbConnection konekcija;
        OleDbDataAdapter da;
        DataTable dt;

        void Konekcija()
        {
            komanda = new OleDbCommand();
            konekcija = new OleDbConnection();
            konekcija.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\Kolekcija Knjiga.mdb";
            komanda.Connection = konekcija;
            da = new OleDbDataAdapter();
            dt = new DataTable();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                textBox4.Enabled = false;
                textBox2.Enabled = false;
                comboBox2.Enabled = false;
                textBox3.Enabled = false;
                button1.Enabled = false;
                button2.Enabled = true;
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                textBox4.Enabled = true;
                textBox2.Enabled = true;
                comboBox2.Enabled = true;
                textBox3.Enabled = true;
                button1.Enabled = true;
                button2.Enabled = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
            komanda.CommandText = "INSERT INTO Knjiga (KnjigaID,Naziv,BrojStrana,KategorijaID,Komentar) VALUES(@id,@ime,@broj,@kategorija,@komentar)";
            komanda.Parameters.AddWithValue("@id", Convert.ToInt32(textBox1.Text));
            komanda.Parameters.AddWithValue("@ime", textBox4.Text);
            komanda.Parameters.AddWithValue("@broj", Convert.ToInt32(textBox2.Text));
            komanda.Parameters.AddWithValue("@kategorija", comboBox2.SelectedIndex + 1);
            komanda.Parameters.AddWithValue("@komentar", textBox3.Text);
            konekcija.Open();
            komanda.ExecuteNonQuery();
            MessageBox.Show("Uspesno ste uneli podatke.");
            konekcija.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Unos_knjiga_Load(object sender, EventArgs e)
        {
            Konekcija();
            komanda.CommandText = @"SELECT Naziv FROM Kategorija";
            da.SelectCommand = komanda;
            da.Fill(dt);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                comboBox2.Items.Add(dt.Rows[i]["Naziv"]);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Konekcija();
            komanda.CommandText = "DELETE FROM Knjiga WHERE KnjigaID=@id";
            komanda.Parameters.AddWithValue("@id", Convert.ToInt32(textBox1.Text));
            try
            {
                konekcija.Open();
                komanda.ExecuteNonQuery();
                MessageBox.Show("Uspesno ste izbrisali podatke.");
                konekcija.Close();
            }
            catch
            {
                MessageBox.Show("Greska pri brisanju podataka.");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Konekcija();
            komanda.CommandText = @"SELECT Knjiga.KnjigaID,Knjiga.Naziv,Knjiga.BrojStrana,Knjiga.KategorijaID,Knjiga.Komentar,Kategorija.Naziv FROM Knjiga
                                  INNER JOIN Kategorija ON Knjiga.KategorijaID=Kategorija.KategorijaID";
            da.SelectCommand=komanda;
            da.Fill(dt);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (textBox1.Text == dt.Rows[i]["KnjigaID"].ToString())
                {
                    textBox4.Text = dt.Rows[i]["Knjiga.Naziv"].ToString();
                    textBox2.Text = dt.Rows[i]["BrojStrana"].ToString();
                    comboBox2.Text = dt.Rows[i]["Kategorija.Naziv"].ToString();
                    textBox3.Text = dt.Rows[i]["Komentar"].ToString();
                    break;
                }
                else
                {
                    textBox4.Text = "";
                    textBox2.Text = "";
                    textBox3.Text = "";
                    comboBox2.Text = "";
                }
            }
        }
    }
}
