namespace Mod3_Lab1
{
    public static class MethodOverloading
    {
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
