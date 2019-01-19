using System;
namespace Mod3_Lab1
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int result = MethodOverloading.Sum(20, 40);
            Console.WriteLine($"Calling Sum() with two arguments, result is: {result}");
            int result3 = MethodOverloading.Sum(10, 50, 80);
            Console.WriteLine($"Calling Sum() with three arguments, result is: {result3}");
            double dblResult = MethodOverloading.Sum(20.5, 30.6);
            Console.WriteLine($"Calling Sum() that takes doubles result in: {dblResult}");
        }
    }
}
