using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_9_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            var p = new Program();
            p.Isvedimas();

        }
        public void Masyvas()
        {
            var zodziai = new string[] {"bmw", "audi", "peugeot", "subaru" };
            var random = new Random();
            Console.WriteLine(zodziai[random.Next(3)]);
        }
        public void Atsitiktinis()
        {
            var a = new Random();
            Console.WriteLine(a.Next(100));
        }
        public void Isvedimas()
        {
            Masyvas();
            Atsitiktinis();
        }
    }
}
