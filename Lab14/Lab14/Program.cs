using System;

namespace Lab14
{
    class Program
    {
        public abstract class Body
        {
            private protected int data;
            public int Data
            {
                get { return data; }
                set
                {
                    if (value < 0) throw new Exception("Cannot be negative");
                    data = value;
                }
            }
            public Body(int data) { Data = data; }

            public abstract double Perimetr();

            public abstract double Area();
        }

        class RightTriangle : Body
        {
            private int a;
            private int b;
            public int A
            {
                get { return a; }
                set
                {
                    if (value < 0) throw new Exception("Cannot be negative");
                    a = value;
                }
            }

            public int B
            {
                get { return b; }
                set
                {
                    if (value < 0) throw new Exception("Cannot be negative");
                    b = value;
                }
            }

            public RightTriangle(int a, int b, int side) : base(side)
            {
                A = a;
                B = b;
            }

            public override double Perimetr() { return a + b + Math.Pow(Math.Pow(a, 2) + Math.Pow(b, 2), 1 / 2); }

            public override double Area() { return a * b / 2; }

            public override string ToString() { return $"RightTriangle: Cathetuses = {a}, {b}"; }
        }
        class EquilateralTriangle : Body
        {
            private int a;
            public int A
            {
                get { return a; }
                set
                {
                    if (value < 0) throw new Exception("Cannot be negative");
                    a = value;
                }
            }

            public EquilateralTriangle(int a, int side) : base(side) { A = a; }

            public override double Perimetr() { return a * 3; }

            public override double Area() { return Math.Pow(3, 1/2) * Math.Pow(a, 2) / 4; }

            public override string ToString() { return $"EquilateralTriangle: Side = {a}"; }
        }
        class IsoscelesTriangle : Body
        {
            private int a;
            private int b;
            public int A
            {
                get { return a; }
                set
                {
                    if (value < 0) throw new Exception("Cannot be negative");
                    a = value;
                }
            }

            public int B
            {
                get { return b; }
                set
                {
                    if (value < 0) throw new Exception("Cannot be negative");
                    b = value;
                }
            }

            public IsoscelesTriangle(int a, int b, int side) : base(side)
            {
                A = a;
                B = b;
            }

            public override double Perimetr() { return a + b * 2; }

            public override double Area() { return a * Math.Pow(Math.Pow(b, 2) - Math.Pow(a / 2, 2), 1 / 2) / 2; }

            public override string ToString() { return $"IsoscelesTriangle: Sides = {a}, {b}, {b}"; }
        }



        static void Main(string[] args)
        {
            try
            {
                Console.Write("Enter the amount of figures: "); int n = Convert.ToInt32(Console.ReadLine());

                Body[] I = new Body[n]; Random rnd = new Random(DateTime.Now.Millisecond);
                Body[] II = new Body[n]; Random rnd = new Random(DateTime.Now.Millisecond);

                for (int i = 0; i < figures.Length; i++)
                {
                    switch (rnd.Next(1, 4))
                    {
                        case 1:
                            I[i] = new RightTriangle(rnd.Next(1, 10), rnd.Next(1, 10), rnd.Next(1, 10));
                            break;
                        case 2:
                            I[i] = new EquilateralTriangle(rnd.Next(1, 10), rnd.Next(1, 10));
                            break;
                        case 3:
                            II[i] = new IsoscelesTriangle(rnd.Next(1, 10), rnd.Next(1, 10), rnd.Next(1, 10));
                            break;
                    }
                }
                for (int i = 0; i < I.Length; i++) { Console.WriteLine(I[i]); }
                for (int i = 0; i < II.Length; i++) { Console.WriteLine(II[i]); }

                double res = 0;
                for (int i = 0; i < I.Length; i++) { res += I[i].Area(); }
                double ult = 0;
                for (int i = 0; i < II.Length; i++) { ult += II[i].Perimetr(); }
                Console.WriteLine(" ");
                Console.WriteLine($"Sum of RightTriangles and EquilateralTriangles areas = {res}");
                Console.WriteLine(" ");
                Console.WriteLine($"Sum of IsoscelesTriangles perimeters = {ult}");
            }
            catch { Console.WriteLine("Cannot be negative"); }
        }
    }
}
    
