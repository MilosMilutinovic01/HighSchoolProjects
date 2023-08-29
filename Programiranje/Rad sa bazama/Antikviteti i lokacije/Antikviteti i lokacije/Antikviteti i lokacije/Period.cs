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
    public partial class Period : Form
    {
        public Period()
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Konekcija();
            komanda.CommandText = "SELECT * FROM Period";
            da.SelectCommand = komanda;
            da.Fill(dt);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (textBox1.Text == dt.Rows[i][0].ToString())
                {
                    textBox2.Text = dt.Rows[i][1].ToString();
                    break;
                }
                else if (textBox1.Text != dt.Rows[i][0].ToString())
                {
                    textBox2.Text = "";
                    break;
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Konekcija();
            komanda.CommandText = "DELETE FROM Period WHERE PeriodID=@ID";
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
            komanda.CommandText = @"UPDATE Period
                                    SET PeriodID=@ID,Period=@Period
                                    WHERE PeriodID=@ID";
            komanda.Parameters.AddWithValue("@ID", Convert.ToInt32(textBox1.Text));
            komanda.Parameters.AddWithValue("@Period", textBox2.Text);
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
    }
}
