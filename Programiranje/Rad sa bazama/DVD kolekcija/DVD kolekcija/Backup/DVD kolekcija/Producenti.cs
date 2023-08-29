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
    public partial class Producenti : Form
    {
        public Producenti()
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

        private void Producenti_Load(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            Konekcija();
            dt = new DataTable();
            komanda.CommandText = "SELECT * FROM Producent ORDER BY ProducentID ASC";
            da.SelectCommand = komanda;
            da.Fill(dt);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                string id = dt.Rows[i]["ProducentID"].ToString();
                string ime = dt.Rows[i]["Ime"].ToString();
                string email = dt.Rows[i]["Email"].ToString();
                
                listBox1.Items.Add(id.PadLeft(5 - id.Length) + "\t\t" + ime + "\t\t" + email);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox1.Text = dt.Rows[listBox1.SelectedIndex]["ProducentID"].ToString();
            textBox2.Text = dt.Rows[listBox1.SelectedIndex]["Ime"].ToString();
            textBox3.Text = dt.Rows[listBox1.SelectedIndex]["Email"].ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Konekcija();
            komanda.CommandText = "INSERT INTO Producent (ProducentID,Ime,Email) VALUES(@ID,@ime,@email)";
            komanda.Parameters.AddWithValue("@ID", textBox1.Text);
            komanda.Parameters.AddWithValue("@ime", textBox2.Text);
            komanda.Parameters.AddWithValue("@email", textBox3.Text);
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
            Producenti_Load(sender, e);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Konekcija();
            try
            {
                konekcija.Open();
                komanda.CommandText = "DELETE FROM Producirao WHERE ProducentID=@ID";
                komanda.Parameters.AddWithValue("@ID", textBox1.Text);
                komanda.ExecuteNonQuery();
                komanda.CommandText = "DELETE FROM Producent WHERE ProducentID=@ID";
                komanda.Parameters.AddWithValue("@ID", textBox1.Text);
                komanda.ExecuteNonQuery();
                konekcija.Close();
                MessageBox.Show("Uspesno ste izbrisali podatak.");
            }
            catch
            {
                MessageBox.Show("Podatak ne postoji u bazi.");
            }
            Producenti_Load(sender, e);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Konekcija();
            komanda.CommandText = "UPDATE Producent SET Ime=@ime,Email=@email WHERE ProducentID=@ID";
            komanda.Parameters.AddWithValue("@ime", textBox2.Text);
            komanda.Parameters.AddWithValue("@email", textBox3.Text);
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
            Producenti_Load(sender, e);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
