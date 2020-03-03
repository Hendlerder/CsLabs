using System;

namespace Lab5_1
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = 4;
            double ai = 0;

            for (int i = 0; i <= 12; i++)
            {
                
                ai += a - Math.Cos((Math.Pow(a, i) / 12));
                a = ai;
            }
            Console.WriteLine(ai);
            Console.ReadKey();
        }
    }
}
