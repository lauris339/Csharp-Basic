using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_2_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            var pirmas = 1;
            var antras = 2;
            var trecias = 3;
            var suma = pirmas + antras + trecias;
            var sandauga = pirmas * antras * trecias;

            Console.WriteLine("Skaiciu suma: " + suma + "\nSandauga: " + sandauga);
        }
    }
}
