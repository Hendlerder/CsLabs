using System;

namespace Main
{
    class Program
    {
        class TPTriangle
        {
            private double I;
            private double II;

            public double A
            {
                get { return I; }
                set
                {
                    if (value < 0) throw new Exception("Cathetus must be positive number!!!");
                    I = value;
                }
            }

            public double B
            {
                get { return II; }
                set
                {
                    if (value < 0) throw new Exception("Cathetus must be positive number!!!");
                    II = value;
                }
            }

            public TPTriangle(double prinI, double prinII)
            {
                A = prinI;
                B = prinII;
            }

            public override string ToString() { return $"a = {I}, b = {II}"; }

            public TPTriangle(TPTriangle previousTPTriangle)
            {
                A = previousTPTriangle.I;
                B = previousTPTriangle.II;
            }

            public double Area() { return I * II / 2; }

            public double Perimeter() { return I + II + Math.Pow(Math.Pow(I, 2) + Math.Pow(II, 2), 1 / 2); }

            public static bool operator ==(TPTriangle tr1, TPTriangle tr2) { return tr1.I == tr2.I && tr1.II == tr2.II; }

            public static bool operator !=(TPTriangle tr1, TPTriangle tr2) { return tr1.I != tr2.I && tr1.II != tr2.II; }

            public static TPTriangle operator +(TPTriangle TPTriangle, double num) { return new TPTriangle(TPTriangle.I + num, TPTriangle.II + num); }

            public static TPTriangle operator -(TPTriangle TPTriangle, double num) { return new TPTriangle(TPTriangle.I - num, TPTriangle.II - num); }

            public static TPTriangle operator *(TPTriangle TPTriangle, double num) { return new TPTriangle(TPTriangle.I * num, TPTriangle.II * num); }
        }
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("x[1] = "); double x1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("x[2] = "); double x2 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("y[1] = "); double y1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("y[2] = "); double y2 = Convert.ToDouble(Console.ReadLine());

                TPTriangle tr1 = new TPTriangle(x1, y1);
                TPTriangle tr2 = new TPTriangle(x2, y2);

                Console.Write("Enter some number: "); double num = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine($"Area = {tr1.Area()}");

                Console.WriteLine($"Perimeter = {tr1.Perimeter()}");

                if (tr1 == tr2) Console.WriteLine("TPTriangles are equals.");
                else Console.WriteLine("TPTriangles are'nt equals.");

                Console.WriteLine($"Summed {num}: {tr1 + num}");

                Console.WriteLine($"Subtracted {num}: {tr1 - num}");

                Console.WriteLine($"Multiplied {num}: {tr1 * num}");

                TPTriangle copie = new TPTriangle(tr2); Console.WriteLine(copie);
            }
            catch { Console.WriteLine("Cathetus of TPTriangle must be positive!!!"); }
        }
    }
}
