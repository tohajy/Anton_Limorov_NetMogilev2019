using System;
using System.Linq;

namespace Task_3
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var x = 0;
            var y = 0;
            var z = 0;

            Console.WriteLine("Task 3.A.");
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

            Console.WriteLine("Enter the third number:");

            while (!int.TryParse(Console.ReadLine(), out z))
            {
                Console.Write("Incorrect value. Try again: ");
            }

            ModifyNumbers(ref x, ref y, ref z);

            Console.WriteLine($"Modified numbers: {x}, {y}, {z}");
            Console.WriteLine("Task 3.B.");
            Console.WriteLine("Enter the radius:");

            var radius = 0;

            while (!int.TryParse(Console.ReadLine(), out radius))
            {
                Console.Write("Incorrect value. Try again: ");
            }

            GetAreaPerimeter(ref radius, out var area, out var perimeter);

            Console.WriteLine($"Circle area - {area}, perimeter - {perimeter}");
            Console.WriteLine("Task 3.C.");
            Console.WriteLine("Enter the array size:");

            var arraySize = 0;

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

            GetMaxMinValue(out var maxValue, out var minValue, out var sum, array);

            Console.WriteLine();
            Console.WriteLine($"Max value - ({maxValue})");
            Console.WriteLine($"Min value - ({minValue})");
            Console.WriteLine($"Sum  - ({sum})");
            Console.ReadLine();
        }

        private static void ModifyNumbers(ref int x, ref int y, ref int z)
        {
            x += 10;
            y += 10;
            z += 10;
        }

        private static void GetAreaPerimeter(ref int rad, out double area, out double perimeter)
        {
            area = Math.PI * rad * rad;
            perimeter = 2 * Math.PI * rad;
        }

        private static void GetMaxMinValue(out int maxValue, out int minValue, out int sum, params int[] arr)
        {
            var maxV = arr[0];
            var minV = arr[0];
            maxValue = arr.Concat(new[] { maxV }).Max();
            minValue = arr.Concat(new[] { minV }).Min();
            sum = arr.Sum();
        }
    }
}
