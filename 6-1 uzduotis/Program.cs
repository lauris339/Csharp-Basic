using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_1_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            int pradzia = 0;
            int pabaiga = 100;

            Console.WriteLine("Iveskite skaiciu:");
            var a = Convert.ToDouble(Console.ReadLine());

            if (a >= 0 && a <= 100)
            {
                Console.WriteLine("Skaicius patenka i rezius.");
            }
        }
    }
}
