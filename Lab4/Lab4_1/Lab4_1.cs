using System;

// Lab 4
// Task 1
// Variant 5
namespace _4_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Side of the square = ");
            double side = Convert.ToDouble(Console.ReadLine());

            double area = side * side;

            double perimeter = 4 * side;

            Console.WriteLine("Side of the square = {0};", side);
            Console.WriteLine("Area of the square = {0};", area);
            Console.WriteLine("Perimeter of the square = {0}.", perimeter);
            Console.ReadKey();
        }
    }
}
