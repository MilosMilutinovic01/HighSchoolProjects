using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Zadatak_5
{
    class Program
    {
        struct Auto
        {
            public string tip;
            public string boja;
            public float potrosnja;
        }
        static void Main(string[] args)
        {
            Auto auto1, auto2;
            Console.WriteLine("Unesi marku prvog auta:");
            auto1.tip = Console.ReadLine();
            Console.WriteLine("Unesi boju prvog auta:");
            auto1.boja = Console.ReadLine();
            Console.WriteLine("Unesi potrosnju prvog auta:");
            auto1.potrosnja = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Unesi marku drugog auta:");
            auto2.tip = Console.ReadLine();
            Console.WriteLine("Unesi boju drugog auta:");
            auto2.boja = Console.ReadLine();
            Console.WriteLine("Unesi potrosnju drugog auta:");
            auto2.potrosnja = Convert.ToSingle(Console.ReadLine());
            if (auto1.potrosnja < auto2.potrosnja)
                Console.WriteLine("Drugi auto ima vecu potrosnju");
            else if (auto1.potrosnja > auto2.potrosnja)
                Console.WriteLine("Prvi auto ima vecu potrosnju");
            else
                Console.WriteLine("Oba auta imaju istu potrosnju");
            Console.ReadKey();
        }
    }
}
