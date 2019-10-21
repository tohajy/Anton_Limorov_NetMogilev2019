using System;

namespace Module2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberCompanies = 0;
            double tax = 0;
            double profit = 500;
            double sumTaxes;
            bool condition = false;

            while (!condition)
            {
                Console.WriteLine("Введите число компаний:");
                condition = int.TryParse(Console.ReadLine(), out numberCompanies);
            }

            condition = false;
            while (!condition)
            {
                Console.WriteLine("Введите налог в %:");
                condition = double.TryParse(Console.ReadLine(), out tax);
            }

            sumTaxes = numberCompanies * profit * tax / 100;

            Console.WriteLine($"Сумма общих налогов: {sumTaxes} рублей");
            Console.ReadKey();
        }
    }
}
