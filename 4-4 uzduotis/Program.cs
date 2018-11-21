using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_4_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            Console.WriteLine("Iveskita pirma skaiciu:");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Iveskite antra skaiciu:");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Siu skaiciu suma yra {0}", a + b);
        }
    }
}
