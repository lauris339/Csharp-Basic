using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_5_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            var p = new Program();
            var random = new Random();
            //var a = random.Next(1, 30);
            //var b = random.Next(1, 30);
            //var c = random.Next(1, 30);
            var a = 1;
            var b = 2;
            var c = 3;
            Console.WriteLine(p.Random(a, b, c));
        }
        public int Random(int a, int b, int c)
        {
            int pasirinkimas = 0;
            var random = new Random(); 
            switch (random.Next(1, 3))
            {
                case 1:
                    pasirinkimas = a;
                    break;
                case 2:
                    pasirinkimas = b;
                    break;
                case 3:
                    pasirinkimas = c;
                    break;
                default:
                        break;
            }
            return pasirinkimas;
        }
    }
}
