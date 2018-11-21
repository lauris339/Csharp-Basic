using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_4_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            var b = new[] { 9, 8, 7, 6, 5, 4, 3, 2, 1 };
            var c = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            var d = new Random();
            var d1 = d.Next(9);
            var d2 = d.Next(9);
            var d3 = d.Next(9);
            Console.WriteLine(a[d1]);
            Console.WriteLine(b[d2]);
            Console.WriteLine(c[d3]);

            if (a[d1] > b[d2] && a[d1] > c[d3])
            {
                Console.WriteLine("pirmo masyvo skaicius didziausias - " + a[d1]);
            }
            else if (a[d1] < b[d2] && b[d2] > c[d3])
            {
                Console.WriteLine("antro masyvo skaicius didziausias - " + b[d2]);
            }
            else
            {
                Console.WriteLine("trecio masyvo skaicius didziausias - " + c[d3]);
            }
        }
    }
}
