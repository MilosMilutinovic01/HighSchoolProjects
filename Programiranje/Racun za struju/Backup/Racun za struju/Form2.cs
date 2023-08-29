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
    public partial class Form2 : Form
    {
        //obavezan konstruktor pri cemu se r,k i f moraju definisati u form2.designer.cs
        public Form2(Racun r, Korisnik k, Form1 f)
        {
            InitializeComponent();
            this.r = r;
            this.k = k;
            this.f = f;
        }

        public Form2() { }

        double a;
        public double c = 0;

        private void Form2_Load(object sender, EventArgs e)
        {
            if (r.Brojilo == 1)
            {
                a = Convert.ToDouble(f.textBox2.Text) / Convert.ToDouble(f.textBox3.Text);

                if (r.Zona(r.Ukupno()) == "zelena")
                {
                    label16.Text = f.textBox2.Text;
                    label19.Text = f.textBox3.Text;
                    label18.Text = Convert.ToString(r.Visa * 5.962);
                    label21.Text = Convert.ToString(r.Niza * 1.491);
                    c = r.Visa * 5.962 + r.Niza * 1.491;
                }
                if (r.Zona(r.Ukupno()) == "plava")
                {
                    label19.Text = Convert.ToString(Math.Round(350 / (a + 1))); ;
                    label16.Text = Convert.ToString(Math.Round(350 - 350 / (a + 1)));
                    label18.Text = Convert.ToString(Math.Round(350 - 350 / (a + 1)) * 5.962);
                    label21.Text = Convert.ToString(Math.Round(350 / (a + 1)) * 1.491);
                    label23.Text = Convert.ToString(Math.Round((r.Ukupno() - 350) / (a + 1)));
                    label22.Text = Convert.ToString(Math.Round(r.Ukupno() - 350 - (r.Ukupno() - 350) / (a + 1)));
                    label26.Text = Convert.ToString(Math.Round(r.Ukupno() - 350 - (r.Ukupno() - 350) / (a + 1)) * 8.943);
                    label27.Text = Convert.ToString(Math.Round((r.Ukupno() - 350) / (a + 1)) * 1.900);
                    c = Convert.ToDouble(label26.Text) + Convert.ToDouble(label27.Text) + Convert.ToDouble(label21.Text) + Convert.ToDouble(label18.Text);
                }
                if (r.Zona(r.Ukupno()) == "crvena")
                {
                    label19.Text = Convert.ToString(Math.Round(350 / (a + 1))); ;
                    label16.Text = Convert.ToString(Math.Round(350 - 350 / (a + 1)));
                    label18.Text = Convert.ToString(Math.Round(350 - 350 / (a + 1)) * 5.962);
                    label21.Text = Convert.ToString(Math.Round(350 / (a + 1)) * 1.491);
                    label23.Text = Convert.ToString(Math.Round(1250 / (a + 1)));
                    label22.Text = Convert.ToString(Math.Round(1250 - 1250 / (a + 1)));
                    label26.Text = Convert.ToString(Math.Round(1250 / (a + 1)) * 8.943);
                    label27.Text = Convert.ToString(Math.Round(1250 - 1250 / (a + 1)) * 1.900);
                    label29.Text = Convert.ToString(Math.Round((r.Ukupno() - 1600) / (a + 1)));
                    label28.Text = Convert.ToString(Math.Round(r.Ukupno() - 1600 - (r.Ukupno() - 1600) / (a + 1)));
                    label32.Text = Convert.ToString(Math.Round(r.Ukupno() - 1600 - (r.Ukupno() - 1600) / (a + 1)) * 15.204);
                    label33.Text = Convert.ToString(Math.Round((r.Ukupno() - 1600) / (a + 1)) * 3.801);
                    c = Convert.ToDouble(label26.Text) + Convert.ToDouble(label27.Text) + Convert.ToDouble(label21.Text) + Convert.ToDouble(label18.Text) + Convert.ToDouble(label33.Text) + Convert.ToDouble(label32.Text);
                }
            }
            if (r.Brojilo == 0)
            {
                label19.Text = "0";
                label21.Text = "0";
                label23.Text = "0";
                label27.Text = "0";
                label29.Text = "0";
                label33.Text = "0";

                if (r.Zona(r.Ukupno()) == "zelena")
                {
                    label16.Text = f.textBox2.Text;
                    label18.Text = Convert.ToString(r.Visa * 5.962);
                    c = Convert.ToDouble(label18.Text);
                }
                if (r.Zona(r.Ukupno()) == "plava")
                {
                    label16.Text = "350";
                    label18.Text = Convert.ToString(350 * 5.962);
                    label22.Text = Convert.ToString(Convert.ToInt32(f.textBox2.Text) - 350);
                    label26.Text = Convert.ToString((Convert.ToInt32(f.textBox2.Text) - 350) * 8.943);
                    c = Convert.ToDouble(label18.Text) + Convert.ToDouble(label26.Text);
                }
                if (r.Zona(r.Ukupno()) == "crvena")
                {
                    label16.Text = "350";
                    label18.Text = Convert.ToString(350 * 5.962);
                    label22.Text = "1250";
                    label26.Text = Convert.ToString(1250 * 8.943);
                    label28.Text = Convert.ToString(r.Ukupno() - 1600);
                    label32.Text = Convert.ToString((r.Ukupno() - 1600) * 15.204);
                    c = Convert.ToDouble(label18.Text) + Convert.ToDouble(label26.Text) + Convert.ToDouble(label32.Text);
                }
            }
            label34.Text = "Korisnik " + k.Ime + " " + k.Prezime + " ukupno treba da plati " + Math.Round((c + r.Snaga * 45.883), 2).ToString("0.00")+".din";
            string naziv = "Klijenti/" + k.Ime + " " + k.Prezime;
            StreamWriter sw = new StreamWriter(naziv + "/" + r.Mesec(r.Period) + ".txt", true);
            r.Pisi(sw, r.Ukupno());
            sw.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            f.textBox1.Text = "";
            f.textBox2.Text = "";
            f.textBox3.Text = "";
            f.textBox4.Text = "";
            f.textBox5.Text = f.a.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //kreiranje forme pri cemu se konstruktorom prenose vrednosti r,k i this
            Form3 f3 = new Form3(r, k, this);
            f3.ShowDialog();
        }
    }
}
