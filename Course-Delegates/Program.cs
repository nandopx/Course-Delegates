using Course_Delegates.Services;
using System;

namespace Course_Delegates
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = 10;
            double b = 12;
            double result = CalculationService.Sum(a, b);
            Console.WriteLine(result);
        }
    }
}
