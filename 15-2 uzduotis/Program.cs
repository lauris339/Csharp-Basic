using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_2_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            var skaiciai = new int[2, 10]
            {
                {1, 2, 3, 4, 5, 6, 7, 8, 9, 11 },
                {1, 2, 3, 4, 5, 6, 7, 8, 9, 12 }
            };
            var suma = 0;
            var suma1 = 0;

            for (int i = 0; i < 10; i++)
            {
                suma += skaiciai[0, i];
            }

            Console.WriteLine(suma);

            for (int a = 0; a < 10; a++)
            {
                suma1 += skaiciai[1, a];
            }

            Console.WriteLine(suma1);


        }
    }
}
