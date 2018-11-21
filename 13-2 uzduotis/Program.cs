using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_2_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            var zodziai = new[] {"lapas", "gele", "bmw", "medis", "kamuolys" };
            var a = new Random();

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(zodziai[a.Next(5)]);
            }
        }
    }
}
