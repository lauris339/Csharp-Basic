using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_5_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite bet koki teigiama skaiciu:");
            var a = Convert.ToDouble(Console.ReadLine());

            if (a < 0)
            {
                Console.WriteLine("Labai juokinga, {0} tasku tau!", a);
            }

            if (a >= 0)
            {
                Console.WriteLine("Valio,gaunate +{0} tasku!!!", a);
            }

            if (a % 2 == 0)
            {
                Console.WriteLine("skaicius lyginis");
            }

            if (a % 4 == 0)
            {
                Console.WriteLine("Skaicius dalinasi is 4");
            }

            if (a > 10)
            {
                Console.WriteLine("skaicius didesnis negu 10");
            }
        }
    }
}
