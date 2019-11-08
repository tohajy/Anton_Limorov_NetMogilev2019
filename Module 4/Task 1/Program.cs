using System;
using System.Linq;

namespace Task_1
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int arraySize;

            Console.WriteLine("Array size:");

            while (!int.TryParse(Console.ReadLine(), out arraySize))
            {
                Console.Write("Incorrect value. Try again: ");
            }

            var rnd = new Random();
            var array = new int[arraySize];

            Console.WriteLine("Array:");

            for (var i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(-100, 100);
                Console.Write(array[i] + " ");
            }

            var max = GetMaxValue(array);
            var min = GetMinValue(array);
            var sumArr = GetSum(array);
            var difArr = GetDifferenceMaxMin(array);

            GetModifyArray(array);

            Console.WriteLine();
            Console.WriteLine($"Max value - ({max})");
            Console.WriteLine($"Min value - ({min})");
            Console.WriteLine($"Sum  - ({sumArr})");
            Console.WriteLine($"Difference between Max and Min  - ({difArr})");
            Console.WriteLine("Modified Array: ");

            for (var i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }

            Console.ReadLine();
        }

        private static int GetMaxValue(int[] arr)
        {
            var maxValue = arr[0];
            maxValue = arr.Concat(new[] { maxValue }).Max();
            return maxValue;
        }

        private static int GetMinValue(int[] arr)
        {
            var minValue = arr[0];
            minValue = arr.Concat(new[] { minValue }).Min();
            return minValue;
        }

        private static int GetSum(int[] arr)
        {
            var sum = arr.Sum();
            return sum;
        }

        private static int GetDifferenceMaxMin(int[] arr)
        {
            var maxValue = arr[0];
            var minValue = arr[0];

            maxValue = arr.Concat(new[] { maxValue }).Max();
            minValue = arr.Concat(new[] { minValue }).Min();

            var dif = maxValue - minValue;

            return dif;
        }

        private static void GetModifyArray(int[] arr)
        {
            var maxValue = arr[0];
            var minValue = arr[0];

            maxValue = arr.Concat(new[] { maxValue }).Max();
            minValue = arr.Concat(new[] { minValue }).Min();

            for (var i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    arr[i] += maxValue;
                }
                else
                {
                    arr[i] -= minValue;
                }
            }
        }
    }
}
