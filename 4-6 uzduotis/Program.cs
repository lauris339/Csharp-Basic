using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_6_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            Console.WriteLine("Iveskite sveikaji skaiciu: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Jusu ivestas skaicius yra {0}, o jo kvadratas lygus {1}.", a, a * a);
        }
    }
}
