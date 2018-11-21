using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_5_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            string vardas;
            int amzius;
            Console.WriteLine("Iveskite savo varda: ");
            vardas = Console.ReadLine();
            Console.WriteLine("Iveskite savo amziu: ");
            amzius =Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Jusu vardas yra {0} ir jum yra {1} metu.", vardas, amzius);
        }
    }
}
