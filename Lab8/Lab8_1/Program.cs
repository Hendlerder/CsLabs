using System;

namespace Lab8_1
{
    class Program
    {
        static double Sum(double x)
        {
            if (x > 3)
            {
                double sum = 0;
                for (int i = 1; i < 10; i+=2)
                    sum += Math.Pow(Math.Sin(x), i);
                return sum;
            }
            else
            {
                double sum = 15;
                double a = Math.Tan(x);
                for (int i = 1; i < 6; i++)
                {
                    sum += a;
                    a = Math.Tan(a);
                }
                return sum;
            }
        }
        static void Main(string[] arg)
        {
            Console.Write("a = "); double I = Convert.ToDouble(Console.ReadLine());
            Console.Write("b = "); double II = Convert.ToDouble(Console.ReadLine());
            double res1 = Sum(I);
            double res2 = Sum(II);
            Console.WriteLine(Math.Max(res1, res2));
            Console.ReadLine();
        }
    }
}