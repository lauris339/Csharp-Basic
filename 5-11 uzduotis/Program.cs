using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_11_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite teigiama skaiciu");
            var a = Convert.ToDouble(Console.ReadLine());

            if (a % 7 == 0)
            {
                Console.WriteLine("Jusu norima reklama");
            }
            else
            {
                Console.WriteLine("Toks skaicius netinka.");
            }
        }
    }
}
