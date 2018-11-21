using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_7_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, d, e;
            Console.WriteLine("Prasome ivesti penkis skaicius: ");
            a = Convert.ToDouble(Console.ReadLine());
            b = Convert.ToDouble(Console.ReadLine());
            c = Convert.ToDouble(Console.ReadLine());
            d = Convert.ToDouble(Console.ReadLine());
            e = Convert.ToDouble(Console.ReadLine());
            double vid = (a + b + c + d + e) / 5;
            Console.WriteLine("Siu skaiciu vidurkis yra " + vid);
        }
    }
}
