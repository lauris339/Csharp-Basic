using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_6_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            var skaiciai = new List<int>();
            var random = new Random();
            var b = 10;
            var c = 0;

            Console.WriteLine("Kiek studento pazymiu norite issaugoti?");
            var kiek = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Iveskite pazymius:");
            for (int i = 0; i < kiek; i++)
            {
                skaiciai.Add(Convert.ToInt32(Console.ReadLine()));
            }

            Console.WriteLine("Didziausias pazymys - " + skaiciai.Max());
            Console.WriteLine("Maziausias pazymys - " + skaiciai.Min());
            Console.WriteLine("Pazymiu vidurkis - " + skaiciai.Average());
            Console.WriteLine("Atsitiktinis skaicius is pazymiu - " + skaiciai[random.Next(kiek)]);



            foreach (var a in skaiciai)
            {
                if (a == b)
                {
                    c += 1;
                }
            }

            Console.WriteLine("{0} tiek desimtuku yra gaves studentas.", c);

            b = 4;
            c = 0;

            foreach (var pazimys in skaiciai)
            {
                if (pazimys < b)
                {
                    c += 1;
                }
            }

            Console.WriteLine("{0} tiek neigiemu pazymiu yra gaves studentas.", c);
        }
    }
}
