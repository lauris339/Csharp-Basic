using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_4_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 25;

            while (a <= 50)
            {
                if (a % 3 == 0)
                {
                    Console.WriteLine("dalinasi is 3");
                }
                else
                {
                    Console.WriteLine(a);
                }
                a++;
            }
        }
    }
}
