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
    public partial class Glumci : Form
    {
        public Glumci()
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

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string sifra = textBox1.Text;
            Konekcija();
            dt = new DataTable();
            komanda.CommandText="SELECT * FROM Glumac";
            da.SelectCommand=komanda;
            da.Fill(dt);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (dt.Rows[i]["GlumacID"].ToString() == sifra)
                {
                    textBox2.Text = dt.Rows[i]["Ime"].ToString();
                    textBox3.Text = dt.Rows[i]["Prezime"].ToString();
                    DateTime datum = new DateTime();
                    datum = DateTime.Parse(dt.Rows[i]["DatumRodjenja"].ToString());
                    textBox4.Text = datum.ToString("MM/dd/yyyy");
                    textBox5.Text = dt.Rows[i]["MestoRodjenja"].ToString();
                    break;//Mora da se stavi break zato sto svaki sledeci prolaz for petlje dobija drugu vrednost za ID i samim tim izvrava else if koji brise tekbox-ove
                }
                else if (dt.Rows[i]["GlumacID"].ToString() != sifra)
                {
                    textBox2.Clear();
                    textBox3.Clear();
                    textBox4.Clear();
                    textBox5.Clear();
                }
            }
        }

        private void Glumci_Load(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            Konekcija();
            dt = new DataTable();
            komanda.CommandText = "SELECT * FROM Glumac ORDER BY GlumacID ASC";
            da.SelectCommand = komanda;
            da.Fill(dt);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                string glumacID = dt.Rows[i]["GlumacID"].ToString();
                string ime = dt.Rows[i]["Ime"].ToString();
                string prezime = dt.Rows[i]["Prezime"].ToString();
                DateTime dat = new DateTime();
                dat = DateTime.Parse(dt.Rows[i]["DatumRodjenja"].ToString());
                string datumRodjenja = dat.ToString("MM/dd/yyyy");
                string mestoRodjenja = dt.Rows[i]["MestoRodjenja"].ToString();
                listBox1.Items.Add(glumacID.PadLeft(5 - glumacID.Length) + "\t" + ime.PadRight(20 - ime.Length) + "\t" + prezime.PadRight(20 - prezime.Length) + "\t" + datumRodjenja.PadRight(30 - datumRodjenja.Length) + "\t" + mestoRodjenja);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox1.Text = dt.Rows[listBox1.SelectedIndex]["GlumacID"].ToString();//Zasto cita dobar ID a ostalo pomere za jedan(ime,prezime...)????????
            textBox2.Text = dt.Rows[listBox1.SelectedIndex]["Ime"].ToString();
            textBox3.Text = dt.Rows[listBox1.SelectedIndex]["Prezime"].ToString();
            textBox4.Text = dt.Rows[listBox1.SelectedIndex]["DatumRodjenja"].ToString().Substring(0,10);//Zasto ne prikazuje datum iz listbox-a???????
            textBox5.Text = dt.Rows[listBox1.SelectedIndex]["MestoRodjenja"].ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Konekcija();
            komanda.CommandText = "INSERT INTO Glumac (GlumacID,Ime,Prezime,DatumRodjenja,MestoRodjenja) VALUES(@ID,@ime,@prezime,@datum,@mesto)";
            komanda.Parameters.AddWithValue("@ID", textBox1.Text);
            komanda.Parameters.AddWithValue("@ime", textBox2.Text);
            komanda.Parameters.AddWithValue("@prezime", textBox3.Text);
            komanda.Parameters.AddWithValue("@datum", textBox4.Text);
            komanda.Parameters.AddWithValue("@mesto", textBox5.Text);
            try
            {
                konekcija.Open();
                komanda.ExecuteNonQuery();
                konekcija.Close();
                MessageBox.Show("Uspesno ste uneli podatke.");
            }
            catch
            {
                MessageBox.Show("Podaci vec postoje u bazi.");
            }
            Glumci_Load(sender, e);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Konekcija();
            try
            {
                konekcija.Open();
                komanda.CommandText = "DELETE FROM Uloga WHERE GlumacID=@ID";
                komanda.Parameters.AddWithValue("@ID", textBox1.Text);
                komanda.ExecuteNonQuery();
                komanda.CommandText = "DELETE FROM Glumac WHERE GlumacID=@ID";
                komanda.Parameters.AddWithValue("@ID", textBox1.Text);
                komanda.ExecuteNonQuery();
                konekcija.Close();
                MessageBox.Show("Uspesno ste izbrisali podatak.");
            }
            catch
            {
                MessageBox.Show("Podatak ne postoji u bazi.");
            }
            Glumci_Load(sender, e);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Konekcija();
            komanda.CommandText = "UPDATE Glumac SET Ime=@ime,Prezime=@prezime,DatumRodjenja=@datum,MestoRodjenja=@mesto WHERE GlumacID=@ID";
            komanda.Parameters.AddWithValue("@ime", textBox2.Text);
            komanda.Parameters.AddWithValue("@prezime", textBox3.Text);
            komanda.Parameters.AddWithValue("@datum", textBox4.Text);
            komanda.Parameters.AddWithValue("@mesto", textBox5.Text);
            komanda.Parameters.AddWithValue("@ID", textBox1.Text);
            try
            {
                konekcija.Open();
                komanda.ExecuteNonQuery();
                konekcija.Close();
                MessageBox.Show("Uspesno ste azurirali podatke.");
            }
            catch
            {
                MessageBox.Show("Greska pri azuriranju podataka.");
            }
            Glumci_Load(sender, e);
        }
    }
}
