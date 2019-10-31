using System;

namespace Task_5_2
{
    class Program
    {
        enum Months
        {
            January = 31,
            February = 28,
            March = 31,
            April = 30,
            May = 31,
            June = 30,
            July = 31,
            August = 31,
            September = 30,
            October = 31,
            November = 30,
            December = 31
        }
        static void Main(string[] args)
        {
            var x = 0;

            Console.WriteLine("Enter the month number(1-12):");

            while (!int.TryParse(Console.ReadLine(), out x))
            {
                Console.Write("Incorrect value. Try again: ");
            }

            GetMonth(x);

            Console.ReadLine();
        }

        private static void GetMonth(int x)
        {
            Months month;

            switch (x)
            {
                case 1:
                    month = Months.January;
                    Console.WriteLine($"There are {(int)month} days in January");

                    break;

                case 2:
                    var year = 0;
                    Console.WriteLine("This is a leap year? 1 - yes, 0 - no");

                    while (!int.TryParse(Console.ReadLine(), out year))
                    {
                        Console.Write("Incorrect value. Try again: ");
                    }

                    switch (year)
                    {
                        case 1:
                            Console.WriteLine("There are 29 days in February");
                            break;
                        case 0:
                            month = Months.February;
                            Console.WriteLine($"There are {(int)month} days in {month}");
                            break;
                    }

                    break;

                case 3:
                    month = Months.March;
                    Console.WriteLine($"There are {(int)month} days in March");

                    break;

                case 4:
                    month = Months.April;
                    Console.WriteLine($"There are {(int)month} days in April");

                    break;

                case 5:
                    month = Months.May;
                    Console.WriteLine($"There are {(int)month} days in May");

                    break;

                case 6:
                    month = Months.June;
                    Console.WriteLine($"There are {(int)month} days in June");

                    break;

                case 7:
                    month = Months.July;
                    Console.WriteLine($"There are {(int)month} days in July");

                    break;

                case 8:
                    month = Months.August;
                    Console.WriteLine($"There are {(int)month} days in August");

                    break;

                case 9:
                    month = Months.September;
                    Console.WriteLine($"There are {(int)month} days in September");

                    break;

                case 10:
                    month = Months.October;
                    Console.WriteLine($"There are {(int)month} days in October");

                    break;

                case 11:
                    month = Months.November;
                    Console.WriteLine($"There are {(int)month} days in November");

                    break;

                case 12:
                    month = Months.December;
                    Console.WriteLine($"There are {(int)month} days in December");

                    break;
            }
        }
    }
}
