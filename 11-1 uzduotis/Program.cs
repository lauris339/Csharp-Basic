﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_1_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Isveskite teigiama skaiciu: ");
            var a = Convert.ToInt32(Console.ReadLine());

            if (a > 0)
            {
                while (a != 0)
                {
                    Console.WriteLine(a);
                    a--;
                }
            }
            else
            {
                Console.WriteLine("Blogai ivestas skaicius!");
               
            }
        }
    }
}
