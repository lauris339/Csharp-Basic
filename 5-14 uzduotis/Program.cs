using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_14_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite du skaicius:");
            var a = Convert.ToDouble(Console.ReadLine());
            var b = Convert.ToDouble(Console.ReadLine());

            if (a > b)
            {
                Console.WriteLine("a > b");
            }
            else if (b > a)
            {
                Console.WriteLine("b > a");
            }
            else
            {
                Console.WriteLine("Skaiciai yra lygus");
            }
        }
    }
}
