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
    public class Racun
    {
        private int brojilo, visa, niza, period;
        private double snaga;
        public int Brojilo
        {
            get { return brojilo; }
            set { brojilo = value; }
        }
        public double Snaga
        {
            get { return snaga; }
            set { snaga = value; }
        }
        public int Visa
        {
            get { return visa; }
            set { visa = value; }
        }
        public int Niza
        {
            get { return niza; }
            set { niza = value; }
        }
        public int Period
        {
            get { return period; }
            set { period = value; }
        }
        public Racun()
        {
            brojilo = 0;
            snaga = 0;
            visa = 0;
            niza = 0;
        }
        public string Mesec(int period)
        {
            if (period == 1) return "Januar";
            else if (period == 2) return "Februar";
            else if (period == 3) return "Mart";
            else if (period == 4) return "April";
            else if (period == 5) return "Maj";
            else if (period == 6) return "Jun";
            else if (period == 7) return "Jul";
            else if (period == 8) return "Avgust";
            else if (period == 9) return "Septembar";
            else if (period == 10) return "Oktobar";
            else if (period == 11) return "Novembar";
            else if (period == 12) return "Decembar";
            return "greska";
        }
        public Racun(int brojilo, int snaga, int visa, int niza)
        {
            this.brojilo = brojilo;
            this.snaga = snaga;
            this.visa = visa;
            this.niza = niza;
        }
        public double Ukupno()
        {
            return visa + niza;
        }
        public void Pisi(StreamWriter sw,double a)
        {
            sw.WriteLine(a.ToString());
        }
        public string Zona(double a)
        {
            if (a <= 350)
                return "zelena";
            else if (a > 350 && a <= 1600)
                return "plava";
            else
                return "crvena";
        }
        public override string ToString()
        {
            return brojilo.ToString() + " " + visa.ToString() + " " + niza.ToString() + " " + period.ToString() + " " + snaga.ToString();
        }
    }
}
