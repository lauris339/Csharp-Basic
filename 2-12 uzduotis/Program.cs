using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_12_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            var pavadinimas = "Liutas";
            var amzius = 10000;
            var kailio_spalva = "auksine";
            var svoris = 250;

            Console.WriteLine("Gyvunas - " + pavadinimas + " (" + amzius + " m.) turi "
                + kailio_spalva + " kailio spalva ir sveria " + svoris + "kg.");
        }
    }
}
