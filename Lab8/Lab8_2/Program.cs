using System;

namespace Lab8_2
{
    class Program
    {
        static int Parallel(int[] I, int[] II)
        {
            int sooth = 0;
            if ((I[0] == II[0] && I[1] == II[1] && I[2] != II[2]) || (I[0] / II[0] == I[1] / II[1])) { sooth += 1; }
            return sooth;
        }

        static void Main(string[] args)
        {
            int result = 0;

            int[] maln = new int[3];
            Console.Write("Main line Ax = "); maln[0] = Convert.ToInt32(Console.ReadLine());
            Console.Write("Main line By = "); maln[1] = Convert.ToInt32(Console.ReadLine());
            Console.Write("Main line C = "); maln[2] = Convert.ToInt32(Console.ReadLine());

            Console.Write("The nubmer of lines which are between two MAIN lines = "); int numb = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= numb; i++)
            {
                int[] line = new int[3];
                Console.Write("Line №{0} Ax = ", i); line[0] = Convert.ToInt32(Console.ReadLine());
                Console.Write("Line №{0} Bx = ", i); line[1] = Convert.ToInt32(Console.ReadLine());
                Console.Write("Line №{0} C = ", i); line[2] = Convert.ToInt32(Console.ReadLine());
                if (Parallel(maln, line) == 1) { result++; }
            }
            Console.WriteLine("The number of mutually parallel pairs of lines which are between two main lines = {0}", result);
        }
    }
}