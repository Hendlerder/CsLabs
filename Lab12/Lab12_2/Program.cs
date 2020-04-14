using System;

namespace Main
{
    class Program
    {
        class TFraction
        {
            private double num;
            private double ber;

            public double NUM
            {
                get { return num; }
                set
                {
                    if (num == 0) throw new Exception("It must be Float Number !");
                    num = value;
                }
            }
            public double BER
            {
                get { return ber; }
                set
                {
                    if (num == 0) throw new Exception("It must be Float Number !");
                    num = value;
                }
            }
            static void Main(string[] args)
            {
                try
                {
                    Console.Write("Float Number = "); double origin = Convert.ToDouble(Console.ReadLine());
                    double num = 0;
                    double ber = origin;

                    if (ber > 0) while (ber >= 1) { ber--; num++; }
                    else while (ber <= -1) { ber++; num--; }
                }
                catch { Console.WriteLine("It must be Float Number !"); }
            }
        }
    }
}
