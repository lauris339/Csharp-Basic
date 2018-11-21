using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_10_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite skaiciu:");
            var a = Convert.ToDouble(Console.ReadLine());

            if (a % 2 == 0)
            {
                Console.WriteLine("Skaicius lyginis");
            }
            else
            {
                Console.WriteLine("Skaicius nelyginis");
            }
        }
    }
}
