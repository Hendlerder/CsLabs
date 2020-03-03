using System;

namespace Lab5_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Int64 n, max = 0;
            Console.WriteLine("Enter number: ");
            n = Int64.Parse(Console.ReadLine());
            while (n > 0)
            {
                if (max < n % 10) max = n % 10;
                n /= 10;
            }
            Console.WriteLine("Your max = {0}.", max);
            Console.ReadKey();
        }
    }
}