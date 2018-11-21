using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_4_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            var p = new Program();

            p.Isvedimas();
           
        }
        public void Isvedimas()
        {
            Console.Write("Iveskite savo varda: ");
            var a = Console.ReadLine();
            Console.WriteLine("Labas " + a);
        }
    }
}
