using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_15_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            var random = new Random();
            var d = random.Next(1, 100);
            var skaiciai = new int[100];
            var sum_sk = new int[100];
            double sum = 0;
            double vid = 0;
            var a = 0;
            
            Console.WriteLine("random skaicius " + d + "\n");

            for (int i = 0; i < skaiciai.Length; i++)
            {
                skaiciai[i] = random.Next(1, 100);
            }
            
            foreach (var skaicius in skaiciai)
            {
                if (skaicius < d)
                {
                    Console.Write(skaicius + " ");
                    sum_sk[a] = skaicius;
                    a++;
                    sum += skaicius;
                }
            }

            a = 0;

            foreach (var skaicius1 in sum_sk)
            {
                if (skaicius1 > 0)
                {
                    a++;
                }
            }

            vid = sum / a;

            Console.WriteLine("\n\nSuma " + sum);
            Console.WriteLine("a = " + a);
            Console.WriteLine("Vidurkis = " + vid);
            
        }
    }
}
