using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_01_uzduotis
{
    class Alus
    {
        //propg
        public double Laipsniai { get; private set; }
        public double Turis { get; private set; }
        public string Ipakavimas { get; private set; }
        public string Spalva { get; private set; }
        public double Reitingas { get; private set; }

        //ctorp
        public Alus(double laipsniai, double turis, string ipakavimas, string spalva, double reitingas)
        {
            Laipsniai = laipsniai;
            Turis = turis;
            Ipakavimas = ipakavimas;
            Spalva = spalva;
            Reitingas = reitingas;
        }

        public void Isvedimas()
        {
            Console.WriteLine("{0} alaus turi {1} laipsniu {2} turyje. Yra {3} spalvos ir pasieke {4} reitinga."
                ,Ipakavimas,Laipsniai,Turis,Spalva,Reitingas);
        }
    }
}
