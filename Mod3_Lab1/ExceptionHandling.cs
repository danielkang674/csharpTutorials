using System;
namespace Mod3_Lab1
{
    public static class ExceptionHandling
    {
        public static void HandledExceptions()
        {
            Console.WriteLine("Enter your first number: ");
            int first = System.Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter your second number: ");
            int second = System.Int32.Parse(Console.ReadLine());
            Divide(first, second);
        }
        public static void Divide(int first, int second)
        {
            int result = 0;
            try
            {
                result = first / second;
                Console.WriteLine($"The result of diving {first} by {second} is {result}");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Cannot divide by zero, please provide a non-zero value for your second value");
                Console.WriteLine(ex.Message);
            }
        }
    }
}
