using System;

//Lab 4
//Task 4
//Variant 5
namespace _4_4
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("x = ");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.Write("y = ");
            double y = Convert.ToDouble(Console.ReadLine());

            if (x > y)
            {
                double z = y * Math.Pow(Math.E, x);
                Console.WriteLine("Z = {0}, if x > y.", z);
            }
            else if (x == y)
            {
                double z = y * x;
                Console.WriteLine("Z = {0}, if x == y.", z);
            }
            else
            {
                double z = x * Math.Pow(x, Math.E);
                Console.WriteLine("Z = {0}, if x < y.", z);
            }
            Console.ReadKey();
        }
    }
}
