using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_9_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            var skaiciai = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9};
            var skaiciai1 = new[] {9, 8, 7, 6, 5, 4, 3, 2, 1};

            var sum = 0;
            var sum1 = 0;

            foreach (var a in skaiciai)
            {
                sum += a;
            }

            foreach (var b in skaiciai1)
            {
                sum1 += b;
            }

            Console.WriteLine(sum);
            Console.WriteLine(sum1);

            if (sum > sum1)
            {
                Console.WriteLine("Pirmo ciklo suma didesne.");
            }
            else if (sum < sum1)
            {
                Console.WriteLine("Antro ciklo suma didesne.");
            }
            else
            {
                Console.WriteLine("Sumos lygios.");
            }
        }
    }
}
