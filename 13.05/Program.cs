using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13._05
{
    class Program
    {
        static void Main(string[] args)
        {
            //9
            Console.WriteLine("Введите число S");
            double S1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите число S2");
            double S2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите число S3");
            double S3 = Convert.ToDouble(Console.ReadLine());
            double S = S2 - S3;
            Console.WriteLine(S);
            Console.ReadKey();
        }
    }
}
