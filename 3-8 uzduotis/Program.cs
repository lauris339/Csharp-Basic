using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_8_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            int sk = 38;
            int a = sk / 10;
            int b = sk % 10;

            Console.WriteLine("{0} --> {1} + {2} = {3}", sk, a, b, a + b);
        }
    }
}
