using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_7_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite du skaicius:");
            var a = Convert.ToDouble(Console.ReadLine());
            var b = Convert.ToDouble(Console.ReadLine());

            if (a > b || a > 0)
            {
                Console.WriteLine("a > b || a > 0");
            }
            else if (b > a || b == 5)
            {
                Console.WriteLine("b > a || b == 5");
            }
            else if (a > b &&  a == 20)
            {
                Console.WriteLine("a > b &&  a == 20");
            }
            else if (b > a && b > 100)
            {
                Console.WriteLine("b > a && b > 100");
            }
        }
    }
}
