using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_10_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            var p = new Program();
            var zodziai = new List<string> { "asdasdasd", "Asffafsdfmskd", "asfaf", "al,fkmgksm" };
            var zodziai1 = new List<string> { "vienas", "du", "trys", "keturi", "penki", "sesi", "septyni" };
            p.Isvedimas(zodziai);
            p.Isvedimas(zodziai1);
        }
        public void Isvedimas(List<string> words)
        {
            var shortest = words[0];
            foreach (var a in words)
            {
                if (a.Count() < shortest.Count())
                {
                    shortest = a;
                }
                Console.WriteLine(a);
            }
            Console.WriteLine("Trumpiausias zodis sarase yra {0}", shortest);
        }
    }
}
