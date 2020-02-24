using System;

//Lab 4
//Task 3
//Variant 5
namespace _4_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter x1, x2, x3, y1, y2, y3: ");

            double x1 = Convert.ToDouble(Console.ReadLine());
            double x2 = Convert.ToDouble(Console.ReadLine());
            double x3 = Convert.ToDouble(Console.ReadLine());
            double y1 = Convert.ToDouble(Console.ReadLine());
            double y2 = Convert.ToDouble(Console.ReadLine());
            double y3 = Convert.ToDouble(Console.ReadLine());

            double AB = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            double BC = Math.Sqrt(Math.Pow(x3 - x2, 2) + Math.Pow(y3 - y2, 2));
            double AC = Math.Sqrt(Math.Pow(x3 - x1, 2) + Math.Pow(y3 - y1, 2));


            if (AB == BC || AB == AC || BC == AC)
            {
                Console.WriteLine("Triangle is isosceles.");
            }
            else
            {
                Console.WriteLine("Triangle isn't isosceles.");
            }

            Console.ReadKey();
        }
    }
}