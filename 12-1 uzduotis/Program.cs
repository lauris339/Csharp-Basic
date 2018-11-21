using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_1_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 1;
            int b = 0;
            while (a < 1000)
            {
                if (a % 3 ==0 || a % 5 == 0)
                {
                    
                    b += a;
                }
                a++;
            }
            Console.WriteLine(b);
        }
    }
}
