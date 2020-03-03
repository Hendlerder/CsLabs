using System;

namespace Lab5_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int x0 = 0;
            int x1 = 9;
            int x2 = 9;
            int xi = 0;

            Console.Write("n = ");
            int n = Convert.ToInt32(Console.ReadLine());

            for (int i = 3; i < n; i++)
            {
                xi = x0 + x1 + x2;
                x0 = x1;
                x1 = x2;
                x2 = xi;
            }

            Console.WriteLine("X({0}) = {1}", n, xi);
            Console.ReadKey();

        }
    }
}