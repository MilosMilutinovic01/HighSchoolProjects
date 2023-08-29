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
    public partial class Po_tipu_antikviteta : Form
    {
        public Po_tipu_antikviteta()
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

        private void Po_tipu_antikviteta_Load(object sender, EventArgs e)
        {
            Konekcija();
            komanda.CommandText = "SELECT * FROM Tip_Antikviteta";
            da.SelectCommand = komanda;
            da.Fill(dt);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                textBox1.AutoCompleteCustomSource.Add(dt.Rows[i]["Tip"].ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Konekcija();
            komanda.CommandText = @"SELECT Lokalitet.LokalitetIme,Lokalitet.KoordinateDuzina,Lokalitet.KoordinateSirina
            FROM (Lokalitet INNER JOIN Antikvitet ON Lokalitet.LokalitetID=Antikvitet.LokalitetID)
            INNER JOIN Tip_Antikviteta ON Antikvitet.TipAntikviteta=Tip_Antikviteta.TipAntikvitetaID
            WHERE Tip_Antikviteta.Tip=@Tip";
            komanda.Parameters.AddWithValue("@Tip", textBox1.Text);
            da.SelectCommand = komanda;
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox1.Refresh();
            Graphics g = pictureBox1.CreateGraphics();
            if (a[1] == "istočno")
                x = Convert.ToInt32(a[0]);
            if (a[1] == "zapadno")
                x = -Convert.ToInt32(a[0]);
            if (b[1] == "severno")
                y = -Convert.ToInt32(b[0]);
            if (b[1] == "južno")
                y = Convert.ToInt32(b[0]);
            g.FillEllipse(cetka, pictureBox1.Width / 2 + x - 5, pictureBox1.Height / 2 + y - 5, 10, 10);
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            label6.Visible = true;
            label7.Visible = true;
            label8.Visible = true;
            pictureBox1.Visible = true;
        }

        int x, y;
        string[] a, b;
        
        Pen olovka = new Pen(Color.Blue, 3);
        SolidBrush cetka = new SolidBrush(Color.Red);

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            a = dataGridView1[1, e.RowIndex].Value.ToString().Split(' ');
            b = dataGridView1[2, e.RowIndex].Value.ToString().Split(' ');
        }

        private void Po_tipu_antikviteta_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = pictureBox1.CreateGraphics();
            g.DrawLine(olovka, 0, 0, pictureBox1.Width, 0);
            g.DrawLine(olovka, 0, 0, 0, pictureBox1.Height);
            g.DrawLine(olovka, pictureBox1.Width, 0, pictureBox1.Width, pictureBox1.Height);
            g.DrawLine(olovka, 0, pictureBox1.Height, pictureBox1.Width, pictureBox1.Height);
            g.DrawLine(olovka, pictureBox1.Width / 2, 0, pictureBox1.Width / 2, pictureBox1.Height);
            g.DrawLine(olovka, 0, pictureBox1.Height / 2, pictureBox1.Width, pictureBox1.Height / 2);
        }
    }
}
