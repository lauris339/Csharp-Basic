using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_3_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            var p = new Program();
            for (int i = 0; i < 3; i++)
            {
                p.Isvedimas();
            }
        }
        public void Isvedimas()
        {
            Console.Write("-");
            Console.ReadLine();
           
        }
    }
}
