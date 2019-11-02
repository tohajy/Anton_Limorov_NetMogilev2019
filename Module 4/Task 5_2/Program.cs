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

            days = GetDays(month, year);

            Console.Write($"\n(The second solution):\nThere are {days} in this month.");
            Console.ReadLine();
        }

        private static int GetDaysMonth(int year, int month)
        {
            return DateTime.DaysInMonth(year, month);
        }

        //one more method
        private static int GetDays(int month, int year = 2016)
        {
            if (month == 2)
            {
                return Math.Abs(year - 2012) % 4 == 0 ? 29 : 28;
            }

            if (month <= 7)
            {
                return month % 2 == 0 ? 30 : 31;
            }

            return month % 2 == 0 ? 31 : 30;
        }
    }
}
