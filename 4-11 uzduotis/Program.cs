﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_11_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite sveikaji skaiciu norint gauti jo daugybos lentele nuo [1 - 5]:");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("{0} * 1 = {1}", a, a * 1);
            Console.WriteLine("{0} * 2 = {1}", a, a * 2);
            Console.WriteLine("{0} * 3 = {1}", a, a * 3);
            Console.WriteLine("{0} * 4 = {1}", a, a * 4);
            Console.WriteLine("{0} * 5 = {1}", a, a * 5);
        }
    }
}
