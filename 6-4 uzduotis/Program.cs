using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_4_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite tris skaicius:");
            var a = Convert.ToDouble(Console.ReadLine());
            var b = Convert.ToDouble(Console.ReadLine());
            var c = Convert.ToDouble(Console.ReadLine());

            if (a > b && a > c)
            {
                Console.WriteLine("a didziausias");
            }
            else if (b > a && b > c)
            {
                Console.WriteLine("b didziausias");
            }
            else
            {
                Console.WriteLine("c didziausias");
            }
        }
    }
}
