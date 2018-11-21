using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_9_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            var p = new Program();
            var zodziai = new List<string> { "bmw", "audi", "mercedes" };
            p.Isvedimas(zodziai);
        }
        public void Isvedimas(List<string> words)
        {
            var longest = "";
            foreach (var a in words)
            {
                if (a.Count() > longest.Count())
                {
                    longest = a;
                }
            }
            Console.WriteLine("Longest word in the list is {0}.", longest);
        }
    }
}
