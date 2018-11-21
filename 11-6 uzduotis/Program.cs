using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_6_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = new Random();
            var b = a.Next(1,11);
            int c = 0;

            while (b != c)
            {
                Console.WriteLine("Bandykite atspeti slapta skaiciu\nNuo 1 iki 10.");
                c = Convert.ToInt32(Console.ReadLine());
                if (c == b)
                {
                    Console.WriteLine("Atspejote!");
                }
            }

        }
    }
}
