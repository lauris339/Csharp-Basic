using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_1_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            var skaicius = 5;
            Console.WriteLine("Skaicius = " + skaicius + "\nJo kvadratas: "
                + Math.Pow(skaicius, 2) + "\nPakeltas treciu " +
                "laipsniu: " + Math.Pow(skaicius, 3));
        }
    }
}
