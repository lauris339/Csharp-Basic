using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_14_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 1;
            int b = 1;
            int c = 0;
            var random = new Random();
            var d = random.Next(1,30);
            var skaiciai = new int[d];
            skaiciai[0] = 1;
            skaiciai[1] = 1;


            for (int i = 2; i < d; i++)
            {
                c = a + b;
                skaiciai[i] = c;
                a = b;
                b = c;
            }

            foreach (var skaicius in skaiciai)
            {
                Console.Write(skaicius + ", ");
            }

            Console.WriteLine();
        }
    }
}
