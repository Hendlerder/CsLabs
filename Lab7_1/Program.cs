using System;

namespace Lab7_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Number of rows: "); int nr = Convert.ToInt32(Console.ReadLine());
            Console.Write("Number of columns: "); int nc = Convert.ToInt32(Console.ReadLine());
            double[,] matrix = new double[nr, nc];
            double sum = 0;

            for (int i = 0; i < nr; i++)
            {
                for (int j = 0; j < nc; j++)
                {
                    Console.Write($"Element[{i + 1}][{j + 1}]: ");
                    matrix[i, j] = Convert.ToDouble(Console.ReadLine());
                }
            }

            for (int i = 0; i < nr; i++)
            {
                for (int j = 0; j < nc; j++)
                {
                    if (i + j % 2 == 0 && matrix[i, j] < 0)
                    {
                        sum += matrix[i, j];
                    }
                }
            }
            Console.WriteLine($"The sum of the negative elements of the matrix with an odd sum of indices = {sum}");
            Console.ReadLine();
        }
    }

}
