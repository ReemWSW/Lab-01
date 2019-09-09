using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab01
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10, b = 20, x = 5, y = 2;

            Console.WriteLine($"a = {a}, b = {b}, x = {x}, y = {y}");
            Console.WriteLine($"a + b = {a + b}");
            Console.WriteLine($"x - b = {x - b}");
            Console.WriteLine($"x * b = {x * b}");
            Console.WriteLine($"y / a = {y / a}");
            Console.WriteLine($"b % y = {b % y}");
            Console.WriteLine($"y + 10 % x = {y + 10 % x}");
            Console.WriteLine($"a / 3 * 5 = {a / 3 * 5}");
            Console.WriteLine($"9 / 2 * a = {9 / 2 * a}");
            Console.WriteLine($"y % 8 = {y % 8}");
            Console.WriteLine($"100 * x + y % 2 - a = {100 * x + y % 2 - a}");

        }
    }
}
