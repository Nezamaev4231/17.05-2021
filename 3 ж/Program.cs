using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_ж
{
    class Program
    {
        static void Main(string[] args)
        {
            //3Ж
            Console.WriteLine("Введите число a ");
            double a = Convert.ToDouble(Console.ReadLine());
            double q = 2 * 3.14 * a;
            Console.WriteLine(q);
            Console.ReadKey();
        }
    }
}
