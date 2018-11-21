using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_3_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            var temperaturos = new[] {12, 13.5, 15, 17.6, 20.1, 21, 23, 24, 15, 14.3, 10.2, 8 };
            double suma = 0;
            double vidurkis = 0;
            double maziausias = temperaturos[0], didziausias = temperaturos[11];


            foreach (var a in temperaturos)
            {
                suma += a;
            }

            vidurkis = suma / 12;

            Console.WriteLine("Visu menesiu temperaturu suma = " + suma);
            Console.WriteLine("O ju vidurkis = " + vidurkis);

            for (int i = 0; i < 12; i++)
            {
                if (temperaturos[i] > didziausias)
                {
                    didziausias = temperaturos[i];
                }
            }

            Console.WriteLine("Didziausias = " + didziausias);

            for (int i = 0; i < 12; i++)
            {
                if (temperaturos[i] < maziausias)
                {
                    maziausias = temperaturos[i];
                }
            }

            Console.WriteLine("Maziausias = " + maziausias);
        }
    }
}
