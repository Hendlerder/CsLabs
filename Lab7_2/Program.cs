using System;
using System.Linq;

namespace Lab7_2
{
    class Program
    {
        static int MAT(int nr, int nc, int n)
        {
            int[] mat = new int[n];

            if ((nr + nc) % 2 == 0)
            {
                for (int i = 0; i <= nr; i++) mat[i] = i + 1;
                return mat.Sum();
            }
            else for (int i = 0; i <= nc; i++) mat[i] = (i + 1) * (i + 1);

            return mat.Sum();
        }
        static int RIX(int[,] matrix, int position, int n)
        {
            int[] collumn = new int[n];
            int rix = 1;

            for (int i = 0; i < n; i++) collumn[i] = matrix[i, position];

            for (int i = 0; i < n; i++) { rix *= collumn[i]; }

            return rix;
        }
        static void Main(string[] args)
        {
            Console.Write("Size of matrix: "); int n = Convert.ToInt32(Console.ReadLine());

            int[,] mat = new int[n, n];
            int[] rix = new int[n];

            for (int i = 0; i < n; i++) { for (int j = 0; j < n; j++) { mat[i, j] = MAT(i, j, n); } }

            for (int i = 0; i < n; i++) { rix[i] = RIX(mat, i, n); }

            int max = 0;

            for (int i = 0; i < n; i++) { if (rix[i] > max || rix[i] % 2 == 0) max = rix[i]; }

            if (max != 0) Console.WriteLine($"Max pair number: {max}");
            else Console.WriteLine("There is no pair number.");
            Console.ReadLine();
        }
    }

}
