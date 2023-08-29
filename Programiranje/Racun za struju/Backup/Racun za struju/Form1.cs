using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //podesavanje formata na mesec i godinu pri cemu poslednji mesec koji moze da se izabere jeste prethodni mesec od trenutnog
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "MMMM yyyy";
            dateTimePicker1.MaxDate = Convert.ToDateTime(DateTime.Now.AddMonths(-1).ToString("MMMM yyyy"));
            textBox5.Text = Convert.ToString(a);
        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            //podesavanje brojila
            if (comboBox1.SelectedIndex == 0)
            {
                label5.Text = "Potrošeno kWh:";
                label6.Visible = false;
                textBox3.Visible = false;
            }
            else
            {
                label5.Text = "Viša tarifa(utrošeno kWh):";
                label6.Visible = true;
                textBox3.Visible = true;
            }
        }

        private void comboBox2_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            //podesavanje snaga
            object[] ms = new object[] { 2.30, 3.68, 4.60, 5.75, 7.36 };
            object[] ts = new object[] { 6.90, 11.04, 13.80, 17.25, 22.08, 24.15, 27.60, 34.50, 43.47 };
            if (comboBox2.SelectedIndex == 0)
            {
                comboBox3.Items.Clear();
                comboBox3.Items.AddRange(ms);
                comboBox3.Text = "2.30";
            }
            else
            {
                comboBox3.Items.Clear();
                comboBox3.Items.AddRange(ts);
                comboBox3.Text = "6.90";
            }
        }
        
        public int a = 333;

        private void button1_Click_1(object sender, EventArgs e)
        {
            Racun r = new Racun();
            Korisnik k = new Korisnik();
            k.Ime = textBox1.Text;
            k.Prezime = textBox4.Text;
            k.Broj = Convert.ToString(a);
            r.Period = dateTimePicker1.Value.Month;
            r.Snaga = Convert.ToDouble(comboBox3.SelectedItem);
            r.Brojilo = comboBox1.SelectedIndex;
            if (comboBox1.SelectedIndex == 0)
            {
                r.Visa = Convert.ToInt32(textBox2.Text);
                r.Niza = 0;
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                r.Visa = Convert.ToInt32(textBox2.Text);
                r.Niza = Convert.ToInt32(textBox3.Text);
            }
            //kreiranje foldera sa imenom klijenata u folderu Klijenti
            string naziv = "Klijenti/" + k.Ime + " " + k.Prezime;
            DirectoryInfo di = Directory.CreateDirectory(naziv);
            StreamWriter sw = new StreamWriter(naziv + "/" + r.Mesec(r.Period) + ".txt");
            k.Pisi(sw);
            sw.Close();
            a++;
            Form2 f2 = new Form2(r, k, this);
            f2.ShowDialog();
        }
    }
}
