using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Krug
{
    class Krug
    {
        private double r;
        public double R
        {
            get { return r; }
            set 
            {
                if (value > 0)
                    r = value;
                else
                    r = 0;
            }
        }
        public Krug() { }
        public Krug(double r) 
        {
            this.r = r;
        }
        public double Obim()
        {
            return 2 * Math.PI * r;
        }
        public void Povrsina()
        {
            Console.WriteLine("povrsina je {0}", r * r * Math.PI);
        }
        public double Izmeni(double x)
        {
            r = r + x;
            return r;
        }
    }
}
