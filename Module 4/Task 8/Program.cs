using System;

namespace Task_8_2
{
    class Program
    {
        static void Main(string[] args)
        {
            const double a = -1;
            const double b = 10;
            const double precision = 0.0001;

            var x = DivideInHalfFunction(a, b, precision);

            Console.WriteLine($"The solution to the equation is \n(x={x})");
            Console.ReadLine();
        }

        private static double GetFunc(double x)
        {
            return Math.Sqrt(Math.PI / 2) * Math.Pow(Math.E, 0.6 * x) + x / (x * x + 0.3);
        }

        private static double DivideInHalfFunction(double a, double b, double precision)
        {
            double с = (a + b) / 2;

            if ((Math.Abs(GetFunc(a) - GetFunc(b)) <= precision) || (Math.Abs(GetFunc(с)) <= precision))
            {
                return (a + b) / 2;
            }

            if (GetFunc(a) * GetFunc(с) <= 0.0)
            {
                return DivideInHalfFunction(a, с, precision);
            }

            return DivideInHalfFunction(с, b, precision);
        }
    }
}
