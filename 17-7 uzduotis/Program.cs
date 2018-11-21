using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_7_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            var p = new Program();
            p.Atsitiktinis();
            Console.WriteLine();
        }
        public void Atsitiktinis()
        {
            var random = new Random();
            for (int i = 0; i < 10; i++)
            {
                Console.Write(random.Next(15) + " ");
            }
        }
    }
}
