using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parduotuve
{
    class Gerimas
    {
        public string Gamintojas { get; private set; }
        public string Pavadinimas { get; private set; }
        public double Laipsniai { get; private set; }
        public double TiekimoKaina { get; private set; }
        public double Turis { get; private set; }

        public Gerimas(string eilute)
        {
            var isskaidyta = eilute.Split(';');
            Gamintojas = isskaidyta[0];
            Pavadinimas = isskaidyta[1];
            Laipsniai = Convert.ToDouble(isskaidyta[2]);
            TiekimoKaina = Convert.ToDouble(isskaidyta[3]);
            Turis = Convert.ToDouble(isskaidyta[4]);
        }

        public void Isvedimas()
        {
            // {0,-15} ---> -15 lygiavimas is kaires, jei butu 15 butu lygiavimas is desines.
            Console.WriteLine("| {0,-15} | {1,-15} | {2,-15} | {3,-15} | {4,-15} |",
                Gamintojas,Pavadinimas,Laipsniai,TiekimoKaina,Turis);
        }
    }
}
