using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_6_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite triju egzaminu rezultatus:");
            var a = Convert.ToDouble(Console.ReadLine());
            var b = Convert.ToDouble(Console.ReadLine());
            var c = Convert.ToDouble(Console.ReadLine());
            double vidurkis = (a + b + c) / 3;

            if (vidurkis >= 8 && vidurkis <= 10)
            {
                Console.WriteLine("[8-10]");
            }
            else if (vidurkis >= 5 && vidurkis > 8)
            {
                Console.WriteLine("[5-8)");
            }
            else if (vidurkis < 5)
            {
                Console.WriteLine("< 5");
            }
        }
    }
}
