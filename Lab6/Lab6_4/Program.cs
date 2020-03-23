using System;

namespace Lab6_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("a = "); int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("b = "); int b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Size of array: "); int size = Convert.ToInt32(Console.ReadLine());

            double[] osnova = new double[size];
            for (int i = 0; i < size; i++) { Console.Write("[{0}] number: ", i); osnova[i] = Convert.ToDouble(Console.ReadLine()); }

            double[] first = new double[size];
            double[] second = new double[size];

            for (int i = 0; i < size; i++) { if (osnova[i] >= a) { first[i] = osnova[i]; } else { first[i] = 0; } }
            for (int i = 0; i < size; i++) { if (osnova[i] <= b) { second[i] = 0; } else { second[i] = osnova[i]; } }

            double[] pochti = new double[size];

            for (int i = 0; i < size; i++) { if (first[i] == second[i]) { pochti[i] = 0; } else { pochti[i] = first[i]; } }

            int index = 0;
            int WW = 0;
            int VV = 0;
            foreach (double element in pochti) { if (element == 0) { WW++; } else { VV++; } }

            double[] I = new double[VV];
            double[] II = new double[WW];

            foreach (double element in pochti) { if (element != 0) { I[index] = element; index++; } }

            Console.WriteLine(" ");

            double[] result = new double[I.Length + II.Length];

            I.CopyTo(result, 0);
            II.CopyTo(result, I.Length);

            foreach (double element in result) Console.Write("|{0}|  ", element);

            Console.ReadLine();
        }
    }
}
