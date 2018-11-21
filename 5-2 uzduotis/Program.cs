using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_2_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite amziu:");
            var amzius = Convert.ToDouble(Console.ReadLine());

            if (amzius >= 18)
            {
                Console.WriteLine("Jus galite balsuoti!");
            }
            else
            {
                Console.WriteLine("Dar per jaunas :(");
            }
        }
    }
}
