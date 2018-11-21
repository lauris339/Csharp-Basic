using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_5_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Random a = new Random();
            var b = 0;

            do
            {
                b = a.Next(1, 100);
                Console.WriteLine(b);
            } while (b % 3 != 0);
        }
    }
}
