using System;

namespace lab6_2
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
            Console.Write("i = ");
            int i = Convert.ToInt32(Console.ReadLine());
            Console.Write("x = ");
            double x = Convert.ToDouble(Console.ReadLine());

            double[] A = new double[i];
            double[] B = new double[i];

            for (int y = 1; y < 1 + i; y++) { A[y - 1] = Math.Pow(y - 1, 2) / (2 * Math.Pow(y, 2) - 1) + Factorial(i) * Math.Sin(y * x); } // Елементи масиву А;
            
            if(A[--i] < 0) { for (int z = 0; z < i; z++) { B[z] = 1 * A[z]; } } else { for (int z = 0; z < i; z++) { B[z] = 1 * Math.Abs(A[z]); } } // Елементи масиву B;
        }
    }
}
