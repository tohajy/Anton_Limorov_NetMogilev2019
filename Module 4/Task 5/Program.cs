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
            var x = 0;
            var y = 0;

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
            MathOp(x, y, Operation.Add);
            Console.Write("Divide: ");
            MathOp(x, y, Operation.Divide);
            Console.Write("Multiply: ");
            MathOp(x, y, Operation.Multiply);
            Console.Write("Subtract: ");
            MathOp(x, y, Operation.Subtract);
            Console.ReadLine();
        }

        private static void MathOp(double x, double y, Operation op)
        {
            var result = 0.0;

            switch (op)
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
                    throw new ArgumentOutOfRangeException(nameof(op), op, null);
            }

            Console.WriteLine(result);
        }

    }
}