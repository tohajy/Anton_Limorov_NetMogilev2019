using System;

namespace Task_8_2
{
    class Program
    {
        struct Filling
        {
            public int i;
            public int j;
        }

        static void Main(string[] args)
        {
            int n;

            Console.Write("Введите n: ");

            while (!int.TryParse(Console.ReadLine(), out n))
            {
                Console.Write("Введённое вами значение некорректное. Попробуйте ещё раз: ");
            }

            int[,] array = new int[n, n];
            Filling spiral = new Filling() { i = 0, j = 1 };
            int count = 0;

            int i = 0, j = 0;

            while (count < n * n)
            {
                while ((i < n) && (i >= 0) && (j < n) && (j >= 0))
                {
                    if (array[i, j] == 0)
                    {
                        count++;
                        array[i, j] = count;
                        i += spiral.i;
                        j += spiral.j;
                    }
                    else
                    {
                        if (count == n * n) break;
                        i -= spiral.i;
                        j -= spiral.j;
                        ClockwiseFilling(ref spiral);
                        i += spiral.i;
                        j += spiral.j;
                    }
                }

                if (i < 0) i = 0;
                if (i >= n) i = n - 1;
                if (j < 0) j = 0;
                if (j >= n) j = n - 1;
                ClockwiseFilling(ref spiral);
                i += spiral.i;
                j += spiral.j;
            }

            Console.WriteLine("Массив:");

            for (i = 0; i < n; i++)
            {
                for (j = 0; j < n; j++)
                {
                    Console.Write("{0:00} ", array[i, j]);
                }

                Console.WriteLine();
            }

            Console.ReadLine();
        }

        static void ClockwiseFilling(ref Filling spiral)
        {
            switch (spiral.i)
            {
                case -1:
                    spiral.i = 0;
                    spiral.j = 1;
                    break;
                case 1:
                    spiral.i = 0;
                    spiral.j = -1;
                    break;
                case 0:
                    if (spiral.j > 0)
                    {
                        spiral.i = 1;
                        spiral.j = 0;
                    }
                    else
                    {
                        spiral.i = -1;
                        spiral.j = 0;
                    }
                    break;
            }
        }
    }
}
