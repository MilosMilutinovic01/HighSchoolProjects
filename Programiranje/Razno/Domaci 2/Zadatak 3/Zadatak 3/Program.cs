using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;

namespace Zadatak_3
{
    class Program
    {
        static void unos(int[,] a)
        {
            Console.WriteLine("Unesi elemente niza:");
            for (int i = 0; i < a.GetLength(0); i++)
                for (int j = 0; j < a.GetLength(0); j++)
                {
                    a[i, j] = Convert.ToInt32(Console.ReadLine());
                }
        }
        static void zamena(int[,] a)
        {
            for (int i = 0; i < a.GetLength(0); i++)
                for (int j = 0; i < a.GetLength(1); j++)
                {
                    if ((i == j) || (i + j == a.GetLength(0) - 1))
                        a[i, j] = 0;
                }
        }
        static void ispisN(int[,] a)
        {
            foreach (int x in a)
            {
                Console.Write("{0}\t", x);
            }
        }
        static void ispisA(ArrayList b)
        {
            foreach (int x in b)
            {
                Console.Write("{0}\t", x);
            }
        }
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Unesi dimenziju kvadratne matrice:");
            n = Convert.ToInt32(Console.ReadLine());
            int[,] a = new int[n, n];
            unos(a);
            zamena(a);
            ispisN(a);
            ArrayList b = new ArrayList(a);
            ispisA(b);
        }
    }
}
