using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_16_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            var skaiciai = new int[25];
            var random = new Random();
            int b = 5;
            int a = 0;

            for (int i = 0; i < 25; i++)
            {
                skaiciai[i] = random.Next(1, 10);
            }

            for (a = 0; a < b; a++)
            {
                Console.Write(skaiciai[a] + " ");
            }
            Console.WriteLine();
            b += 5;
            for (a = 5; a < b; a++)
            {
                Console.Write(skaiciai[a] + " ");
            }
            Console.WriteLine();
            b += 5;
            for (a = 10; a < b; a++)
            {
                Console.Write(skaiciai[a] + " ");
            }
            Console.WriteLine();
            b += 5;
            for (a = 15; a < b; a++)
            {
                Console.Write(skaiciai[a] + " ");
            }
            Console.WriteLine();
            b += 5;
            for (a = 20; a < b; a++)
            {
                Console.Write(skaiciai[a] + " ");
            }
            Console.WriteLine();
        }
    }
}
