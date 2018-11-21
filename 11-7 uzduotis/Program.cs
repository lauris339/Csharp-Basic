using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_7_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            var temperaturos = new List<double>();
            Console.WriteLine("Kiek dienu temperaturu norite suvesti?");
            var kiek = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < kiek; i++)
            {
                Console.WriteLine("Jus ivedinejate {0} dienos reiksme.", i);
                var ivedimas = Convert.ToDouble(Console.ReadLine());
                temperaturos.Add(ivedimas);
            }

            double suma = 0;
            double vidurkis = 0;
            var zemiausia = temperaturos[0];
            var auksciausia = temperaturos[0];
            kiek = 0;
            var zemiau = 0;
            var a = 0;

            foreach (var temp in temperaturos)
            {
                Console.Write(temp + ",");
                suma += temp;
                kiek += 1;
                if (temp < zemiausia)
                {
                    zemiausia = temp;
                }
                if(temp > auksciausia)
                {
                    auksciausia = temp;
                }
            }

            vidurkis = suma / kiek;
            Console.WriteLine("Temperaturu vidurkis lygus " + vidurkis);
            
            foreach (var temp in temperaturos)
            {
                if (temp < vidurkis)
                {
                    zemiau += 1;
                }
            }
            foreach (var temp in temperaturos)
            {
                a++;
                if (temp == auksciausia)
                {
                    break;
                }
            }

            if (temperaturos[0] > temperaturos[kiek - 1])
            {
                Console.WriteLine("Pirma {0} temperatura didesne uz paskutine {1}.", temperaturos[0], temperaturos[kiek-1]);
            }
            else if (temperaturos[0] < temperaturos[kiek - 1])
            {
                Console.WriteLine("Pirma {0} temperatura mazesne uz paskutine {1}.", temperaturos[0], temperaturos[kiek - 1]);
            }
            else
            {
                Console.WriteLine("Pirmos {0} ir paskutines ivestos {1} temperaturos yra lygios",temperaturos[0],temperaturos[kiek-1]);
            }

            Console.WriteLine("Zemiausia temperatura yra " + zemiausia);
            Console.WriteLine("{0}-ja diena buvo auksciausia temperatura, kuri sieke {1} laipsnius.", a, auksciausia);
        }
    }
}
