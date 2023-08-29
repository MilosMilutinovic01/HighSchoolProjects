using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Krug
{
    class Program
    {
        static void Main(string[] args)
        {
            double x;
            Krug a = new Krug();
            Console.WriteLine("unesi poluprecnik: ");
            a.R = Convert.ToDouble(Console.ReadLine());
            if (a.R > 0)
            {
                Console.WriteLine("Krug poluprecnika {0} ima povrsinu  obim {1:0.00}", a.R, a.Obim());
                Console.WriteLine("Unesi vrednost za koju menjas poluprecnik");
                x = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Krug poluprecnika {0} ima povrsinu  obim {1}", a.Izmeni(x), a.Obim());
                a.Povrsina();
            }
            else
                Console.WriteLine("Poluprecnik mora biti veci od nule");
                Console.ReadKey();
        }
    }
}
