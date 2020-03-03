using System;

namespace Lab5_3
{
    class Program
    {
        static int Factorial(int z)
        {
            int factorial = 1;

            for (int i = 2; i <= z; i++)
            {
                factorial *= i;
            }
            return factorial;
        }
        static void Main(string[] args)
        {
            Console.Write("x = ");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.Write("epsilon = 10**");
            double epsilon = Math.Pow(10, Convert.ToInt32(Console.ReadLine()));


            double sum = Math.Sin(x);
            double current = x;
            double n = 1;

            while (Math.Abs(current) >= epsilon)
            {
                sum -= current;
                n += 2;
                current = Math.Pow(x, (2 * n) - 1) / Factorial((2 * n) - 1);
            }

            double compareValue = Math.Log(Math.Abs(Math.Sin(x)));

            Console.WriteLine("result   = {0}", sum);
            Console.WriteLine("compare  = {0}", compareValue);
            Console.ReadKey();
        }

        private static double Factorial(double p)
        {
            throw new NotImplementedException();
        }
    }
}