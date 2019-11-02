using System;

namespace Task_5_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int month;
            int year;

            Console.WriteLine("Enter the month number(1-12):");

            while (!int.TryParse(Console.ReadLine(), out month) || month < 1 || month >12 )
            {
                Console.Write("Incorrect value. Try again: ");
            }

            Console.WriteLine("Enter the year");

            while (!int.TryParse(Console.ReadLine(), out year) || year < 1)
            {
                Console.Write("Incorrect value. Try again: ");
            }

            int days = GetDaysMonth(year, month);

            Console.Write($"There are {days} in this month.");
            Console.ReadLine();
        }

        private static int GetDaysMonth(int year, int month)
        {
            return DateTime.DaysInMonth(year, month);
        }
    }
}
