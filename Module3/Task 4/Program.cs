using System;

namespace Task_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int newNumber = 0;
            int number;
            int temp;

            Console.WriteLine("Введите число:");

            while (!int.TryParse(Console.ReadLine(), out number))
            {
                Console.Write("Введённое вами значение некорректное. Попробуйте ещё раз: ");
            }
            while (number != 0)
            {
                temp = number % 10;
                number = number / 10;
                newNumber = newNumber * 10 + temp;
            }
            Console.WriteLine("Преобразованное число: " + newNumber);
            Console.ReadLine();
        }
    }
}
