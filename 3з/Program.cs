using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3з
{
    class Program
    {
        static void Main(string[] args)
        {
            //3з
            Console.WriteLine("Введите число b");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите число a");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите число c");
            double c = Convert.ToDouble(Console.ReadLine());
            double k = (b * b) - (4 * a * c);
            Console.WriteLine(k);
            Console.ReadKey();
        }
    }
}
