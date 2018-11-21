using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_3_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite tris skaicius:");
            var a = Convert.ToDouble(Console.ReadLine());
            var b = Convert.ToDouble(Console.ReadLine());
            var c = Convert.ToDouble(Console.ReadLine());

            switch (a)
            {
                case 1:
                    Console.WriteLine(a + b + c);
                    break;
                case 2:
                    Console.WriteLine(b * c);
                    break;
                case 3:
                    Console.WriteLine(a * a);
                    break;

                default:
                    Console.WriteLine("ERROR");
                    break;
            }
        }
    }
}
