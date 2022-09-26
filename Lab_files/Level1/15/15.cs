using System;

namespace LaboratoryL1N15
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] numerator = new double[5];
            double[] denominator = new double[5];
            numerator[0] = 1;
            numerator[1] = 2;
            denominator[0] = 1;
            denominator [1] = 1;
            for (int i = 2; i < 5; i++)
            {
                numerator[i] = numerator[i-1] + numerator[i-2];
                denominator[i] = denominator[i-1] + denominator[i-2];
            }
            double answer = (numerator[4] / denominator[4]);
            Console.WriteLine($"Answer: {answer}");
        }
    }
}
