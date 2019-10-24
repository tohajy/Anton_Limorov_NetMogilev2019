using System;

namespace Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int nElements;

            while (true)
            {
                Console.Write("Введите N: ");

                if (int.TryParse(Console.ReadLine(), out nElements) && nElements >= 2)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Указано некорректное число");
                }
                Console.ReadKey();
            }
            Console.Write("Ряд Фибоначчи, состоящий из {0} элементов: ", nElements);

            var fibonacci = new ulong[nElements];
            fibonacci[0] = 1;
            fibonacci[1] = 1;

            for (int i = 2; i < nElements; i++)
            {
                fibonacci[i] = fibonacci[i - 1] + fibonacci[i - 2];
            }

            foreach (var i in fibonacci)
            {
                Console.Write(i + " ");
            }
            Console.ReadLine();
        }
    }
}
