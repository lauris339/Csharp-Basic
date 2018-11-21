using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_11_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            var vardai = new[] { "adafadf", "efsfasrgf", "safsaf", "aefsaef", "aefasf" };
            

            for (int i = 0; i < vardai.Length; i++)
            {
                Console.Write("+----------");
                
            }
            Console.WriteLine("+");

            for (int i = 0; i < vardai.Length; i++)
            {
                Console.Write("|{0,10}", i);
            }
            Console.WriteLine("|");

            for (int i = 0; i < vardai.Length; i++)
            {
                Console.Write("+----------");

            }
            Console.WriteLine("+");

            for (int i = 0; i < vardai.Length; i++)
            {
                Console.Write("|{0, 10}", vardai[i]);
            }
            Console.WriteLine("|");

            for (int i = 0; i < vardai.Length; i++)
            {
                Console.Write("+----------");

            }
            Console.WriteLine("+");

        }
    }
}
