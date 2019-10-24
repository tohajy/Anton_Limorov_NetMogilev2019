using System;

namespace Task_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int temp = 0;
            int number;

            Console.WriteLine("введите число");

            while (!int.TryParse(Console.ReadLine(), out number))
            {
                Console.Write("Введённое вами значение некорректное. Попробуйте ещё раз: ");
            }
            Console.WriteLine("введите цифру, которую надо удалить");

            int deleteDigit;

            while (!int.TryParse(Console.ReadLine(), out deleteDigit))
            {
                Console.Write("Введённое вами значение некорректное. Попробуйте ещё раз: ");
            }

            while (number > 0)
            {
                if (number % 10 != deleteDigit)
                {
                    temp = temp * 10 + number % 10;
                }
                number /= 10;
            }

            while (temp > 0)
            {
                number = number * 10 + temp % 10;
                temp /= 10;
            }
            Console.WriteLine("Новое число:" + number);
            Console.ReadKey();
        }
    }
}
