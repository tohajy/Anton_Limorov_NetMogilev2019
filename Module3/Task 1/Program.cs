using System;

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber;
            int secondNumber;
            Console.Write("Введите первое число: ");

            while (!int.TryParse(Console.ReadLine(), out firstNumber))
            {
                Console.Write("Введённое вами значение некорректное. Попробуйте ещё раз: ");
            }
            Console.Write("Введите второе число: ");

            while (!int.TryParse(Console.ReadLine(), out secondNumber))
            {
                Console.Write("Введённое вами значение некорректное. Попробуйте ещё раз: ");
            }
            Console.WriteLine("Результат: ");
            Console.WriteLine(Multiply(firstNumber, secondNumber));
            Console.ReadKey();
        }
        public static int Multiply(int firstnumb, int secondnumb)
        {
            int result = 0;
            int fModule = Math.Abs(firstnumb);
            int sModule = Math.Abs(secondnumb);

            for (int i = 0; i < fModule; i++)
            {
                result += sModule;
            }
            return (firstnumb < 0 ^ secondnumb < 0) ? -result : result;
        }
    }
}
