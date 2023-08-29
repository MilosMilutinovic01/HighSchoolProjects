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
    public partial class Tip_antikviteta : Form
    {
        public Tip_antikviteta()
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
            dt = new DataTable();
            da = new OleDbDataAdapter();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Konekcija();
            komanda.CommandText = "SELECT * FROM TIP_ANTIKVITETA";
            da.SelectCommand = komanda;
            da.Fill(dt);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (textBox1.Text == dt.Rows[i][0].ToString())
                {
                    textBox2.Text = dt.Rows[i][1].ToString();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Konekcija();
            komanda.CommandText = "INSERT INTO TIP_ANTIKVITETA (TipAntikvitetaID,Tip) VALUES (@ID,@Tip)";
            komanda.Parameters.AddWithValue("@ID", Convert.ToInt32(textBox1.Text));
            komanda.Parameters.AddWithValue("@Tip", textBox2.Text);
            try
            {
                konekcija.Open();
                komanda.ExecuteNonQuery();
                konekcija.Close();
                MessageBox.Show("Uspesno ste uneli podatke");
            }
            catch
            {
                MessageBox.Show("Greska pri unosu podataka");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Konekcija();
            komanda.CommandText = "DELETE FROM TIP_ANTIKVITETA WHERE TipAntikvitetaID=@ID";
            komanda.Parameters.AddWithValue("@ID", Convert.ToInt32(textBox1.Text));
            try
            {
                konekcija.Open();
                komanda.ExecuteNonQuery();
                konekcija.Close();
                MessageBox.Show("Uspesno ste obrisali podatke");
            }
            catch
            {
                MessageBox.Show("Greska pri brisanju podataka");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Konekcija();
            komanda.CommandText = @"UPDATE TIP_ANTIKVITETA
                                    SET TipAntikvitetaID=@ID,Tip=@Tip
                                    WHERE TipAntikvitetaID=@ID";
            komanda.Parameters.AddWithValue("@ID", Convert.ToInt32(textBox1.Text));
            komanda.Parameters.AddWithValue("@Tip", textBox2.Text);
            try
            {
                konekcija.Open();
                komanda.ExecuteNonQuery();
                konekcija.Close();
                MessageBox.Show("Uspesno ste izmenili podatke");
            }
            catch
            {
                MessageBox.Show("Greska pri izmeni podataka");
            }
        }

        private void Tip_antikviteta_Load(object sender, EventArgs e)
        {
            Konekcija();
            komanda.CommandText="SELECT * FROM TIP_ANTIKVITETA";
            da.SelectCommand=komanda;
            da.Fill(dt);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                textBox1.AutoCompleteCustomSource.Add(dt.Rows[i]["TipAntikvitetaID"].ToString());
                textBox2.AutoCompleteCustomSource.Add(dt.Rows[i]["Tip"].ToString());
            }
        }
    }
}
