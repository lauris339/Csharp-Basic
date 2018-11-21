using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_3_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            var pirmas = 1;
            var antras = 2;
            var suma = pirmas + antras;
            var skirtumas = pirmas - antras;
            var sandauga = suma * skirtumas;
            var dalmuo = suma / skirtumas;

            Console.WriteLine("Pirmas skaicius yra {0}\n" +
                "Antras skaicius yra {1}\n" +
                "Siu skaiciu suma yra {2}\n" +
                "Skaiciu skirtumas - {3}\n" +
                "Sumos ir skirtumo sandauga yra {4}\n" +
                "Sumos ir skirtumo dalmuo - {5}"
                ,pirmas ,antras ,suma ,skirtumas ,sandauga ,dalmuo);
        }
    }
}
