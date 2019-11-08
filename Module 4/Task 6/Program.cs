using System;

namespace Task_6
{
    class Program
    {
        static void Main(string[] args)
        {
            var array = new int[10];
            var rnd = new Random();

            Console.WriteLine("Array:");

            for (var i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(-50, 50);
                Console.Write(array[i] + " ");
            }

            IncrementArray(array);

            Console.WriteLine("\nNew Array (each item + 5):");

            foreach (var item in array)
            {
                Console.Write(item + " ");
            }

            Console.ReadLine();
        }

        private static void IncrementArray(int[] array)
        {
            for (var i = 0; i < array.Length; i++)
            {
                array[i] += 5;
            }
        }
    }
}
