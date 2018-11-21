using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_4_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            var skaiciai = new List<int>();
            Console.WriteLine("Iveskite 10 skaiciu kurios norite issaugoti:");
            for (int i = 0; i < 10; i++)
            {
                skaiciai.Add(Convert.ToInt32(Console.ReadLine()));
            }

            foreach (var a in skaiciai)
            {
                Console.Write(a + " ");
            }

        }
    }
}
