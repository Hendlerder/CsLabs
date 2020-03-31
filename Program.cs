using System;

namespace Var11_YuriiSnitsarenko
{
    class Program
    {
        class arr
        {
            private double a;
            private double b;
            private double c;
            private double d;
            private double e;
            private double f;
            public double A { get { return a; } set { a = value; } }
            public double B { get { return b; } set { b = value; } }
            public double C { get { return c; } set { c = value; } }
            public double D { get { return d; } set { d = value; } }
            public double E { get { return e; } set { e = value; } }
            public double F { get { return f; } set { f = value; } }
            public arr(double userA, double userB, double userC, double userD, double userE, double userF)
            {
                A = userA;
                B = userB;
                C = userC;
                D = userD;
                E = userE;
                F = userF;
            }
            public override string ToString() { return $"a = {a}, b = {b}, c = {c}, d = {d}, e = {e}, f = {f}"; }
            public double MaxElement()
            {
                double MaxValue = 0;
                if(a >= b && a >= c && a >= d && a >= e && a >= f) { MaxValue = a; }
                if (a <= b && a >= c && a >= d && a >= e && a >= f) { MaxValue = b; }
                if (a >= b && a <= c && a >= d && a >= e && a >= f) { MaxValue = c; }
                if (a >= b && a >= c && a <= d && a >= e && a >= f) { MaxValue = d; }
                if (a >= b && a >= c && a >= d && a <= e && a >= f) { MaxValue = e; }
                if (a >= b && a >= c && a >= d && a >= e && a <= f) { MaxValue = f; }
                return MaxValue;
            }
            public double MinElement()
            {
                double MinValue = 0;
                if (a <= b && a <= c && a <= d && a <= e && a <= f) { MinValue = a; }
                if (a >= b && a <= c && a <= d && a <= e && a <= f) { MinValue = b; }
                if (a <= b && a >= c && a <= d && a <= e && a <= f) { MinValue = c; }
                if (a <= b && a <= c && a >= d && a <= e && a <= f) { MinValue = d; }
                if (a <= b && a <= c && a <= d && a >= e && a <= f) { MinValue = e; }
                if (a <= b && a <= c && a <= d && a <= e && a >= f) { MinValue = f; }
                return MinValue;
            }

            private static double Sort(double[] ar) { throw new NotImplementedException(); }
            public double Sort()
            {
                double[] ar = { a, b, c, d, e, f};
                return arr.Sort(ar);
            }
            public double Sum() { return a + b + c + d + e + f; }

            // Overloading +
            public static arr operator +(arr array, double num) { return new arr(array.a + num, array.b + num, array.c + num, array.d + num, array.e + num, array.f + num); }
            // Overloading -
            public static arr operator -(arr array, double num) { return new arr(array.a - num, array.b - num, array.c - num, array.d - num, array.e - num, array.f - num); }
            // Overloading *
            public static arr operator *(arr array, double num) { return new arr(array.a * num, array.b * num, array.c * num, array.d * num, array.e * num, array.f * num); }
        }
        static void Main(string[] args)
        {
            try
            {
                double[] mass = new double[6];
                for (int i = 0; i < 6; i++)
                {
                    Console.Write("Array[{0}] = ", i);
                    mass[i] = Convert.ToInt32(Console.ReadLine());
                }

                Console.Write("Enter some num: "); double num = Convert.ToDouble(Console.ReadLine());

                arr arr = new arr(mass[0], mass[1], mass[2], mass[3], mass[4], mass[5]);
                Console.WriteLine($"Max element = {arr.MaxElement()}");
                Console.WriteLine($"Min element = {arr.MinElement()}");
                Console.WriteLine($"Sort = {arr.Sort()}");
                Console.WriteLine($"Sum = {arr.Sum()}");
                Console.WriteLine($"Added {num}: {arr + num}");
                Console.WriteLine($"Multiplied {num}: {arr * num}");
                Console.WriteLine($"Subtracted {num}: {arr - num}");
            }
            catch { Console.WriteLine("Size of array must be =< 6 but size > 0"); }
        }
    }
}
