using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_д
{
    class Program
    {
        static void Main(string[] args)
        {
            //3д
            Console.WriteLine("Введите число m1 ");
            double m1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите число m2 ");
            double m2 = Convert.ToDouble(Console.ReadLine());
            double d = (1 / m1) + (1 / m2);
            Console.WriteLine(d);
            Console.ReadKey();
        }
    }
}
