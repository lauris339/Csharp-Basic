using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_6_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite skaiciu:");
            var a = Convert.ToDouble(Console.ReadLine());

            if (a % 2 == 0)
            {
                Console.WriteLine("a = {0}, a^5 = {1}", a, Math.Pow(a, 5));
            }

            if (a % 4 != 0)
            {
                Console.WriteLine("Iveskite antra skaiciu:");
                var b = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("a + b = {0}, a * b = {1}", a + b, a * b);
            }
        }
    }
}
