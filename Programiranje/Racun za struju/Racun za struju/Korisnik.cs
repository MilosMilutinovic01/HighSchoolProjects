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
    public class Korisnik
    {
        private string ime, prezime, broj;
        public string Ime
        {
            get { return ime; }
            set { ime = value; }
        }
        public string Prezime
        {
            get { return prezime; }
            set { prezime = value; }
        }
        public string Broj
        {
            get { return broj; }
            set { broj = value; }
        }
        public Korisnik()
        {
            ime = "";
            prezime = "";
            broj = "";
        }
        public Korisnik(string ime, string prezime, string broj)
        {
            this.ime = ime;
            this.prezime = prezime;
            this.broj = broj;
        }
        public void Pisi(StreamWriter sw)
        {
            sw.WriteLine(ime);
            sw.WriteLine(prezime);
            sw.WriteLine(broj);
        }
        public void Citaj(StreamReader sr)
        {
            ime = sr.ReadLine();
            prezime = sr.ReadLine();
            broj =sr.ReadLine();
        }
    }
}
