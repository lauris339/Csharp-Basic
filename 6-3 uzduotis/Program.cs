using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_3_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite skaiciu:");
            var a = Convert.ToDouble(Console.ReadLine());

            if (a % 2 == 0 || a % 5 == 0 || a % 7 == 0 )
            {
                Console.WriteLine("a % 2 == 0 || a % 5 == 0 || a % 7 == 0");
            }
        }
    }
}
