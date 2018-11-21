using System;

namespace _18_1_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            var p = new Program();
            var zodis1 = "Labas";
            p.Isvedimas(zodis1);
            p.Isvedimas("As");
            p.Isvedimas("Tavo");
            p.Isvedimas("Valdovas");
            p.Isvedimas("!!!");
        }

        public void Isvedimas(string zodis)
        {
            Console.WriteLine("--" + zodis + "--");
        }
    }
}
