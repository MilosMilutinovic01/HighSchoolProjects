using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Zadatak_6
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Random random = new Random();
            List<int> lista = new List<int>();
            n = random.Next(5, 15);
            Console.WriteLine("Generisao je {0} elemenata liste:", n);
            for (int i = 0; i < n; i++)
            {
                lista.Add(random.Next(1, 50));
            }
            for (int i = 0; i < n; i++)
            {
                Console.Write("{0,3}", lista[i]);
            }
            Console.ReadKey();
        }
    }
}
