using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_12_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            var km = new[] { 24, 20.5, 100, 15, 2.5, 24.3, 26, 30 };
            double sum = 0;
            var benzas = 1.305;
            var kuro_sanaudos = 8.7;
            var vid_greitis = 65.9;

            foreach (var kelione in km)
            {
                sum += kelione;
            }

            double keliones_kaina = (sum / kuro_sanaudos) * benzas;

            double per_kiek_laiko = sum / vid_greitis;

            Console.WriteLine("Kiek is viso nuvaziuota " + sum);

            Console.WriteLine("Keliones kaina " + keliones_kaina);

            Console.WriteLine("Per kiek laiko iveke kelione " + per_kiek_laiko);

            
        }
    }
}
