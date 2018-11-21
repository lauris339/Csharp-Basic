using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_17_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pirmo automobilio marke:");
            string marke1 = Console.ReadLine();
            Console.WriteLine("Pirmo automobilio modelis:");
            string modelis1 = Console.ReadLine();
            Console.WriteLine("Pirmo automobilio gamybos metai:");
            int gamybos_metai1 =Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Pirmo automobilio darbinis turis:");
            double darbinis_turis1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Pirmo automobilio rida:");
            int rida1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Pirmo automobilio TA (true/false):");
            bool ta1 = Convert.ToBoolean(Console.ReadLine());
            //kitas automobilis
            Console.WriteLine("Antro automobilio marke:");
            string marke2 = Console.ReadLine();
            Console.WriteLine("Antro automobilio modelis:");
            string modelis2= Console.ReadLine();
            Console.WriteLine("Antro automobilio gamybos metai:");
            int gamybos_metai2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Antro automobilio darbinis turis:");
            double darbinis_turis2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Antro automobilio rida:");
            int rida2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Antro automobilio TA (true/false):");
            bool ta2 = Convert.ToBoolean(Console.ReadLine());
            // duombaze
            var marke = "Marke";
            var modelis = "Modelis";
            var gamybos_metai = "Gamybos metai";
            var darbinis_turis = "Darb. turis";
            var rida = "Rida";
            var ta = "Technine apz.";
            Console.WriteLine("| {0,7} | {1,7} | {2,13} | {3,13} | {4,7} | {5,13} |", marke, modelis, gamybos_metai, darbinis_turis, rida, ta);
            Console.WriteLine("| {0,7} | {1,7} | {2,13} | {3,13} | {4,7} | {5,13} |", marke1, modelis1, gamybos_metai1, darbinis_turis1, rida1, ta1);
            Console.WriteLine("| {0,7} | {1,7} | {2,13} | {3,13} | {4,7} | {5,13} |", marke2, modelis2, gamybos_metai2, darbinis_turis2, rida2, ta2);
        }
    }
}
