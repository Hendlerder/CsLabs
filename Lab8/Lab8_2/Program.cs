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

            int[] Maln = new int[3];
            Console.Write("First MAIN line Ax = "); Maln[0] = Convert.ToInt32(Console.ReadLine());
            Console.Write("First MAIN line By = "); Maln[1] = Convert.ToInt32(Console.ReadLine());
            Console.Write("First MAIN line C = "); Maln[2] = Convert.ToInt32(Console.ReadLine());
            
            int[] malN = new int[3];
            Console.Write("Second MAIN line Ax = "); malN[0] = Convert.ToInt32(Console.ReadLine());
            Console.Write("Second MAIN line By = "); malN[1] = Convert.ToInt32(Console.ReadLine());
            Console.Write("Second MAIN line C = "); malN[2] = Convert.ToInt32(Console.ReadLine());

            Console.Write("The nubmer of lines which are between two MAIN lines = "); int numb = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= numb; i++)
            {
                int[] line = new int[3];
                Console.Write("Line №{0} Ax = ", i); line[0] = Convert.ToInt32(Console.ReadLine());
                Console.Write("Line №{0} Bx = ", i); line[1] = Convert.ToInt32(Console.ReadLine());
                Console.Write("Line №{0} C = ", i); line[2] = Convert.ToInt32(Console.ReadLine());
                if (Parallel(Maln, line) == 1) { result++; }
            }
            
            for (int j = 1; j <= numb; j++)
            {
                int[] line = new int[3];
                Console.Write("Line №{0} Ax = ", j); line[0] = Convert.ToInt32(Console.ReadLine());
                Console.Write("Line №{0} Bx = ", j); line[1] = Convert.ToInt32(Console.ReadLine());
                Console.Write("Line №{0} C = ", j); line[2] = Convert.ToInt32(Console.ReadLine());
                if (Parallel(malN, line) == 1) { result++; }
            }
            Console.WriteLine("The number of mutually parallel pairs of lines which are between two main lines = {0}", result);
        }
    }
}
