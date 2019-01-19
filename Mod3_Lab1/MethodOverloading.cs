using System;
namespace Mod3_Lab1
{
    public static class MethodOverloading
    {
        public static void OverloadedMethods()
        {
            int result = Sum(20, 40);
            Console.WriteLine($"Calling Sum() with two arguments, result is: {result}");
            int result3 = Sum(10, 30, 50);
            Console.WriteLine($"Calling Sum() with three arguments, result is: {result3}");
            double dblResult = Sum(20.5, 30.6);
            Console.WriteLine($"Calling Sum() that takes doubles result in: {dblResult}");
        }
        public static int Sum(int first, int second)
        {
            int result = first + second;
            return result;
        }
        public static int Sum(int first, int second, int third)
        {
            int result = first + second + third;
            return result;
        }
        public static double Sum(double first, double second)
        {
            double result = first + second;
            return result;
        }
    }
}
