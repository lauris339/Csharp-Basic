using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_10_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            var skaiciai = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 7 };
            var skaiciai1 = new[] { 9, 8, 7, 6, 5, 4, 3, 2, 1, 5 };

            var sum = 0;
            var sum1 = 0;
            double vid, vid1;
            

            foreach (var a in skaiciai)
            {
                sum += a;
            }

            foreach (var b in skaiciai1)
            {
                sum1 += b;
            }

            vid = (double)sum / skaiciai.Length;
            vid1 = (double)sum1 / skaiciai1.Length;

            if (vid > vid1)
            {
                Console.WriteLine("Pirmo ciklo vidurkis didesnis.");
            }
            else if (vid < vid1)
            {
                Console.WriteLine("Antro ciklo vidurkis didesnis.");
            }
            else
            {
                Console.WriteLine("Vidurkiai lygus.");
            }
        }
    }
}
