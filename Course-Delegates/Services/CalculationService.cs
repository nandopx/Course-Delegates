namespace Course_Delegates.Services
{
    class CalculationService
    {
        public static void ShowMax(double x, double y)
        {
            double max = (x > y) ? x : y;
            System.Console.WriteLine(max);
        }

        public static void ShowSum(double x, double y)
        {
            System.Console.WriteLine(x + y);
        }

        public static double Square(double x)
        {
            return x * x;
        }
    }
}
