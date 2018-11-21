using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_1_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite tris skaicius:");

            double a = Convert.ToDouble(Console.ReadLine());
            double b = Convert.ToDouble(Console.ReadLine());
            double c = Convert.ToDouble(Console.ReadLine());

            if (a == b)
            {
                Console.WriteLine("a = b");
            }

            if (b == c)
            {
                Console.WriteLine("b = c");
            }

            if (a > b)
            {
                Console.WriteLine("a > b");
            }

            if (b > (c * 2))
            {
                Console.WriteLine("b > c * 2");
            }

            if (a % 2 == 0)
            {
                Console.WriteLine("a yra lyginis");
            }

            if (b % 2 != 0)
            {
                Console.WriteLine("b yra nelyginis");
            }

            if (c > 0)
            {
                Console.WriteLine("c yra teigiamas");
            }

            if (b % 4 == 0)
            {
                Console.WriteLine("b dalinasi is 4");
            }

            if (c % 8 == 0)
            {
                Console.WriteLine("c dalinasi is 8");
            }
        }
    }
}
