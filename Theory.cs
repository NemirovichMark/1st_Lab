using System;

namespace _1st_Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Task 2
            double s = 1;
            for (int i = 2; i <= 10; i++)
                s += s/i;
            Console.WriteLine($"Task 2: {s}");
            #endregion

            #region Task 4
            string errorMessageWrongDataEndtered = "Entered data is wrong";

            int x = 0;
            s = 0;

            Console.Write("\nFor task 4 please enter x (x != 0): ");
            if (int.TryParse(Console.ReadLine(), out x))
            {
                if (x == 0)
                {
                    Console.WriteLine(errorMessageWrongDataEndtered);
                    return;
                }

                s = Math.Cos(x);
                double xPow = x;

                for (int i = 1; i <= 8; i++)
                {
                    s += Math.Cos((i + 1) * x) / xPow;
                    xPow *= x;
                }

                Console.WriteLine($"Task 4: {Math.Round(s, 3)}\n");
            }
            else
            {
                Console.WriteLine(errorMessageWrongDataEndtered);
            }
            #endregion

            #region Task 7
            int fact = 1;

            for (int i = 2; i <= 6; i++)
                fact *= i;

            Console.WriteLine($"Task 7: {fact}");
            #endregion

            #region Task 8
            fact = 1;
            s = fact;

            for (int i = 2; i <= 6; i++)
            {
                fact *= i;
                s += fact;
            }

            Console.WriteLine($"Task 8: {s}");
            #endregion

            #region Task 9
            s = 0;
            fact = 1;
            int power = 5;
            int sign = -1;

            for (int i = 1; i <= 6; i++)
            {
                s += sign * power / fact;

                sign = -sign;
                power *= 5;
                fact *= i;
            }

            Console.WriteLine($"Task 9: {s}");
            #endregion

            #region Task 15
            double prevNumerator = 1;
            double currentNumerator = 2;

            double prevDenominator = 1;
            double currentDenominator = 1;

            double buffer = 0;

            for (int i = 3; i <= 5; i++)
            {
                // Calculate next numerator
                buffer = prevNumerator + currentNumerator;
                // Current numerator becomes previous
                prevNumerator = currentNumerator;
                // Next numerator becomes current
                currentNumerator = buffer;

                // Calculate next denominator
                buffer = prevDenominator + currentDenominator;
                // Current denominator becomes previous
                prevDenominator = currentDenominator;
                // Next denominator becomes current
                currentDenominator = buffer;
            }

            Console.WriteLine($"Task 15: {Math.Round(currentNumerator / currentDenominator, 3)}");
            #endregion

            #region Task 16
            s = 1;

            for (int i = 2; i <= 64; i++)
                s += s * 2;

            Console.WriteLine($"Task 16: {s/15} grams");
            #endregion

            #region Task 18
            Console.WriteLine("\nTask 18:");

            s = 10;

            for (int i = 3; i <= 24; i += 3)
            {
                s += s * 2;
                Console.WriteLine($"{i} hours = {s} cells");
            }
            #endregion

            #region Task 13
            Console.WriteLine("\nTask 13:");
            decimal xf = -1.5m; // xf - stands for x of function

            for (; xf <= -1; xf += 0.1m)
                Console.WriteLine($"x = {xf} \t y = {1}");
            for (; xf <= 1; xf += 0.1m)
                Console.WriteLine($"x = {xf} \t y = {-xf}");
            for (; xf <= 1.5m; xf += 0.1m)
                Console.WriteLine($"x = {xf} \t y = {-1}");
            #endregion
        }
    }
}
