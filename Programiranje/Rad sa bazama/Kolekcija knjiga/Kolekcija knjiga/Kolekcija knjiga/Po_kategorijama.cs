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
    public partial class Po_kategorijama : Form
    {
        public Po_kategorijama()
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

        private void Po_kategorijama_Load(object sender, EventArgs e)
        {
            Konekcija();
            komanda.CommandText = "SELECT * FROM Kategorija";
            da.SelectCommand = komanda;
            da.Fill(dt);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                checkedListBox1.Items.Add(dt.Rows[i]["Naziv"]);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Konekcija();
            try
            {
                if (i == 3)
                {
                    chart1.Series[0].Points.Clear();
                    int[] y = new int[3];
                    string[] x = new string[3];
                    Konekcija();
                    komanda.CommandText = @"SELECT Kategorija.Naziv,SUM(Knjiga.KategorijaID) AS Ime
                    FROM Kategorija INNER JOIN Knjiga ON Kategorija.KategorijaID=Knjiga.KategorijaID
                    WHERE Kategorija.Naziv IN(@ime1,@ime2,@ime3)
                    GROUP BY Kategorija.Naziv";
                    komanda.Parameters.AddWithValue("@ime1", checkedListBox1.CheckedItems[0]);
                    komanda.Parameters.AddWithValue("@ime2", checkedListBox1.CheckedItems[1]);
                    komanda.Parameters.AddWithValue("@ime3", checkedListBox1.CheckedItems[2]);
                    da.SelectCommand = komanda;
                    da.Fill(dt);
                    x[0] = dt.Rows[0]["Naziv"].ToString();
                    x[1] = dt.Rows[1]["Naziv"].ToString();
                    x[2] = dt.Rows[2]["Naziv"].ToString();
                    y[0] = Convert.ToInt32(dt.Rows[0]["Ime"]);
                    y[1] = Convert.ToInt32(dt.Rows[1]["Ime"]);
                    y[2] = Convert.ToInt32(dt.Rows[2]["Ime"]);
                    chart1.Series[0].Points.AddXY(x[0], y[0]);
                    chart1.Series[0].Points.AddXY(x[1], y[1]);
                    chart1.Series[0].Points.AddXY(x[2], y[2]);
                }
                else
                    throw new Exception("Moraju biti cekirane tacno 3 stavke");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        int i = 0;

        private void checkedListBox1_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (e.NewValue == CheckState.Checked)
            {
                i++;
            }
            else
            {
                i--;
            }
            this.Text = i.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
