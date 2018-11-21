using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_13_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 1;
            int b = 1;
            int c = 0;
            Console.WriteLine("Iveskite kiek norite pamatyti fibonaciaus skaiciu:");
            var d = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(a);
            Console.WriteLine(b);
            

            for (int i = 2; i <= d; i++)
            {
                c = a + b;
                Console.WriteLine(c);
                a = b;
                b = c;
            }
        }
    }
}
