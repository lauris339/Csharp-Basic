using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_6_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            var a = 1;
            var b = 0;
            var c = 0;

            while (a <= 10)
            {
                b = random.Next(10);
                Console.WriteLine(b);
                c += b;
                a++;
            }

            Console.WriteLine("Suma: " + c);
        }
    }
}
