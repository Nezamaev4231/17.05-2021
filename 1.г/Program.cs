﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.г
{
    class Program
    {
        static void Main(string[] args)
        {
            //1Г
            Console.WriteLine("Введите число x ");
            double x = Convert.ToDouble(Console.ReadLine());
            double b = Math.Sqrt(x);
            Console.WriteLine(b);
            Console.ReadKey();
        }
    }
}
