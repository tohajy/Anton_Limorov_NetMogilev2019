using System;

namespace Task_7
{
    class Program
    {
        static void Main(string[] args)
        {
            var random = new Random();
            var array = new int[10];

            for (var i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(0, 100);
            }

            Console.WriteLine("Original array:");

            foreach (var item in array)
            {
                Console.Write(item + " ");
            }

            int direction = 1;

            GetSortArray(array, direction);

            Console.WriteLine("\nSorted array by ascending:");

            foreach (var item in array)
            {
                Console.Write(item + " ");
            }

            direction = -1;

            GetSortArray(array, direction);

            Console.WriteLine("\nSorted array by descending:");

            foreach (var item in array)
            {
                Console.Write(item + " ");
            }

            Console.ReadLine();
        }

        private static void GetSortArray(int[] arr, int dir)
        {
            for (var j = 0; j < arr.Length; j++)
                for (var i = 0; i < arr.Length - 1; i++)
                {
                    if (arr[i] * dir > arr[i + 1] * dir)
                    {
                        int temp = arr[i];
                        arr[i] = arr[i + 1];
                        arr[i + 1] = temp;
                    }
                }
        }
    }
}
