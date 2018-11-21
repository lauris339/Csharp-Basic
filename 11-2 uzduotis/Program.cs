using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_2_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Isveskite neigiama skaiciu: ");
            var a = Convert.ToInt32(Console.ReadLine());

            if (a < 0)
            {
                while (a < 1)
                {
                    Console.Write(a + " ");
                    a++;
                }
            }
            else
            {
                Console.WriteLine("Blogai ivestas skaicius!");

            }
        }
    }
}
