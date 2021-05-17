using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1Д
{
    class Program
    {
        static void Main(string[] args)
        {
            //1Д
            Console.WriteLine("Введите число a ");
            double a = Convert.ToDouble(Console.ReadLine());
            double b = Math.Abs(a);
            Console.WriteLine(b);
            Console.ReadKey();


        }
    }
}