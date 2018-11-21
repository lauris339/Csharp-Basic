using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_7_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            var skaiciai = new List<int>();
            var random = new Random();
            var c = 0;

            for (int i = 0; i < 100; i++)
            {
                skaiciai.Add(random.Next(100));
            }

            foreach (var a in skaiciai)
            {
                Console.Write(a + " ");
                if (a % 2 == 0)
                {
                    c += 1;
                }
            }

            Console.WriteLine("\nLast number - " + skaiciai.Last());
            Console.WriteLine("Random number - " + skaiciai[random.Next(99)]);
            Console.WriteLine("Lowest number - " + skaiciai.Min());
            Console.WriteLine("Largest number - " + skaiciai.Max());
            Console.WriteLine("The sum of the list - " + skaiciai.Sum());
            Console.WriteLine("The average of the list - " + skaiciai.Average());
            Console.WriteLine("Lyginiu skaiciu kiekis sarase - " + c);





        }
    }
}
