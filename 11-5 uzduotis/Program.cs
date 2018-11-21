using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_5_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            
            
            while (true)
            {
                Console.Write("Iveskite skaiciu: ");
                var a = Convert.ToDouble(Console.ReadLine());
                

                if (a % 9 == 0)
                {
                    Console.WriteLine("Ivedete skaiciu kuris dalinasi is 9!");
                    break;
                }

            }
            
        }
    }
}
