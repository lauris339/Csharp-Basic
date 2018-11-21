using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_5_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            var p = new Program();
            p.Lentele();

        }
        public void Lentele()
        {
            var random = new Random();
            var suma = 0;

            var skaiciai = new int[3,4];

            for (int i = 0; i < 4; i++)
            {
                skaiciai[0, i] = random.Next(10);
            }
            for (int i = 0; i < 4; i++)
            {
                skaiciai[1, i] = random.Next(10);
            }
            for (int i = 0; i < 4; i++)
            {
                suma = skaiciai[0, i] + skaiciai[1, i];
                skaiciai[2, i] = suma;
            }
            for (int i = 0; i < 4; i++)
            {
                Console.Write(skaiciai[0, i] + " ");
            }
            Console.WriteLine();
            for (int i = 0; i < 4; i++)
            {
                Console.Write(skaiciai[1, i] + " ");
            }
            Console.WriteLine();
            for (int i = 0; i < 4; i++)
            {
                Console.Write(skaiciai[2, i] + " ");
            }
            Console.WriteLine();
        }
    }
}
