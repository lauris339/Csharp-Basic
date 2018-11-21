using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace Parduotuve
{
    class Parduotuve
    {
        public string Pavadinimas { get; private set; }
        public string Adresas { get; private set; }
        public string Bosas { get; private set; }
        public List<Gerimas> Gerimai { get; private set; }

        public Parduotuve()
        {
            Console.WriteLine("Iveskite pavadinima: ");
            Pavadinimas = Console.ReadLine();

            Console.WriteLine("Iveskite adresa: ");
            Adresas = Console.ReadLine();

            Console.WriteLine("Iveskite bosa: ");
            Bosas = Console.ReadLine();

            Console.WriteLine("Iveskite kur yra failas: ");
            var failas = Console.ReadLine();

            var tekstas = File.ReadAllLines(failas);
            Gerimai = new List<Gerimas>();

            for (int i = 1; i < tekstas.Length; i++)
            {
                var gerimas = new Gerimas(tekstas[i]);
                Gerimai.Add(gerimas);
            }
        }

        public void Isvedimas()
        {
            Console.WriteLine("Parduotuve {0} randasi adresu {1}, jos bosas {2}",
                Pavadinimas,Adresas,Bosas);
            Console.WriteLine("Turimi gerimai");
            Console.WriteLine("| {0,-15} | {1,-15} | {2,-15} | {3,-15} | {4,-15} |",
                "Gamintojas", "Pavadinimas", "Laipsniai", "TiekimoKaina", "Turis");
            foreach (var gerimas in Gerimai)
            {
                gerimas.Isvedimas();
            }
            Console.WriteLine();
        }
    }
}
