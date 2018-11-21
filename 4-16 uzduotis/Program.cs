using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_16_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite duomenis apie Studenta:\n\nVardas:");
            var vardas = Convert.ToString(Console.ReadLine());
            Console.WriteLine("\nPavarde:");
            var pavarde = Convert.ToString(Console.ReadLine());
            Console.WriteLine("\nGrupes kodas:");
            var grupes_kodas = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("\nAukstosios mokyklos pavadinimas:");
            var pavadinimas = Convert.ToString(Console.ReadLine());
            Console.WriteLine("\nPirmo semestro vidurkis:");
            var p1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("\nAntro semestro vidurkis:");
            var p2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("\nTrecio semestro vidurkis:");
            var p3 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("{0} {1} mokinasi {2}, grupes kodas {3}, pirmu triju semestru vidurkis lygus {4}"
                ,vardas,pavarde, pavadinimas, grupes_kodas, ( p1 + p2 + p3 ) / 3 );
        }
    }
}
