using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_12_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite tris skaicius:");
            double a = Convert.ToDouble(Console.ReadLine());
            double b = Convert.ToDouble(Console.ReadLine());
            double c = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Pirmas ivestas skaicius - {0}, jo kvadratas - {1}," +
                " pakeltas treciuoju laipsniu - {2} ir padalintas is dvieju - {3}"
                , a, a * a, Math.Pow(a,3), a / 2);
            Console.WriteLine("Antras ivestas skaicius - {0}, jo kvadratas - {1}," +
                " pakeltas treciuoju laipsniu - {2} ir padalintas is dvieju - {3}"
                , b, b * b, Math.Pow(b, 3), b / 2);
            Console.WriteLine("Trecias ivestas skaicius - {0}, jo kvadratas - {1}," +
                " pakeltas treciuoju laipsniu - {2} ir padalintas is dvieju - {3}"
                , c, c * c, Math.Pow(c, 3), c / 2);
        }
    }
}
