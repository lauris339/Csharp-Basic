using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_3_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            var p = new Program();
            var skaiciai = p.Sarasas();
            foreach (var a in skaiciai)
            {
                Console.WriteLine(a);
            }
            
        }
        public List<int> Sarasas()
        {
            var random = new Random();
            var atsitiktiniai = new List<int>();
            for (int i = 0; i < 100; i++)
            {
                atsitiktiniai.Add(random.Next(1, 50));
            }
            return atsitiktiniai;
        }
        
    }
}
