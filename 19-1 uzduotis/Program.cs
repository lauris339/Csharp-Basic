using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_1_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            var p = new Program();
            var random = new Random();
            var a = random.Next(1, 10);
            var b = random.Next(1, 10);
            Console.WriteLine(p.Skaicius(a, b));
        }
        public int Skaicius(int a, int b)
        {
            if (a > b)
            {
                return a;
            }
            return b;
        }
    }
}
