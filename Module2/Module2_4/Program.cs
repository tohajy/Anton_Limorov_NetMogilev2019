using System;

namespace Module2_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Выберите фигуру для расчета. 3 - треугольник, 4 - прямоугольник, 0 - круг.");
            string selection = Console.ReadLine();

            switch (selection)
            {
                case "3":
                    Console.WriteLine("Введите катет 1:");
                    Formulas.fCathetus = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Введите катет 2:");
                    Formulas.sCathetus = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Что будем считать? s - площадь, p - периметр.");

                    string taskTriangle = Console.ReadLine();

                    if (taskTriangle == "s")
                    {
                        Formulas.SquareTriangle(Formulas.fCathetus, Formulas.sCathetus);
                    }
                    else if (taskTriangle == "p")
                    {
                        Formulas.PerimeterTriangle(Formulas.fCathetus, Formulas.sCathetus);
                    }

                    break;

                case "4":
                    Console.Write("Введите первую сторону прямоугольника: ");
                    Formulas.a = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Введите вторую сторону прямоугольника: ");
                    Formulas.b = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Что будем считать? s - площадь, p - периметр.");

                    string taskRectangle = Console.ReadLine();

                    if (taskRectangle == "s")
                    {
                        Formulas.SquareRectangle(Formulas.a, Formulas.b);
                    }
                    else if (taskRectangle == "p")
                    {
                        Formulas.PerimeterRectangle(Formulas.a, Formulas.b);
                    }

                    break;

                case "0":
                    Console.Write("Введите радиус круга: ");
                    Formulas.radius = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Что будем считать? s - площадь, p - периметр.");

                    string taskCircle = Console.ReadLine();

                    if (taskCircle == "s")
                    {
                        Formulas.SquareCircle(Formulas.radius);
                    }
                    else if (taskCircle == "p")
                    {
                        Formulas.PerimeterCircle(Formulas.radius);
                    }

                    break;

                default:
                    Console.WriteLine("Вы нажали неизвестную букву");
                    break;
            }

            Console.ReadLine();
        }
    }

    class Formulas
    {
        public static double a;
        public static double b;
        public static double fCathetus;
        public static double sCathetus;
        public static double radius;

        public static void SquareTriangle(double firstcatet, double secondcatet)
        {
            double S = fCathetus * sCathetus / 2;

            Console.WriteLine("Площадь треугольника = {0}", S);

            double pSquare = 4 * Math.Sqrt(S);
            double pCircle = Math.Sqrt(4 * Math.PI * S);

            Console.WriteLine($"При заданной площади ({S}) периметр квадрата = {pSquare}");
            Console.WriteLine($"При заданной площади ({S}) периметр круга = {pCircle}");
        }
        public static void PerimeterTriangle(double firstcatet, double secondcatet)
        {
            double P = fCathetus + sCathetus + Math.Sqrt(fCathetus * fCathetus + sCathetus * sCathetus);

            Console.WriteLine("Периметр треугольника = {0}", P);

            double sSquare = P * P / 16;
            double sCircle = P * P / (4 * Math.PI);

            Console.WriteLine($"При заданном периметре ({P}) площадь квадрата = {sSquare}");
            Console.WriteLine($"При заданной площади ({P}) площадь круга = {sCircle}");
        }
        public static void SquareRectangle(double aside, double bside)
        {
            double S = a * b;

            Console.WriteLine("Площадь прямоугольника = {0}", S);

            double pTriangle = Math.Sqrt(2 * S)+ Math.Sqrt(2 * S) + Math.Sqrt(4 * S);
            double pCircle = Math.Sqrt(4 * Math.PI * S);

            Console.WriteLine($"При заданной площади ({S}) периметр треугольника = {pTriangle}");
            Console.WriteLine($"При заданной площади ({S}) периметр круга = {pCircle}");
        }
        public static void PerimeterRectangle(double aside, double bside)
        {
            double P = 2*(a+b);

            Console.WriteLine("Периметр прямоугольника = {0}", P);

            double sTriangle = P * P / 18;
            double sCircle = P * P / (4 * Math.PI);

            Console.WriteLine($"При заданном периметре ({P}) площадь равностороннего треугольника = {sTriangle}");
            Console.WriteLine($"При заданной площади ({P}) площадь круга = {sCircle}");
        }
        public static void SquareCircle(double rad)
        {
            double S = Math.PI * radius * radius;

            Console.WriteLine("Площадь круга = {0}", S);

            double pTriangle = Math.Sqrt(2 * S) + Math.Sqrt(2 * S) + Math.Sqrt(4 * S);
            double pSquare = 4 * Math.Sqrt(S);

            Console.WriteLine($"При заданной площади ({S}) периметр треугольника = {pTriangle}");
            Console.WriteLine($"При заданной площади ({S}) периметр квадрата = {pSquare}");
        }
        public static void PerimeterCircle(double rad)
        {
            double P = 2 * Math.PI * radius;

            Console.WriteLine("Длина окружности = {0}", P);

            double sTriangle = P * P / 18;
            double sSquare = P * P / 16;

            Console.WriteLine($"При заданном периметре ({P}) площадь равностороннего треугольника = {sTriangle}");
            Console.WriteLine($"При заданной площади ({P}) площадь квадрата = {sSquare}");
        }
    }
}