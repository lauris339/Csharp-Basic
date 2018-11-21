using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_13_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            var prekes = new[] {"obuolys", "bmw", "sausi pusryciai", "laimingas bilietas" };
            var kainos = new[] { 0.1, 60000.0, 2.0, 1 };

            for (int i = 0; i < prekes.Length; i++)
            {
                Console.Write("+--------------------");

            }
            Console.WriteLine("+");

            for (int i = 0; i < prekes.Length; i++)
            {
                Console.Write("|{0,20}", prekes[i]);
            }
            Console.WriteLine("|");

            for (int i = 0; i < prekes.Length; i++)
            {
                Console.Write("+--------------------");

            }
            Console.WriteLine("+");

            for (int i = 0; i < prekes.Length; i++)
            {
                Console.Write("|{0, 17}Eur", kainos[i]);
            }
            Console.WriteLine("|");

            for (int i = 0; i < prekes.Length; i++)
            {
                Console.Write("+--------------------");

            }
            Console.WriteLine("+");
        }
    }
}
