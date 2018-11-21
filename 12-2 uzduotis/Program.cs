using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_2_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            uint a = 1;
            uint b = 1;
            uint c = 0;
            uint sum = 0;

            Console.WriteLine(a);
            Console.WriteLine(b);

            while (c < 4000000)
            {
                c = a + b;
                if (c % 2 == 0)
                {
                    sum += c;
                }
                else if (c > 4000000)
                {
                    break;
                }
                Console.WriteLine(c);
                a = b;
                b = c;
            }
            Console.WriteLine("suma " + sum);
        }
    }
}
