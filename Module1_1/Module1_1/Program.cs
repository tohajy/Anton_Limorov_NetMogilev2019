using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module1_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 1, b = 2, temp;
            temp = a;
            a = b;
            b = temp;
            Console.WriteLine("a: " + a);
            Console.WriteLine("b: " + b);
        }
    }
}
