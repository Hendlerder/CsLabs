using System;
using System.Linq;

namespace Lab10_1
{
    class Program
    {
        class CollectionOfNumbers
        {
            private int lenght;
            public int[] Collection;

            public int Num { get; set; }
            public int Lenght
            {
                get { return lenght; }
                set
                {
                    if (value == Convert.ToString(Num).Length) lenght = value;
                    else throw new Exception("Wrong lenght!");
                }
            }
            public CollectionOfNumbers(int num, int lenghtOfNum)
            {
                Num = num;
                Lenght = lenghtOfNum;
                Collection = new int[lenghtOfNum];
                for (int i = 0; i < Lenght; i++)
                {
                    Collection[i] = Num % 10;
                    Num = (Num - (Num % 10)) / 10;
                }

            }
            public int Counts(int num)
            {
                int count = 0;
                for (int i = 0; i < Lenght; i++) { if (num == Collection[i]) { count++; } }
                return count;
            }
            public void Test() { for (int i = 0; i < Lenght; i++) {Console.Write(Collection[i]); } }
            public int Sum() { return Collection.Sum(); }
            public void Equal(int num, int lenght)
            {
                CollectionOfNumbers otherNum = new CollectionOfNumbers(num, lenght);
                if (otherNum.lenght == Lenght) Console.WriteLine("Number have equals lenght.");
                else if (otherNum.lenght > Lenght) Console.WriteLine("Lenght of the new number is longer.");
                else Console.WriteLine("Lenght of the first number is longer");

                if (otherNum.Sum() == Sum()) Console.WriteLine("Numbers have the similiar sum of nums.");
                else if (otherNum.Sum() > Sum()) Console.WriteLine("Sum of the new number is bigger.");
                else Console.WriteLine("Sum of the first number is bigger");
            }


        }
        static void Main(string[] args)
        {
            Console.Write("Lenght of the number: "); int lenght = Convert.ToInt32(Console.ReadLine());
            Console.Write("Number: "); int number = Convert.ToInt32(Console.ReadLine());
            Console.Write("The number to check: "); int check = Convert.ToInt32(Console.ReadLine());
            Console.Write("The length of the number to compare: "); int BLenght = Convert.ToInt32(Console.ReadLine());
            Console.Write("Number for comparison: "); int BNumber = Convert.ToInt32(Console.ReadLine());

            CollectionOfNumbers n = new CollectionOfNumbers(number, lenght);
            Console.WriteLine("Number of occurrence of the number {0}: {1} ", check, n.Counts(check));
            Console.WriteLine("Sum of numbers: {0}", n.Sum());
            n.Equal(BNumber, BLenght);
            Console.Read();
        }
    }
}
