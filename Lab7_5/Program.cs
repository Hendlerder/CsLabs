using System;
using System.Linq;

namespace Lab7_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Size of matrix: "); int sizeOfMatrix = Convert.ToInt32(Console.ReadLine());

            int[,] matrix = new int[sizeOfMatrix, sizeOfMatrix];
            int[] collumn = new int[sizeOfMatrix];

            for (int i = 0; i < sizeOfMatrix; i++)
            {
                for (int j = 0; j < sizeOfMatrix; j++)
                {
                    Console.Write($"Element[{i}][{j}]: ");
                    matrix[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            for (int i = 0; i < sizeOfMatrix; i++)
            {
                for (int j = 0; j < sizeOfMatrix; j++) { collumn[j] = matrix[j, i]; }

                int result = 0;
                if (collumn[i] < 0) result++;

                if (result == 0) Console.WriteLine($"Sum of column №{ i + 1}: {collumn.Sum()}");
                else Console.WriteLine($"Row №{i + 1} has negative element/elements.");
            }
            Console.ReadLine();
        }
    }

}
