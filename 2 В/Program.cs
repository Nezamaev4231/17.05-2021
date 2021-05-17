using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_В
{
    class Program
    {
        static void Main(string[] args)
        {
            //2в
            Console.WriteLine("Введите число a ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите число b ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите число с ");
            double c = Convert.ToDouble(Console.ReadLine());
            double z = (a / b) * c;
            Console.WriteLine(z);
            Console.ReadKey();
        }
    }
}
