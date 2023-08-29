using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Zadatak_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, temp;
            Console.Write("Unesi dimenziju niza:");
            n = Convert.ToInt32(Console.ReadLine());
            int[] niz = new int[n];
            for (int i = 0; i < niz.Length; i++)
            {
                niz[i] = Convert.ToInt32(Console.ReadLine());
            }
            List<int> lista = new List<int>(niz);
            for (int i = 0; i < lista.Count; i++)
            {
                Console.Write("{0,5}", lista[i]);
            }
            lista.Sort();
            Console.WriteLine();
            Console.WriteLine("Sortirana lista");
            for (int i = 0; i < lista.Count; i++)
            {
                Console.Write("{0,5}", lista[i]);
            }
            temp = lista[0];
            lista[0] = lista[lista.Count - 1];
            lista[lista.Count - 1] = temp;
            Console.WriteLine();
            Console.WriteLine("Nakon zamene min i max clanova lista izgleda ovako:");
            for (int i = 0; i < lista.Count; i++)
            {
                Console.Write("{0,5}", lista[i]);
            }
            Console.ReadKey();
        }
    }
}
