using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_10_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = 2;
            

            while (a <= 50)
            {
                Console.Write("Skaicius " + a + " dalinasi is: ");
                for (int i = 2; i < 9; i++)
                {
                    if (a % i == 0)
                    {
                        Console.Write(i + " ");
                    }
                }
                Console.Write("\n");

                
                a++;
            }

            
        }
    }
}
