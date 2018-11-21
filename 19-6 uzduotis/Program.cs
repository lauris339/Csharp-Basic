using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_6_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            var p = new Program();
            var skaiciai = new int[] { 1, 2, 3, 4, 5 };
            Console.WriteLine(p.Skaicius(skaiciai));
        }
        public int Skaicius(int[] numbers)
        {
            var a = 0;
            a = numbers.Max();
            return a;
        }
    }
}
