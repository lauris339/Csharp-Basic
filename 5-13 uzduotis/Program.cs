using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_13_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite skaiciu:");
            var a = Convert.ToDouble(Console.ReadLine());

            if (a % 2 == 0)
            {
                Console.WriteLine("dalinasi is 2");
            }
            else if (a % 3 == 0)
            {
                Console.WriteLine("dalinasi is 3");
            }
            else if (a % 4 == 0)
            {
                Console.WriteLine("dalinasi is 4");
            }
            else if (a % 5 == 0)
            {
                Console.WriteLine("dalinasi is 5");
            }
            else if (a % 7 == 0)
            {
                Console.WriteLine("dalinasi is 7");
            }
            else
            {
                Console.WriteLine("ERROR 101");
            }
        }
    }
}
