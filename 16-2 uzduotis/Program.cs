using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_2_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            var vardai = new List<string>() { "bmw" };
            vardai.Add("audi");
            vardai.Add("peugeot");
            vardai.Add("mercedes");
            vardai.Add("subaru");

            Console.WriteLine("Pirmas sarase " + vardai.First());
            Console.WriteLine("Antras sarase " + vardai[1]);

        }
    }
}
