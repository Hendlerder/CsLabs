using System;

namespace TPTriangle
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

        public static TPTriangle operator +(TPTriangle TPTriangle, double num) { return new TPTriangle(TPTriangle.I + num, TPTriangle.II + num); }

        public static TPTriangle operator -(TPTriangle TPTriangle, double num) { return new TPTriangle(TPTriangle.I - num, TPTriangle.II - num); }

        public static TPTriangle operator *(TPTriangle TPTriangle, double num) { return new TPTriangle(TPTriangle.I * num, TPTriangle.II * num); }
    }
}