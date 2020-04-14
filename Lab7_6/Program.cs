using System;
using System.Linq;

namespace Lab7_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Size of matrix: "); int size = Convert.ToInt32(Console.ReadLine());

            int[,] matrix = new int[size, size];
            int[] arrOfSums = new int[(size - 1) * 2];

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    Console.Write($"A[{i},{j}]: ");
                    matrix[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            for (int i = 0, k, firstTopDiagonal = size - 1, firstBottomDiagonal = 0; i <= (size - 1) * 2; i++)
            {
                if (firstTopDiagonal > 0)
                {
                    int sum = 0;
                    k = 0;
                    firstTopDiagonal--;
                    for (int j = firstTopDiagonal; j >= 0; j--)
                    {
                        sum += Math.Abs(matrix[k, j]);
                        k++;
                        if (j == 0)
                            arrOfSums[i] = sum;
                    }
                }
                else
                {
                    int sum = 0;
                    k = size - 1;
                    firstBottomDiagonal++;
                    for (int j = firstBottomDiagonal; j < size; j++)
                    {
                        sum += Math.Abs(matrix[k, j]);
                        k--;
                        if (j == size - 1)
                            arrOfSums[i] = sum;
                    }
                }
            }
            Console.WriteLine($"Min sum : {arrOfSums.Min()}");
            Console.ReadLine();
        }
    }

}
