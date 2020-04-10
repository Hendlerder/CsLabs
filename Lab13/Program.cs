using System;

namespace Lab13
{
    class Program
    {
        class TRTriangle
        {
            private protected double side;
            private protected const double EPSILON = 0.0000000001;

            public double Side
            {
                get { return side; }
                set
                {
                    if (value < 0) throw new Exception("Side cannot be negative");
                    side = value;
                }
            }

            public TRTriangle(double a) { Side = a; }

            public TRTriangle(TRTriangle previousTRTriangle) { Side = previousTRTriangle.side; }

            public override string ToString() { return $"side = {side}"; }

            public double Area() { return 0.5 * side * Math.Pow(Math.Pow(side, 2) - Math.Pow(side / 2, 2), 1 / 2); }

            public double Perimeter() { return side * 3; }

            public static bool operator ==(TRTriangle tr1, TRTriangle tr2) { return (Math.Abs(tr1.side - tr2.side) < EPSILON); }

            public static bool operator !=(TRTriangle tr1, TRTriangle tr2) { return !(tr1 == tr2); }

            public static TRTriangle operator +(TRTriangle tr1, TRTriangle tr2) { return new TRTriangle(tr1.side + tr2.side); }
            public static TRTriangle operator -(TRTriangle tr1, TRTriangle tr2) { return new TRTriangle(tr1.side - tr2.side); }
            public static TRTriangle operator *(TRTriangle tr, double num) { return new TRTriangle(tr.side * num); }
        }
        //---------------------------------------------------------------------------------------------------------------------------
        class TPiramid : TRTriangle
        {
            private double h;
            public double H
            {
                get { return h; }
                set
                {
                    if (value < 0) throw new Exception("Side cannot be negative");
                    h = value;
                }
            }
            public TPiramid(double a, double h) : base(a) { H = h; }
            public new double Area()
            { return base.Area() + 3/2 * side * Math.Pow(Math.Pow(Math.Pow(Math.Pow(h, 2) + Math.Pow(side, 2) / 3, 1 / 2), 2) - Math.Pow(side / 2, 2), 1 / 2); }

            public double Volume() { return base.Area() * h/3; }

            public override string ToString() { return $"side = {side}, h = {h}"; }

            public static TPiramid operator +(TPiramid trpr1, TPiramid trpr2) { return new TPiramid(trpr1.side + trpr2.side, trpr1.h + trpr2.h); }

            public static TPiramid operator -(TPiramid trpr1, TPiramid trpr2) { return new TPiramid(trpr1.side - trpr2.side, trpr1.h - trpr2.h); }

            public static TPiramid operator *(TPiramid trpr, double num) { return new TPiramid(trpr.side * num, trpr.h * num); }

            public static bool operator ==(TPiramid trpr1, TPiramid trpr2) { return (Math.Abs(trpr1.side - trpr2.side) < EPSILON && Math.Abs(trpr1.h - trpr2.h) < EPSILON); }

            public static bool operator !=(TPiramid trpr1, TPiramid trpr2) { return !(trpr1 == trpr2); }
        }
        //-------------------------------------------------------------------------------------------------------------------
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Side of the first TRTriangle = ");  double si = Convert.ToDouble(Console.ReadLine());
                Console.Write("Side of the second TRTriangle = "); double de = Convert.ToDouble(Console.ReadLine());
                Console.Write("Height of the piramid = ");         double hght = Convert.ToDouble(Console.ReadLine());
                Console.Write("Number = ");                        double nmbr = Convert.ToDouble(Console.ReadLine());
                TRTriangle tr1 = new TRTriangle(si);
                TRTriangle tr2 = new TRTriangle(de);
                Console.WriteLine($"Tr1: {tr1}");
                Console.WriteLine($"Tr2: {tr2}");
                Console.WriteLine($"Area of Tr1 = {tr1.Area()}");
                Console.WriteLine($"Area of Tr2 = {tr2.Area()}");
                Console.WriteLine($"Perimeter of Tr1 = {tr1.Perimeter()}");
                Console.WriteLine($"Perimeter of Tr2 = {tr2.Perimeter()}");
                Console.WriteLine("");

                TPiramid piramide = new TPiramid(si, hght);
                Console.WriteLine($"Piramid : {piramide}");
                Console.WriteLine($"Volume of piramid  = {piramide.Volume()}");
                Console.WriteLine("");

                Console.WriteLine($"Tr1+Tr2: {tr1 + tr2}");
                Console.WriteLine($"Tr2-Tr1: {tr2 - tr1}");
                Console.WriteLine($"{tr1 * nmbr}");
                Console.WriteLine($"{tr2 * nmbr}");
                Console.WriteLine("");

                Console.WriteLine($"Tr1 = Tr2: { tr1 == tr2}");
            }
            catch { Console.WriteLine("Side cannot be negative"); }
        }
    }
}