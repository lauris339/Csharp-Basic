using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_3_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            var p = new Program();
            int sk1 = 3;
            int sk2 = 1;
            p.Suma(sk1, sk2);
            p.Skirtumas(sk1, sk2);
            p.Sandauga(sk1, sk2);
            p.Dalmuo(sk1, sk2);
        }
        public void Suma(int a, int b)
        {
            Console.WriteLine("{0} + {1} = {2}", a, b, a + b);
        }
        public void Skirtumas(int a, int b)
        {
            Console.WriteLine("{0} - {1} = {2}", a, b, a - b);
        }
        public void Sandauga(int a, int b)
        {
            Console.WriteLine("{0} * {1} = {2}", a, b, a * b);
        }
        public void Dalmuo(int a, int b)
        {
            Console.WriteLine("{0} / {1} = {2}", a, b, a / b);
        }
    }
}
