using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_17_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            var miestai = new[] {"Kaunas", "Vilnius", "Klaipeda" };
            var gyventojai = new[] { 295.269, 544.386, 152.818 };

            Console.WriteLine("Mieste {0} gyvena {1} gyventoju.", miestai[0], gyventojai[0]);
            Console.WriteLine("Mieste {0} gyvena {1} gyventoju.", miestai[1], gyventojai[1]);
            Console.WriteLine("Mieste {0} gyvena {1} gyventoju.", miestai[2], gyventojai[2]);
        }
    }
}
