using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_2_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            var p = new Program();
            var zodziai = new List<string> { "vienas", "du", "trys" };
            Console.WriteLine(p.Trumpiausias(zodziai));
        }
        public string Trumpiausias(List<string> words)
        {
            var shortest = words[0];
            foreach (var a in words)
            {
                if (a.Count() < shortest.Count())
                {
                    shortest = a;
                }
            }
            return shortest;
        }
    }
}
