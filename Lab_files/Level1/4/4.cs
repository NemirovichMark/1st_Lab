using System;

namespace LaboratoryL1N4
{
    class Program
    {
        static int Main(string[] args)
        {
            double sum = 0;

            Console.Write("Input: ");
            string input = Console.ReadLine();
            bool result = float.TryParse(input, out var x);
            if (result == false)
            {
                Console.WriteLine("Incorrect data");
                return 1;
            }
            
            double a = Math.Cos(x);
            for (int i = 2; i < 10; i++)
            {
                sum = sum + a;
                a = Math.Cos(i * x) / Math.Pow(x, (i-1));
            }
            Console.WriteLine($"Answer: {sum}");
            return 0;
        }
    }
}
