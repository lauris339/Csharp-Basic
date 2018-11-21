using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_8_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            double laipsnis, kelvinas, fahrenheitas;
            Console.WriteLine("Si programa isvercia laipscius °C\n" +
                "I kelvinus K\nIr i fahrenheitus °F.\n" +
                "Prasome ivesti norimus isversti laipsnius:");
            laipsnis = Convert.ToDouble(Console.ReadLine());
            kelvinas = laipsnis + 273.15;
            fahrenheitas = (laipsnis * 9 / 5) + 32;
            Console.WriteLine("Jusu pasirinkti laipsniai atitinka {0}K ir {1}°F", kelvinas, fahrenheitas);
        }
    }
}
