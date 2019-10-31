using System;

namespace Task_8_1
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = -2;
            double b;
            double c;
            double step = 0.1;
            const double prec = 0.0001;

            b = FuncMaxB(a, step);

            do
            {
                c = (a + b) / 2;
                FuncSignRepl(ref a, ref b, c);

                if (FunctionX(c) == 0)
                {
                    break;
                }

                Console.WriteLine(a + " / " + b + " / " + c);
            }
            while ((Math.Abs(b - a) > prec));

            Console.WriteLine(" Ответ: x= " + c);
            Console.ReadKey();
        }

        public static double FunctionX(double x)
        {
            return Math.Sqrt(Math.PI / 2) * Math.Pow(Math.E, 0.6 * x) + x / (x * x + 0.3);
        }

        public static double FuncMaxB(double a, double step)
        {
            double b = a + step;

            while (FunctionX(a) * FunctionX(b) > 0)
            {
                b += step;
            };

            return b;
        }

        public static void FuncSignRepl(ref double a, ref double b, double c)
        {
            if (FunctionX(a) * FunctionX(c) > 0)
            {
                a = c;
            };

            if (FunctionX(b) * FunctionX(c) > 0)
            {
                b = c;
            };
        }
    }
}
