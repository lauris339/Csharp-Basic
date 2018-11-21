using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_2_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite savo turima role:");
            var pasirinkimas = Console.ReadLine();

            switch (pasirinkimas)
            {
                case "vartotojas":
                    Console.WriteLine("Gal noretum tapt moderatorium?");
                    break;
                case "moderatorius":
                    Console.WriteLine("Gal noretum tapt administratorium?");
                    break;
                case "administratorius":
                    Console.WriteLine("Gal noretum tapt programuotoju?");
                    break;

                default:
                    Console.WriteLine("Blogai ivedete role arba tokios roles nera.");
                    break;
            }
        }
    }
}
