using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Lab 4
//Task 2
//Variant 3
namespace _4_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("a = ");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.Write("b = ");
            double b = Convert.ToDouble(Console.ReadLine());

            Console.Write("c = ");
            double c = Convert.ToDouble(Console.ReadLine());

            bool intervalOne = a >= 3 && a <= 9;
            bool intervalTwo = a >= b && a <= c;

            if (intervalOne && intervalTwo)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }

            Console.ReadKey();
        }
    }
}
