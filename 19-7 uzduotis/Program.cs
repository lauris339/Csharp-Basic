using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_7_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            var p = new Program();
            var skaiciai = new int[] { 1, 2, 3, 4, 5 };
            var suma = p.Suma(skaiciai);
            var kiekis1 = skaiciai.Length - 1;
            p.Isvedimas(skaiciai, suma, kiekis1);
        }
        public int Maziausias(int[] numbers)
        {
            var min = numbers.Min();
            return min;
        }
        public int Didziausias(int[] numbers)
        {
            var max = numbers.Max();
            return max;
        }
        public int Suma(int[] numbers)
        {
            var suma = 0;
            foreach (var a in numbers)
            {
                suma += a;
            }
            return suma;
        }
        public int Vidurkis(int suma, int kiekis)
        {
            var vidurkis = suma / kiekis;
            return vidurkis;
        }
        public void Isvedimas(int[] numbers, int suma, int kiekis)
        {
            var min = Maziausias(numbers);
            var max = Didziausias(numbers);
            var sum = Suma(numbers);
            var avg = Vidurkis(suma, kiekis);
            Console.WriteLine("Maziausias masyvo skaicius yra {0}, o didziausias {1}.", min, max);
            Console.WriteLine("Masyvo skaiciu suma yra {0}, o ju vidurkis {1}.", sum, avg);
            
        }

    }
}
