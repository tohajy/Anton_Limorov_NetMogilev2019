using System;
using System.Globalization;

namespace Module2_3
{
    class Program
    {
        static void Main(string[] args)
        {
            double numberA;
            double numberB;

            do
            {
                Console.Write("Введите число а: ");
            }
            while (!double.TryParse(Console.ReadLine().Replace(",", "."),
                    NumberStyles.AllowDecimalPoint, NumberFormatInfo.InvariantInfo, out numberA));
            
            do
            {
                Console.Write("Введите число b: ");
            }
            while (!double.TryParse(Console.ReadLine().Replace(",", "."),
                    NumberStyles.AllowDecimalPoint, NumberFormatInfo.InvariantInfo, out numberB));

            double temp = numberA;
            numberA = numberB;
            numberB = temp;

            Console.WriteLine($"Число а изменено на:{numberA}, Число b изменено на: {numberB}");
            Console.ReadKey();

        }
    }
}
