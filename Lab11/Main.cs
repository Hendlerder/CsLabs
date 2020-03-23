using System;

namespace Main
{
    class Program
    {
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