using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_8_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            var p = new Program();
            var skaiciai = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            p.Isvedimas(skaiciai);
        }
        public void Isvedimas(List<int> numbers)
        {
            Console.WriteLine("Maziausias skaicius sarase yra {0}.", numbers.Min());
        }
    }
}
