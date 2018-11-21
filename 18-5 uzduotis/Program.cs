using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_5_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            var p = new Program();
            var vardas = "Mario";
            var pavarde = "Plumber";
            var kodas = 15642;
            var sk1 = 1;
            var sk2 = 2;
            var sk3 = 3;

            p.Combined(vardas, pavarde, kodas, sk1, sk2, sk3);
            p.Combined("Auksinis kardas", "Auksine raide", 1234567890, 9, 8, 7);
        }

        public void Zodziai(string name, string surname, int code)
        {
            Console.WriteLine("{0} {1}, belongs to academic group of {2}.",name, surname, code);
        }

        public void Skaiciai(int a, int b, int c)
        {
            var sum = a + b + c;
            var avg = sum / 3;
            Console.WriteLine("The average of three numbers is {0}.", avg);
        }

        public void Combined(string name, string surname, int code, int a, int b, int c)
        {
            Zodziai(name, surname, code);
            Skaiciai(a, b, c);
        }

    }
}
