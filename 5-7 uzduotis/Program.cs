using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_7_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite tris skaicius:");
            var a = Convert.ToDouble(Console.ReadLine());
            var b = Convert.ToDouble(Console.ReadLine());
            var c = Convert.ToDouble(Console.ReadLine());

            if (a > b)
            {
                Console.WriteLine("a > b");
            }
            else if (c > a)
            {
                Console.WriteLine("c > a");
            }
            else if (a == b)
            {
                Console.WriteLine("a = b");
            }
            else if (b == c)
            {
                Console.WriteLine("b = c");
            }
        }
    }
}
