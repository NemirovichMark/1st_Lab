using System;

namespace LaboratoryL1N9
{
    class Program
    {
        static int Factorial(int f)
        {
            if (f == 0)
            {
                return 1;
            }
            else
            {
                return f * Factorial(f-1); 
            }
        }
        static void Main(string[] args)
        {
            double sum = 0;
            double a = 1.00;

            for (int i = 1; i <= 3; i++)
            {
                
                a = Math.Pow(-1, i) * Math.Pow(5, i) / Factorial(i);
                sum += a;
            }
            Console.WriteLine($"Answer: {sum}");
        }
    }
}
