using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_7_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            var p = new Program();
            Console.WriteLine("Kiek norite pamatyti atsitiktiniu skaiciu?");
            int pasirinkimas = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Iveskite atsitiktiniu skaiciu reziu pradzia, sis skaicius iena i rezius.");
            int pradzia = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Iveskite atsitiktiniu skaiciu reziu pabaiga, sis skaicius iena i rezius.");
            int pabaiga = Convert.ToInt32(Console.ReadLine());

            p.Numbers(pasirinkimas, pradzia, pabaiga);
        }
        public void Numbers(int kiek, int min, int max)
        {
            var random = new Random();
            for (int i = 0; i < kiek; i++)
            {
                Console.Write(random.Next(min, max) + ",");
            }
            Console.WriteLine();
        }
    }
}
