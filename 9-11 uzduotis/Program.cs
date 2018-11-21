using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_11_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            double suma = 0;
            Console.WriteLine("Iveskite bet koki skaiciu: ");
            var skaicius = Convert.ToDouble(Console.ReadLine());

            while (skaicius != 0)
            {
                if (skaicius == 0)
                {
                    break;
                }
                suma += skaicius;
                Console.WriteLine("Iveskite bet koki skaiciu: ");
                skaicius = Convert.ToDouble(Console.ReadLine());
                
            }
            Console.WriteLine("Suma = " + suma);
        }
    }
}
