using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_9_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = 1;
            var b = 1; ;

            while (a <= 10)
            {
                b *= a;
                a++;
            }

            Console.WriteLine("Sandauga: " + b);
        }
    }
}
