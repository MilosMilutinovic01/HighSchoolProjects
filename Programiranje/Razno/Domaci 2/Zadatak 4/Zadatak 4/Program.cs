using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Zadatak_4
{
    class Program
    {
        enum svetlo
        {
            crveno = 1,
            zuto = 2,
            zeleno = 3,
            trepcuce = 4,
        };
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Unesi broj:");
            n = Convert.ToInt32(Console.ReadLine());
            switch (n)
            {
                case 1: Console.WriteLine("Svetlo je {0}", svetlo.crveno); break;
                case 2: Console.WriteLine("Svetlo je {0}", svetlo.zuto); break;
                case 3: Console.WriteLine("Svetlo je {0}", svetlo.zeleno); break;
                case 4: Console.WriteLine("Svetlo je {0}", svetlo.trepcuce); break;
                default: Console.WriteLine("Uneli ste pogresnu vrednost"); break;
            }

            Console.ReadKey();

        }
    }
}
