using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ocene
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            NastavniPredmet a = new NastavniPredmet();
            Console.WriteLine("Koliko predmeta unosis");
            x = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < x; i++)
            {
                a.Naziv = Convert.ToString(Console.ReadLine());
                a.Ocena = Convert.ToInt32(Console.ReadLine());
                a.Prikazi();
            }
            Console.ReadKey();
        }
    }
}
