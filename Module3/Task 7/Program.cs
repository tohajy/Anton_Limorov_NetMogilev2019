using System;

namespace Task_7
{
    class Program
    {
        static void Main(string[] args)
        {
            int arraySize = 0;

            while (true)
            {
                Console.Write("Введите количество элементов массива: ");

                try
                {
                    arraySize = int.Parse(Console.ReadLine());

                    if (arraySize <= 0)
                    {
                        Console.WriteLine("Значение должно быть больше нуля, повторите ввод");
                        continue;
                    }
                    else
                    {
                        break;
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Недопустимое значение, повторите ввод");
                    continue;
                }
            }

            Random rnd = new Random();
            int[] array = new int[arraySize];

            Console.WriteLine("Исходный массив");

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(-10, 10);
                Console.Write(array[i] + " ");
            }

            Console.WriteLine();
            Console.WriteLine("Числа, больше предыдущих в ряду:");

            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > array[i - 1])
                {
                    Console.Write(array[i] + " ");
                }
            }

            Console.ReadLine();
        }
    }
}
