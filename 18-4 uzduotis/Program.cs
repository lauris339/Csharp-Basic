using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_4_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            var p = new Program();
            var random = new Random();
            p.Isvedimas(random.Next(1, 100), random.Next(1, 100));
        }
        public void Isvedimas(int a, int b)
        {
            if (a > b)
            {
                Console.WriteLine(a + " yra didesnis skaicius uz " + b);
            }
            else if (a < b)
            {
                Console.WriteLine(b + " yra didesnis skaicius uz " + a);
            }
            else
            {
                Console.WriteLine("Skaiciai {0} ir {1} yra lygus.", a, b);
            }
        }
    }
}
