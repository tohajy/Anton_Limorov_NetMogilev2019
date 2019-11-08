using System;

namespace Task_2
{
    class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Task 2.A.");

            var sumThreeNumbers = GetSumThreeNumbers();

            Console.WriteLine($"Sum 3 numbers: {sumThreeNumbers}");
            Console.WriteLine("Task 2.B.");

            var sumTwoNumbers = GetSumTwoNumbers();

            Console.WriteLine($"Sum 2 numbers: {sumTwoNumbers}");
            Console.WriteLine("Task 2.C.");

            var sumThreeDouble = GetSumThreeDoubles();

            Console.WriteLine($"Sum 3 fractional numbers: {sumThreeDouble}");
            Console.WriteLine("Task 2.D.");

            var sumTwoStrings = GetSumTwoStrings();

            Console.WriteLine($"Sum 2 strings: {sumTwoStrings}");
            Console.WriteLine("Task 2.E.");
            Console.WriteLine("Enter the array size:");

            int arraySize;

            while (!int.TryParse(Console.ReadLine(), out arraySize))
            {
                Console.Write("Incorrect value. Try again: ");
            }

            Console.WriteLine("Enter the array size:");

            int arraySizeTwo;

            while (!int.TryParse(Console.ReadLine(), out arraySizeTwo))
            {
                Console.Write("Incorrect value. Try again: ");
            }

            var rnd = new Random();
            var sizeResult = arraySize <= arraySizeTwo ? arraySizeTwo : arraySize;
            var arrayFirst = new int[arraySize];
            var arraySecond = new int[arraySizeTwo];


            Console.WriteLine("Array 1:");

            for (var i = 0; i < arrayFirst.Length; i++)
            {
                arrayFirst[i] = rnd.Next(-100, 100);
                Console.Write(arrayFirst[i] + " ");
            }

            Console.WriteLine();
            Console.WriteLine("Array 2:");

            for (var i = 0; i < arraySecond.Length; i++)
            {
                arraySecond[i] = rnd.Next(-100, 100);
                Console.Write(arraySecond[i] + " ");
            }

            GetSumTwoArrays(arrayFirst, arraySecond, sizeResult);

            Console.ReadLine();
        }

        private static int GetSumThreeNumbers()
        {
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

            var sum = x + y + z;
            return sum;
        }

        private static int GetSumTwoNumbers()
        {
            int x;
            int y;

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

            var sum = x + y;
            return sum;
        }

        private static double GetSumThreeDoubles()
        {
            double x;
            double y;
            double z;

            Console.WriteLine("Enter the first number:");

            while (!double.TryParse(Console.ReadLine(), out x))
            {
                Console.Write("Incorrect value. Try again: ");
            }

            Console.WriteLine("Enter the second number::");

            while (!double.TryParse(Console.ReadLine(), out y))
            {
                Console.Write("Incorrect value. Try again: ");
            }

            Console.WriteLine("Enter the third number:");

            while (!double.TryParse(Console.ReadLine(), out z))
            {
                Console.Write("Incorrect value. Try again: ");
            }

            var sum = x + y + z;
            return sum;
        }

        private static string GetSumTwoStrings()
        {
            Console.WriteLine("Enter the first string:");

            var firstStringLine = Console.ReadLine();

            Console.WriteLine("Enter the second string:");

            var secondStringLine = Console.ReadLine();
            var sum = firstStringLine + secondStringLine;

            return sum;
        }

        private static void GetSumTwoArrays(int[] arr1, int[] arr2, int size)
        {
            var array3 = new int[size];

            for (var i = 0; i < ((arr1.Length < arr2.Length) ? arr1.Length : arr2.Length); i++)
            {
                array3[i] = arr1[i] + arr2[i];
            }

            for (var i = ((arr1.Length < arr2.Length) ? arr1.Length : arr2.Length); i < array3.Length; i++)
            {
                array3[i] = ((arr1.Length < arr2.Length) ? arr2[i] : arr1[i]);
            }

            Console.WriteLine();
            Console.WriteLine("Modified Array: ");

            for (var i = 0; i < array3.Length; i++)
            {
                Console.Write(array3[i] + "   ");
            }
        }
    }
}
