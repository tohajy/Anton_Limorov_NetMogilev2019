using System;
using System.Linq;

namespace Task_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Task 4.A.");

            int x;
            int y;
            int z;

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
            var (numberX, numberY, numberZ) = ModifyNumbers(x, y, z);

            Console.WriteLine($"Modified numbers: {numberX}, {numberY}, {numberZ}");
            Console.WriteLine("Task 4.B.");

            int radius;

            Console.WriteLine("Enter the radius:");

            while (!int.TryParse(Console.ReadLine(), out radius))
            {
                Console.Write("Incorrect value. Try again: ");
            }
            var (area, perimeter) = GetAreaPerimeter(radius);

            Console.WriteLine($"Circle area - {area}, perimeter - {perimeter}");
            Console.WriteLine("Task 4.C.");
            Console.WriteLine("Enter the array size:");

            int arraySize;

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
            var (maxValue, minValue, sum) = GetMaxMinValue(array);

            Console.WriteLine();
            Console.WriteLine($"Max value - ({maxValue})");
            Console.WriteLine($"Min value - ({minValue})");
            Console.WriteLine($"Sum  - ({sum})");
            Console.ReadLine();
        }

        private static (int, int, int) ModifyNumbers(int x, int y, int z)
        {
            var result = (x + 10, y + 10, z + 10);
            return result;
        }

        private static (double, double) GetAreaPerimeter(int radius)
        {
            var result = (Math.PI * radius * radius, 2 * Math.PI * radius);
            return result;
        }

        private static (int, int, int) GetMaxMinValue(int[] array)
        {
            var maxV = array[0];
            var minV = array[0];

            maxV = array.Concat(new[] { maxV }).Max();
            minV = array.Concat(new[] { minV }).Min();

            var sum = array.Sum();
            var result = (maxV, minV, sum);
            return result;
        }
    }
}
