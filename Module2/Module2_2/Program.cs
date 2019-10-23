using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите возраст:");

            int age;
            bool result = int.TryParse(Console.ReadLine(), out age);

            if (result == true)
            {
                if (age >= 18 && age % 2 == 0)
                {
                    Console.WriteLine("Поздравляем с совершеннолетием!");
                }
                else if (age < 18 && age > 13 && age % 2 != 0)
                {
                    Console.WriteLine("Поздравляем с переходом в старшую школу!");
                }
                else
                {
                    Console.WriteLine("Условия не выполнены. Поздравлений не предусмотрено. Нажмите любую кнопку для выхода.");
                }
            }
            else
            {
                Console.WriteLine("Введены не верные данные");
            }

            Console.ReadKey();
        }
    }
}
