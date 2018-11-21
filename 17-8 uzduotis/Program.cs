using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_8_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            var p = new Program();
            for (int i = 0; i < 100; i++)
            {
                p.Isvedimas();
            }
            Console.WriteLine();
        }
        public void Isvedimas()
        {
            var random = new Random();
            Console.Write(random.Next(15) + " ");
        }
    }
}
