using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_8_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            var zodziai = new List<string>();
            zodziai.Add("bmw");
            zodziai.Add("audi");
            zodziai.Add("mercedes");
            zodziai.Add("peugeot");
            zodziai.Add("volkswagen");

            int trumpiausias = zodziai[0].Length;
            int ilgiausias = zodziai[4].Length;
            
            string least = "";
            string longest = "";

            foreach (var zodis in zodziai)
            {
                if (zodis.Length <= trumpiausias)
                {
                    least = zodis;
                }
            }

            Console.WriteLine("Trumpiausias zodis yra {0} ir jis sudarytas is {1} simboliu.", least, least.Length);

            foreach (var zodis in zodziai)
            {
                if (zodis.Length >= ilgiausias)
                {
                    longest = zodis;
                }
            }

            Console.WriteLine("Ilgiausias zodis yra {0} ir jis sudarytas is {1} simboliu.", longest, longest.Length);

        }
    }
}
