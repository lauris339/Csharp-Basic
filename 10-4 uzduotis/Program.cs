using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_4_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            var skaicius = 1;
            var suma = 0;
            double vidurkis;
            do
            {
                if (skaicius % 2 != 0)
                {
                    Console.WriteLine(skaicius);
                    suma += skaicius;
                }

                skaicius++;

            } while (skaicius <= 50);

            vidurkis = suma / 25;
            Console.WriteLine("\n");
            Console.WriteLine("Siu skaicius suma yra " + suma + ", o vidurkis lygus " + vidurkis);
        }
    }
}
