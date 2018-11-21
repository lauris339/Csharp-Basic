using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_1_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pasirinkite is meniu:\n" +
                "Iveskite 1 jei norite vandens.\n" +
                "Iveskite 2 jei norite limonado.\n" +
                "Iveskite 3 jei norite arbatos.\n" +
                "Iveskite 4 jei norite kavos.\n");
            var pasirinkimas = Convert.ToInt32(Console.ReadLine());

            switch (pasirinkimas)
            {
                case 1:
                    Console.WriteLine("Tuoj ipilsime vandens");
                    break;

                case 2:
                    Console.WriteLine("Tuoj ipilsime limonado");
                    break;

                case 3:
                    Console.WriteLine("Tuoj ipilsime arbatos");
                    break;

                case 4:
                    Console.WriteLine("Tuoj ipilsime kavos");
                    break;

                default:
                    Console.WriteLine("Tokio pasirinkimo nera!");
                    break;
            }
        }
    }
}
