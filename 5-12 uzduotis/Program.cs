using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_12_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite du skaicius");
            var a = Convert.ToDouble(Console.ReadLine());
            var b = Convert.ToDouble(Console.ReadLine());

            if (a > b)
            {
                Console.WriteLine("Pirmas skaicius didesnis uz antraji");
            }
            else
            {
                Console.WriteLine("Ivyko klaida.");
            }
        }
    }
}
