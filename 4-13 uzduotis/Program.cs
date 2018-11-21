using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_13_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite norima simboli:");
            char simbolis = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("{0}{0}{0}{0}{0}{0}\n" +
                "{0}{0}{0}{0}{0}{0}\n" +
                "{0}{0}{0}{0}{0}{0}\n" +
                "{0}{0}{0}{0}{0}{0}\n" +
                "{0}{0}{0}{0}{0}{0}\n" +
                "{0}{0}{0}{0}{0}{0}\n", simbolis);
            
        }
    }
}
