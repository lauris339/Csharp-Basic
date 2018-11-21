using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_1_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            var random = new Random();
            var skaiciai = new List<int>();

            for (int i = 0; i < 20; i++)
            {
                var skaicius = random.Next(1, 50);
                skaiciai.Add(skaicius);
            }

            Console.WriteLine("Maziausias skaicius yra " + skaiciai.Min());
        }
    }
}
