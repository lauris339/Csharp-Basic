using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_6_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            var p = new Program();
            Console.WriteLine("Kiek norite pamatyt atsitiktiniu skaiciu?");
            int pasirinkimas = Convert.ToInt32(Console.ReadLine());
            p.Skaiciai(pasirinkimas);
        }
        public void Skaiciai(int a)
        {
            var random = new Random();
            for (int i = 0; i < a; i++)
            {
                Console.Write(random.Next(1,50) + " ");
            }
            Console.WriteLine();
        }
    }
}
