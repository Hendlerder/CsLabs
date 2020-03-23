using System;

namespace lab6_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("X = ");
            int X = Convert.ToInt32(Console.ReadLine());
            int[] vect1 = new int[3];
            int[] vect2 = new int[3];

            for (int x = 0; x < 3; x++)
            {
                Console.Write("[{0}] coordinate of first vector ", x + 1);
                int v1 = Convert.ToInt32(Console.ReadLine());
                vect1[x] = v1;
            }

            for (int y = 0; y < 3; y++)
            {
                Console.Write("[{0}] coordinate of second vector ", y + 1);
                int v2 = Convert.ToInt32(Console.ReadLine());
                vect2[y] = v2;
            }

            int Product = vect1[0] * vect2[0] + vect1[1] * vect2[1] + vect1[2] * vect2[2];
            double AbsI = Math.Pow(Math.Pow(vect1[0], 2) + Math.Pow(vect1[1], 2) + Math.Pow(vect1[2], 2), 1.0 / 2);
            double AbsII = Math.Pow(Math.Pow(vect2[0], 2) + Math.Pow(vect2[1], 2) + Math.Pow(vect2[2], 2), 1.0 / 2);

            double Result = Product / (AbsI * AbsII * Math.Cos(X));

            Console.WriteLine("Result = {0}", Result);
        }
    }
}
