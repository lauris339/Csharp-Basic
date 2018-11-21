using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_3_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ivesk gyvuno pavadinima:");
            string pavadinimas = Console.ReadLine();
            Console.WriteLine("ivesk seima:");
            string seima = Console.ReadLine();
            Console.WriteLine("ivesk regiona kuriame galima ji sutikti:");
            string regionas = Console.ReadLine();
            Console.WriteLine("Gyvunas " + pavadinimas + " priklauso " + seima + " seimai ir yra " +
                "randamas " + regionas + ".");
        }
    }
}
