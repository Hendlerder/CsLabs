using System;

namespace Lab7_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Number of colums: "); int nc = Convert.ToInt32(Console.ReadLine());
            Console.Write("Number of rows: "); int nr = Convert.ToInt32(Console.ReadLine());
            
            double[] vector = new double[nc];
            double[,] matrix = new double[nr, nc];

            for (int i = 0; i < nc; i++)
            {
                Console.Write($"Vector's element №{i+1}: ");
                vector[i] = Convert.ToDouble(Console.ReadLine());
            }
            for (int i = 0; i < nr; i++)
            {
                for (int j = 0; j < nc; j++)
                {
                    Console.Write($"Element[{i}][{j}]: ");
                    matrix[i, j] = Convert.ToDouble(Console.ReadLine());
                }
            }
            for (int i = 0; i < nr; i++) { for (int j = 0; j < nc; j++) matrix[i, j] *= vector[j]; }

            for (int i = 0; i < nr; i++) { for (int j = 0; j < nc; j++) Console.WriteLine($"Element[{i}][{j}] of new matrix: {matrix[i, j]}"); }

            Console.ReadLine();

        }
    }

}
