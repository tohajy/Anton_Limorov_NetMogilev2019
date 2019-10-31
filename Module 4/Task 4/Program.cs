using System;
using System.Linq;

namespace Task_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Task 4.A.");

            var (numberX, numberY, numberZ) = ModifyNumbers();

            Console.WriteLine($"Modified numbers: {numberX}, {numberY}, {numberZ}");
            Console.WriteLine("Task 4.B.");

            var (area, perimeter) = GetAreaPerimeter();

            Console.WriteLine($"Circle area - {area}, perimeter - {perimeter}");
            Console.WriteLine("Task 4.C.");

            var (maxValue, minValue, sum) = GetMaxMinValue();

            Console.WriteLine();
            Console.WriteLine($"Max value - ({maxValue})");
            Console.WriteLine($"Min value - ({minValue})");
            Console.WriteLine($"Sum  - ({sum})");
            Console.ReadLine();
        }

        private static (int, int, int) ModifyNumbers()
        {
            var x = 0;
            var y = 0;
            var z = 0;

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

            var result = (x + 10, y + 10, z + 10);
            return result;
        }

        private static (double, double) GetAreaPerimeter()
        {
            var radius = 0;

            Console.WriteLine("Enter the radius:");

            while (!int.TryParse(Console.ReadLine(), out radius))
            {
                Console.Write("Incorrect value. Try again: ");
            }

            var result = (Math.PI * radius * radius, 2 * Math.PI * radius);
            return result;
        }

        private static (int, int, int) GetMaxMinValue()
        {
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
