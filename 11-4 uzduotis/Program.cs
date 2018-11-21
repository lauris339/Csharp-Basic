using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_4_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            bool testi = true;
            string knyga = "";
            while (testi)
            {
                Console.WriteLine("Iveskite zodi arba noredami baigti exit:");
                string pasirinkimas = Console.ReadLine();
                if (pasirinkimas == "exit")
                {
                    testi = false;
                }
                else
                {
                    knyga += pasirinkimas;
                    knyga += " ";
                }

            }
            Console.WriteLine("\n" + knyga);
        }
    }
}
