using System;

namespace Lab12_3
{
    class Program
    {
        class quadr
        {
            private double I;
            private double II;

            public double A
            {
                get { return I; }
                set
                {
                    if (value < 0) throw new Exception("Side must be positive number!!!");
                    I = value;
                }
            }

            public double B
            {
                get { return II; }
                set
                {
                    if (value < 0) throw new Exception("Side must be positive number!!!");
                    II = value;
                }
            }

            public quadr(double prinI, double prinII)
            {
                A = prinI;
                B = prinII;
            }

            public override string ToString() { return $"a = {I}, b = {II}"; }

            public quadr(quadr previousquadr)
            {
                A = previousquadr.I;
                B = previousquadr.II;
            }

            public double Area() { return I * II; }

            public double Perimeter() { return 2*I + 2*II ; }

        }
        static void Main(string[] args)
        {
            try
            {
                Console.Write("x[1] = "); double x1 = Convert.ToDouble(Console.ReadLine());
                Console.Write("x[2] = "); double x2 = Convert.ToDouble(Console.ReadLine());
                Console.Write("y[1] = "); double y1 = Convert.ToDouble(Console.ReadLine());
                Console.Write("y[2] = "); double y2 = Convert.ToDouble(Console.ReadLine());
                Console.Write("n[1] = "); double n1 = Convert.ToDouble(Console.ReadLine());
                Console.Write("n[2] = "); double n2 = Convert.ToDouble(Console.ReadLine());
                Console.Write("m[1] = "); double m1 = Convert.ToDouble(Console.ReadLine());
                Console.Write("m[2] = "); double m2 = Convert.ToDouble(Console.ReadLine());

                double first = Math.Pow(Math.Pow(x1 - y1, 2) + Math.Pow(x2 - y2, 2), 1 / 2);
                double second = Math.Pow(Math.Pow(m1 - n1, 2) + Math.Pow(m2 - n2, 2), 1 / 2);

                quadr figure = new quadr(first, second);

                Console.WriteLine($"Area = {figure.Area()}");

                Console.WriteLine($"Perimeter = {figure.Perimeter()}");

            }
            catch { Console.WriteLine("Side must be positive!!!"); }
        }
    }
}