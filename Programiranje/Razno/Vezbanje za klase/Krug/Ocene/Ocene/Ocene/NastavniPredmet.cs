using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ocene
{
    class NastavniPredmet
    {
        private string naziv;
        private int ocena;
        public string Naziv
        {
            get { return naziv; }
            set { naziv = value; }
        }
        public int Ocena
        {
            get { return ocena; }
            set { ocena = value; }
        }
        public NastavniPredmet() { }
        public NastavniPredmet(string naziv, int ocena)
        {
            this.naziv = naziv;
            this.ocena = ocena;
        }
        public string OpisnaOcena(int x)
        { 
            switch(x)
            {
            case 1:
                    return "nedovoljan";
            case 2:
                    return "dovoljan";
            case 3:
                    return "dobar";
            case 4:
                    return "vrlo dobar";
            case 5:
                    return "odlican";
            default:
                    return "kurac";
            }
        }
        public void Prikazi()
        {
            Console.Write("{0}: {1}({2})", naziv, OpisnaOcena(ocena), ocena);
        }
    }
}
