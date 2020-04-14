using System;
using System.Linq;

namespace Lab7_4
{
    class Program
    {
        static int[] get_number(int[,] matrix, int[] number, int whichString)
        {
            for (int i = 0; i < matrix.Length; i++) { number[i] = matrix[whichString, i]; }
            return number;
        }
        static void Main(string[] args)
        {
            Console.Write("Size of matrix: "); int size = Convert.ToInt32(Console.ReadLine());

            int[,] matrix = new int[size, size];
            int[] number = new int[size];

            for (int i = 0; i < size; i++) { for (int j = 0; j < size; j++) { Console.Write($"Element[{i}][{j}]: "); matrix[i, j] = Convert.ToInt32(Console.ReadLine()); } }
            for (int i = 0; i + 2 <= size; i += 2)
            {
                number = get_number(matrix, number, i);
                number = number.OrderByDescending(x => x).ToArray();
                for (int j = 0; j < size; j++) matrix[i, j] = number[j];
            }

            for (int i = 0; i < size; i++) { for (int j = 0; j < size; j++) Console.WriteLine($"Element[{i}][{j}]: {matrix[i, j]}"); }

            Console.ReadLine();
        }
    }
}
