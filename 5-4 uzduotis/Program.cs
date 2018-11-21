using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_4_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite bet koki skaiciu:");
            double a = Convert.ToDouble(Console.ReadLine());

            if (a % 5 == 0)
            {
                Console.WriteLine("{0} * 1 = {1}", a, a * 1);
                Console.WriteLine("{0} * 2 = {1}", a, a * 2);
                Console.WriteLine("{0} * 3 = {1}", a, a * 3);
                Console.WriteLine("{0} * 4 = {1}", a, a * 4);
                Console.WriteLine("{0} * 5 = {1}", a, a * 5);
            }

            if (a % 2 == 0)
            {
                Console.WriteLine("{0} {1} {2}", a, a * a, a / 2);
            }
        }
    }
}
