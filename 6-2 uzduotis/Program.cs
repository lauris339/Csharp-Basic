using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_2_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite teigiama skaiciu:");
            var a = Convert.ToDouble(Console.ReadLine());

            if (a > 0 && a % 2 == 0)
            {
                Console.WriteLine("a > 0, a / 2");
            }
        }
    }
}
