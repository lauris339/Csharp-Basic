using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_8_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            var skaiciai = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            var suma = 0;

            foreach (var skaicius in skaiciai)
            {
                suma += skaicius;
            }

            var vidurkis = (double) suma / skaiciai.Length;
            Console.WriteLine("Masyvo skaiciu suma = " + suma);
            Console.WriteLine("Masyvo vidurkis = " + vidurkis);
        }
    }
}
