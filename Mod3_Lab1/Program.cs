using System;

namespace Mod3_Lab1
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int result = Sum(20, 40);
            Console.WriteLine($"Calling Sum() with two arguments, result is: {result}");
            int result3 = Sum(10, 50, 80);
            Console.WriteLine($"Calling Sum() with three arguments, result is: {result3}");
            double dblResult = Sum(20.5, 30.6);
            Console.WriteLine($"Calling Sum() that takes doubles result in: {dblResult}");
        }
        static int Sum(int first, int second)
        {
            int sum = first + second;
            return sum;
        }
        static int Sum(int first, int second, int third)
        {
            int sum = first + second + third;
            return sum;
        }
        static double Sum(double first, double second)
        {
            double sum = first + second;
            return sum;
        }

    }
}
