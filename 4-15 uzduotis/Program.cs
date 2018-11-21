using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_15_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite duomenis apie darbuotoja:\nVardas:");
            var vardas = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Pavarde:");
            var pavarde = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Gimimo metai:");
            var gim_metai = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Specialybe:");
            var spec = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Etatas nuo [0-1]:");
            var etatas = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Alga:");
            var alga = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("{0} {1} ({2}m.) dirba {3} {4} etatu ir uzdirba {5} eur/men."
                , vardas, pavarde, 2018 - gim_metai, spec, etatas, alga);
        }
    }
}
