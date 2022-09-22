using System;

namespace LaboratoryL1N15
{
    class Program
    {
        static int numerator(int n)
        {
            if (n == 1)
            {
                return 1;
            }
            if (n == 2)
            {
                return 2;
            }
            else
            {
                return (numerator(n-1) + numerator(n-2));
            }
        }

        static double denominator(int n)
        {
            if (n == 1)
            {
                return 1;
            }
            if (n == 2)
            {
                return 1;
            }
            else
            {
                return (denominator(n-1) + denominator(n-2));
            }
        }
        static void Main(string[] args)
        {
            double answer = (numerator(5) / denominator(5));
            Console.WriteLine($"Answer: {answer}");
        }
    }
}
