using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;
using System.Diagnostics;

namespace WindowsFormsApplication1
{
    public partial class Form3 : Form
    {
        public Form3(Racun r, Korisnik k, Form2 f)
        {
            InitializeComponent();
            this.r = r;
            this.k = k;
            this.f = f;
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            //iscitavanje foldera klijenata
            string[] folderi = Directory.GetDirectories("Klijenti/");
            for (int i = 0; i < folderi.Length; i++)
            {
                string[] ime = new string[2];
                ime = folderi[i].Split('/'); 
                listBox1.Items.Add(ime[1]);
            }
        }

        string[] potrosnje;

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //iscitavanje svakog meseca za svakog klijenta
            DirectoryInfo d = new DirectoryInfo("Klijenti/" + listBox1.GetItemText(listBox1.SelectedItem) + "/");
            FileInfo[] files = d.GetFiles("*.txt");
            Citanje c = new Citanje();
            potrosnje = new string[100];
            for (int i = 0; i < files.Length; i++)
            {
                StreamReader sr = new StreamReader(d.ToString() + files[i].ToString());
                if(files[i].ToString().Substring(0,6)=="Januar")
                {
                    potrosnje[0] = c.Citaj(sr);
                }
                else if (files[i].ToString().Substring(0, 7) == "Februar")
                {
                    potrosnje[1] = c.Citaj(sr);
                }
                else if (files[i].ToString().Substring(0, 4) == "Mart")
                {
                    potrosnje[2] = c.Citaj(sr);
                }
                else if (files[i].ToString().Substring(0, 5) == "April")
                {
                    potrosnje[3] = c.Citaj(sr);
                }
                else if (files[i].ToString().Substring(0, 3) == "Maj")
                {
                    potrosnje[4] = c.Citaj(sr);
                }
                else if (files[i].ToString().Substring(0, 3) == "Jun")
                {
                    potrosnje[5] = c.Citaj(sr);
                }
                else if (files[i].ToString().Substring(0, 3) == "Jul")
                {
                    potrosnje[6] = c.Citaj(sr);
                }
                else if (files[i].ToString().Substring(0, 6) == "Avgust")
                {
                    potrosnje[7] = c.Citaj(sr);
                }
                else if (files[i].ToString().Substring(0, 9) == "Septembar")
                {
                    potrosnje[8] = c.Citaj(sr);
                }
                else if (files[i].ToString().Substring(0, 7) == "Oktobar")
                {
                    potrosnje[9] = c.Citaj(sr);
                }
                else if (files[i].ToString().Substring(0, 8) == "Novembar")
                {
                    potrosnje[10] = c.Citaj(sr);
                }
                else if (files[i].ToString().Substring(0, 8) == "Decembar")
                {
                    potrosnje[11] = c.Citaj(sr);
                }
                sr.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.chart1.Series.Clear();
            this.chart1.Series.Add("Potrosnja");
            this.chart1.Series["Potrosnja"].Points.AddXY("Januar", potrosnje[0]);
            this.chart1.Series["Potrosnja"].Points.AddXY("Februar", potrosnje[1]);
            this.chart1.Series["Potrosnja"].Points.AddXY("Mart", potrosnje[2]);
            this.chart1.Series["Potrosnja"].Points.AddXY("April", potrosnje[3]);
            this.chart1.Series["Potrosnja"].Points.AddXY("Maj", potrosnje[4]);
            this.chart1.Series["Potrosnja"].Points.AddXY("Jun", potrosnje[5]);
            this.chart1.Series["Potrosnja"].Points.AddXY("Jul", potrosnje[6]);
            this.chart1.Series["Potrosnja"].Points.AddXY("Avgust", potrosnje[7]);
            this.chart1.Series["Potrosnja"].Points.AddXY("Septembar", potrosnje[8]);
            this.chart1.Series["Potrosnja"].Points.AddXY("Oktobar", potrosnje[9]);
            this.chart1.Series["Potrosnja"].Points.AddXY("Novembar", potrosnje[10]);
            this.chart1.Series["Potrosnja"].Points.AddXY("Decembar", potrosnje[11]);
        }
    }
}
