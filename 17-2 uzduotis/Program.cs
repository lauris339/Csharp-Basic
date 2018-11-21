using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_2_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            var p = new Program();
            p.Informacija();
        }

        public void Informacija()
        {
            var vardas = "Vyriausias";
            var pavarde = "Alfa";
            int amzius = 24;
            int alga = 300000;
            int etatas = 1;
            string specializacija = "policininkas";
            Console.WriteLine(vardas + " " + pavarde + " " + amzius + "m. uzdirba " +
                alga + "Eur dirba " + etatas + " ir jo specializacija yra " + specializacija);
        }

    }
}
