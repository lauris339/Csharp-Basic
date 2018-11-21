using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_10_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c;
            Console.WriteLine("Iveskite tris skaicius:");
            a = Convert.ToDouble(Console.ReadLine());
            b = Convert.ToDouble(Console.ReadLine());
            c = Convert.ToDouble(Console.ReadLine());
            double vidurkis = (a + b + c) / 3;
            Console.WriteLine("Ivestu skaiciu {0}, {1}, {2} vidurkis yra {3}.", a, b, c, vidurkis);
        }
    }
}
