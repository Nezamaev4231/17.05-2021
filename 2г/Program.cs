using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2г
{
    class Program
    {
        static void Main(string[] args)
        {
            //2г
            Console.WriteLine("Введите число a");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите число b");
            double b = Convert.ToDouble(Console.ReadLine());
            double s = (a + b) / 2;
            Console.WriteLine(s);
            Console.ReadKey();
        }
    }
}
