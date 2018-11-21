using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_2_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            var p = new Program();
            var vardas = "Steve";
            var pavarde = "Jobs";
            var amzius = 25;
            var profesija = "Genius";
            p.Isvedimas(vardas, pavarde, amzius, profesija);
            p.Isvedimas("Laurynas","Milusauskas",23,"Master");

        }
        public void Isvedimas(string name, string surname, int age, string occupation)
        {
            Console.WriteLine("{0} {1}, age of {2}, works as {3}.", name, surname, age, occupation);
        }
    }
}
