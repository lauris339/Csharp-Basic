using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_7_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = 1;

            while (a % 3 != 0 || a % 5 != 0)
            {
                Console.WriteLine(a);
                a++;
            }
        }
    }
}
