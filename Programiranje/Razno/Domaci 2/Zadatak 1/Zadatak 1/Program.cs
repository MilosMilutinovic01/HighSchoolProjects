using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Zadatak_1
{
    class Program
    {
        static void niz(int n)
        {
            Random r = new Random();
            int m;
            for (int i = 0; i < n; i++)
            {
                m = r.Next(4, 11);
                int[] a = new int[m];
                for (int j = 0; j < m; j++)
                {
                    a[j] = r.Next(0, 7);
                    Console.Write("{0}\t", a[j]);
                }
                Console.Write("\n");
            }
        }
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Unesi broj redova:");
            n = Convert.ToInt32(Console.ReadLine());
            niz(n);
            Console.ReadKey();
        }
    }
}
