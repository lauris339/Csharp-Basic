using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_01_uzduotis
{
    class Program
    {
        class Lengva
        {
            public string Pamoka;
            public int Pazymys;
            public bool SuoloDraugas;

            public Lengva()
            {

            }

            public Lengva(string pamoka, int pazymys, bool suolodraugas)
            {
                Pamoka = pamoka;
                Pazymys = pazymys;
                SuoloDraugas = suolodraugas;
            }

            public void Nusirasineti()
            {
                if(SuoloDraugas)
                {
                    Pazymys++;
                }
            }

            public void Isvedimas()
            {
                Console.WriteLine("Pamoka: " + Pamoka);
                Console.WriteLine("Pazymys: " + Pazymys);
                Console.WriteLine("Suolo draugas: " + SuoloDraugas);
                Console.WriteLine();
            }
        }

        static void Main(string[] args)
        {
            var p = new Lengva();
            Lengva p2 = new Lengva();

            p.Pamoka = "csharp";
            p.Pazymys = 9;
            p.SuoloDraugas = true;

            p2.Pamoka = "csharp2";
            p2.Pazymys = 9;
            p2.SuoloDraugas = false;

            Console.WriteLine("p");
            p.Isvedimas();
            p.Nusirasineti();
            p.Isvedimas();

            Console.WriteLine("p2");
            p2.Isvedimas();
            p2.Nusirasineti();
            p2.Isvedimas();

            var p3 = new Lengva("C#", 8, true);
            Console.WriteLine("p3");
            p3.Isvedimas();
            p3.Nusirasineti();
            p3.Nusirasineti();
            p3.Isvedimas();

            var p4 = new Alus(5.5, 0.5, "skarbonke", "tamsus", 8);
            p4.Isvedimas();

        }
    }
}
