using System;
using System.Linq;

namespace lab6_task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Size of array: ");
            int size = Convert.ToInt32(Console.ReadLine());
            int[] numbers = new int[size];

            for (int i = 0; i < size; i++)
            {
                Console.Write("Element[{0}] = ", i);
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }
            int counts = 0;
            foreach (int i in numbers)
            {
                if (i < 0) { counts++; }
            }
            int[] res = new int[counts];
            for(int i = 0; i < counts; i++)
            {
                foreach (int z in numbers)
                {
                    if(z > 0)
                    {
                        continue;
                    }
                    z = res[i];
                }
            }
            Console.WriteLine(numbers.Max());
            Console.WriteLine(counts);

        }
    }
}