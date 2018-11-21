using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_6_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            var p = new Program();
            p.Masyvas();
            Console.WriteLine();
        }
        public void Masyvas()
        {
            var skaiciai = new int[] {1, 2, 3, 4, 5, 6, 7, 8, 9 };
            foreach (var a in skaiciai)
            {
                Console.Write(a + " ");
            }
        }
    }
}
