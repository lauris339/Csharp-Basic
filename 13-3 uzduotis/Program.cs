using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_3_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            var zodziai = new[] { "lapas", "gele", "bmw", "medis", "kamuolys" };
            var vardai = new[] {"lukas", "laurynas", "liuciferis", "liutauras", "laimis" };

            Console.WriteLine(zodziai.First());
            Console.WriteLine(vardai.Last());
        }
    }
}
