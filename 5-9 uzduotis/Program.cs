using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_9_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite teigiama skaiciu:");
            var a = Convert.ToDouble(Console.ReadLine());

            if (a >= 0)
            {
                Console.WriteLine("Good job!");
            }
            else
            {
                Console.WriteLine("Bad dog!!!");
            }
        }
    }
}
