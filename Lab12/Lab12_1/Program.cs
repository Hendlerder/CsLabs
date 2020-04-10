using System;

namespace Lab12_1
{
    class Cathetus
    {
        public double Lenght { get; set; }
    }
    class TPTriangle
    {
        public Cathetus[] inf;
        public TPTriangle(double v1, double v2) { inf = new Cathetus[2]; }
        public Cathetus this[int index]
        {
            get { return inf[index]; }
            set { inf[index] = value; }
        }
        public Cathetus this[double lenght]
        {
            get
            {
                Cathetus cathetus = null;
                return cathetus;
            }
        }
        public double Area() { return inf[0].Lenght * inf[1].Lenght / 2; }
        public double Perimeter() { return inf[0].Lenght + inf[1].Lenght + Math.Pow(Math.Pow(inf[0].Lenght, 2) + Math.Pow(inf[1].Lenght, 2), 0.5); }
        public static bool operator ==(TPTriangle tr1, TPTriangle tr2) { return tr1.inf[0].Lenght == tr2.inf[0].Lenght && tr1.inf[1].Lenght == tr2.inf[1].Lenght; }

        public static bool operator !=(TPTriangle tr1, TPTriangle tr2) { return tr1.inf[0].Lenght != tr2.inf[0].Lenght && tr1.inf[1].Lenght != tr2.inf[1].Lenght; }

        public static TPTriangle operator +(TPTriangle TPTriangle, double num) { return new TPTriangle(TPTriangle.inf[0].Lenght + num, TPTriangle.inf[1].Lenght + num); }

        public static TPTriangle operator -(TPTriangle TPTriangle, double num) { return new TPTriangle(TPTriangle.inf[0].Lenght - num, TPTriangle.inf[1].Lenght - num); }

        public static TPTriangle operator *(TPTriangle TPTriangle, double num) { return new TPTriangle(TPTriangle.inf[0].Lenght * num, TPTriangle.inf[1].Lenght * num); }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("First cathetus of the TPTriangle №1 = "); double x1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Second cathetus of the TPTriangle №1= "); double y1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("First cathetus of the TPTriangle №2 = "); double x2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Second cathetus of the TPTriangle №2= "); double y2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter some number: "); double num = Convert.ToDouble(Console.ReadLine());

            TPTriangle tr1 = new TPTriangle(x1, y1);
            tr1[0] = new Cathetus { Lenght = x1 };
            tr1[1] = new Cathetus { Lenght = y1 };
            TPTriangle tr2 = new TPTriangle(x2, y2);
            tr2[0] = new Cathetus { Lenght = x2 };
            tr2[1] = new Cathetus { Lenght = y2 };

            Console.WriteLine("");
            Console.WriteLine("Test:");
            Console.WriteLine("First cathetus of the TPTriangle №1 = {0}", tr1[0].Lenght);
            Console.WriteLine("Second cathetus of the TPTriangle №1 = {0}", tr1[1].Lenght);
            Console.WriteLine("First cathetus of the TPTriangle №2 = {0}", tr2[0].Lenght);
            Console.WriteLine("Second cathetus of the TPTriangle №2 = {0}", tr2[1].Lenght);
            Console.WriteLine("");

            Console.WriteLine("Answers:");
            Console.WriteLine($"Area = {tr1.Area()}");
            Console.WriteLine($"Perimeter = {tr1.Perimeter()}");
            if (tr1 == tr2) Console.WriteLine("TPTriangles are equals.");
            else Console.WriteLine("TPTriangles are'nt equals.");

            Console.ReadKey();
        }
    }
}
