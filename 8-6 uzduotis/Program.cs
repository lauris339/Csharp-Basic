using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_6_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite reziu pradzia:");
            var pradzia = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Iveskite reziu pabaiga:");
            var pabaiga = Convert.ToDouble(Console.ReadLine());

            if (pradzia < pabaiga)
            {
                for (double i = pradzia; i <= pabaiga; i++)
                {
                    if (i % 2 != 0 || i % 8 == 0)
                    {
                        Console.WriteLine(i);
                    }
                }
            }
        }
    }
}
