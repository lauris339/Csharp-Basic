using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_5_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 1;
            int b = 0;
            int c = 0;

            while (a <= 100)
            {
                if (a % 2 == 0)
                {
                    b += a;
                }
                else if (a % 2 != 0)
                {
                    c += a;
                }
                a++;
            }

            Console.WriteLine("Lyginiu suma = " + b);
            Console.WriteLine("Nelyginiu suma = " + c);
        }
    }
}
