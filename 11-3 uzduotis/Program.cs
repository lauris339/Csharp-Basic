using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_3_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            bool testi = true;
            while (testi)
            {
                Console.WriteLine("Iveskite pirmaji skaiciu: ");
                var a = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Iveskite antraji skaiciu: ");
                var b = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("{0} + {1} = {2}", a ,b ,a + b);
                Console.WriteLine("{0} - {1} = {2}", a, b, a - b);
                Console.WriteLine("{0} * {1} = {2}", a, b, a * b);
                Console.WriteLine("{0} / {1} = {2}", a, b, a / b);

                Console.WriteLine("Ar norite ivesti kitus skaicius?");
                Console.WriteLine("Jei taip iveskite taip, jei ne iveskite ne.");
                var pasirinkimas = Console.ReadLine();

                while (pasirinkimas != "ne" && pasirinkimas != "taip")
                {
                    Console.WriteLine("Ar norite ivesti kitus skaicius?");
                    Console.WriteLine("Jei taip iveskite taip, jei ne iveskite ne.");
                    pasirinkimas = Console.ReadLine();
                }

                switch (pasirinkimas)
                {
                    case "taip":
                        testi = true;
                        break;
                    case "ne":
                        testi = false;
                        break;
                    default:
                        Console.WriteLine("Ivyko klaida.");
                        break;
                }
            }
        }
    }
}
