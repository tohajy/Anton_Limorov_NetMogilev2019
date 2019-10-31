using System;

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int nNumber;

            Console.Write("Введите число N: ");

            while (!int.TryParse(Console.ReadLine(), out nNumber))
            {
                Console.Write("Введённое вами значение некорректное. Попробуйте ещё раз: ");
            }

            int i = 1;
            int k = 1;

            Console.Write("Первые {0} четных чисел: ", nNumber);

            while (true)
            {
                if (i % 2 == 0)
                {
                    Console.Write(i + " ");
                    k++;
                }
                if (k > nNumber)
                {
                    break;
                }
                i++;
            }
            Console.ReadKey();
        }
    }
}
