using System;

namespace Task_5
{
    class Program
    {
        private enum Operation
        {
            Add = 1,
            Subtract,
            Multiply,
            Divide
        }
        static void Main(string[] args)
        {
            int x;
            int y;

            Console.WriteLine("Enter the first number:");

            while (!int.TryParse(Console.ReadLine(), out x))
            {
                Console.Write("Incorrect value. Try again: ");
            }

            Console.WriteLine("Enter the second number::");

            while (!int.TryParse(Console.ReadLine(), out y))
            {
                Console.Write("Incorrect value. Try again: ");
            }


            Console.Write("Addition: ");
            MathOperation(x, y, Operation.Add);
            Console.Write("Divide: ");
            MathOperation(x, y, Operation.Divide);
            Console.Write("Multiply: ");
            MathOperation(x, y, Operation.Multiply);
            Console.Write("Subtract: ");
            MathOperation(x, y, Operation.Subtract);
            Console.ReadLine();
        }

        private static void MathOperation(double x, double y, Operation type)
        {
            var result = 0.0;

            switch (type)
            {
                case Operation.Add:
                    result = x + y;
                    break;
                case Operation.Subtract:
                    result = x - y;
                    break;
                case Operation.Multiply:
                    result = x * y;
                    break;
                case Operation.Divide:
                    result = x / y;
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(type), type, null);
            }

            Console.WriteLine(result);
        }

    }
}