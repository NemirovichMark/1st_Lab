using System;

namespace LaboratoryL1N9
{
    class Program
    {
        static void Main(string[] args)
        {
            double sum = 0;
            double a = 1.00;
            int Factorial = 1;

            for (int i = 1; i <= 3; i++)
            {
                Factorial *= i;
                a = Math.Pow(-1, i) * Math.Pow(5, i) / Factorial;
                sum += a;
            }
            Console.WriteLine($"Answer: {sum}");
        }
    }
}
