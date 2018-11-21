using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_4_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            var p = new Program();
            var zodziai = new List<string> { "vienas", "du", "trys" };
            var knyga = p.Sujungimas(zodziai);
            Console.WriteLine(knyga);
        }
        public string Sujungimas(List<string> words)
        {
            var sakinys = "";
            foreach (var a in words)
            {
                sakinys += a;
            }
            return sakinys;
        }
    }
}
