using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_8_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            var a = 1;
            var b = 0;
            var c = 0;

            while (a <= 100)
            {
                b = random.Next(100);
                Console.Write(b + ",");
                c += b;
                a++;
            }

            var d = c / 100;
            Console.WriteLine("");
            Console.WriteLine("Suma: " + c);
            Console.WriteLine("Vidurkis: " + d);
        }
    }
}
