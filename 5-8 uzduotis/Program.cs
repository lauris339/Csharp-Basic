using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_8_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite egzamino pazymi [0-10]:");
            var a = Convert.ToInt32(Console.ReadLine());

            if (a == 10)
            {
                Console.WriteLine("Puiku!");
            }
            else if (a == 9)
            {
                Console.WriteLine("Labai gerai :)");
            }
            else if (a >= 7)
            {
                Console.WriteLine("Gerai.");
            }
            else if (a >= 5)
            {
                Console.WriteLine("Patenkinamai :/");
            }
            else if (a < 5)
            {
                Console.WriteLine("Egzaminas neislaikytas ;(");
            }
        }
    }
}
