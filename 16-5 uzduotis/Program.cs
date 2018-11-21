using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_5_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            var vardai = new List<string>();
            Console.WriteLine("Kiek norite issaugoti skaiciu:");
            var kiek = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Iveskite norimus vardus:");
            for (int i = 0; i < kiek; i++)
            {
                vardai.Add(Console.ReadLine());
            }

            Console.WriteLine("Pirmas ivestas vardas buvo - " + vardai.First());
            Console.WriteLine("Paskutinis ivestas vardas buvo - " + vardai.Last());


        }
    }
}
