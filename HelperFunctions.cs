using System;
using System.ComponentModel;

namespace Utility
{
    internal class HelperFunctions
    {
        public static int Factorial(int n)
        {
            if(n < 0)
            {
                Factorial(Math.Abs(n));
            }

            return n == 0 ? 1 : n * Factorial(n - 1);
        }

        public static void Swap(ref double a, ref double b)
        {
            double c = a;
            a = b;
            b = c;
        }

        public static bool CheckInput(ref double inputData, double correctData, string message)
        {
            while(!(Math.Abs(inputData) - correctData <= 0.000001))
            {
                Console.WriteLine(message);
                double.TryParse(Console.ReadLine(), out inputData);
            }
            return true;
        }

        public static bool CheckInput(ref double inputData, int lowerBound, int upperBound, string message)
        {
            while(!(inputData > lowerBound && inputData < upperBound))
            {
                Console.WriteLine(message);
                double.TryParse(Console.ReadLine(), out inputData);
            }
            return true;
        }

        public static bool CheckInput(string inputData, string correctData, string message)
        {
            while(!correctData.Equals(inputData))
            {
                Console.WriteLine(message);
                inputData = Console.ReadLine();
            }

            return true;
        }

        public static bool CheckInput(string inputData, string firstCorrectData, string secondCorrectData, string message)
        {
            while(!(firstCorrectData.Equals(inputData) || secondCorrectData.Equals(inputData)))
            {
                Console.WriteLine(message);
                inputData = Console.ReadLine();
            }
            return true;
        }
    }
}
