using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_5_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = 1;
            var b = 2;
            var suma = a + b;
            var skirtumas = a - b;
            var daugyba = a * b;
            var dalyba = a / b;

            Console.WriteLine("{0} + {1} = {3}\n" +
                "{0} - {1} = {4}\n" +
                "{0} * {1} = {5}\n" +
                "{0} / {1} = {3}\n"
                ,a ,b ,suma ,skirtumas ,daugyba ,dalyba);
        }
    }
}
