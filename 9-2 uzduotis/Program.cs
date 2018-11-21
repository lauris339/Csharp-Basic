using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_2_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 1;

            while (a <= 50)
            {
                if (a % 2 == 0)
                {
                    Console.WriteLine(a + " lyginis");
                }
                else if (a % 2 != 0)
                {
                    Console.WriteLine(a + " nelyginis");
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
