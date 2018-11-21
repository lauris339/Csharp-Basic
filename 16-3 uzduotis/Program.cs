using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_3_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            var vardai = new List<string>() { "bmw" };
            vardai.Add("audi");
            vardai.Add("peugeot");
            vardai.Add("mercedes");
            vardai.Add("subaru");

            foreach (var a in vardai)
            {
                Console.Write(a + ",");
            }
        }
    }
}
