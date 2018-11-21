using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_7_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = new Random();
            var sk = new[] {a.Next(1,100), a.Next(1, 100), a.Next(1, 100), a.Next(1, 100)};
            Console.WriteLine("indekse 0 yra " + sk[0]);
            Console.WriteLine("indekse 1 yra " + sk[1]);
            Console.WriteLine("indekse 2 yra " + sk[2]);
            Console.WriteLine("indekse 3 yra " + sk[3]);
        }
    }
}
