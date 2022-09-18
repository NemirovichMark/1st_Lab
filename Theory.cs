using System;

namespace _1st_Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            #region First level
            Console.WriteLine("------ First level ----------------------\n");

            #region Task 4
            double x = 0;
            double s = 0;

            Console.Write("For task 4 please enter x (x != 0): ");
            if (double.TryParse(Console.ReadLine(), out x))
            {
                if (x == 0)
                {
                    Console.WriteLine("Entered data is wrong");
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
                Console.WriteLine("Entered data is wrong");
                return;
            }
            #endregion

            #region Task 9
            s = 0;
            int fact = 1;
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

            Console.WriteLine($"Task 16: {s / 15} grams");
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
            #endregion

            #region Second level
            Console.WriteLine("\n------ Second level ----------------------\n");

            #region Task 2
            int p = 1;
            int n = 1;

            while (p < 30000)
            {
                n += 3;
                p *= n;
            }

            n -= 3;

            Console.WriteLine($"Task 2: n = {n}");
            #endregion

            #region Task 4
            s = 1;
            x = 0;

            Console.Write("\nFor task 4 please enter x (|x| < 1): ");
            if (double.TryParse(Console.ReadLine(), out x))
            {
                if (x >= 1 || x <= -1)
                {
                    Console.WriteLine("Entered data is wrong");
                    return;
                }
                else
                {
                    double xdPower2 = x * x;
                    x = xdPower2;

                    while (x >= 0.0001)
                    {
                        s += x;
                        x *= xdPower2;
                    }

                    Console.WriteLine($"Task 4: {Math.Round(s, 6)}\n");
                }
            }
            else
            {
                Console.WriteLine("Entered data is wrong");
                return;
            }
            #endregion

            #region Task 7, 8
            double dailyDistance = 10;
            int days = 1;
            int daysWhenGreater = 0;
            double wholeDistance = 0;

            Console.WriteLine("Task 7, 8: ");

            for (; days <= 7; days++)
            {
                dailyDistance += dailyDistance * 0.1;
                wholeDistance += dailyDistance;

                if (wholeDistance >= 100)
                    daysWhenGreater = days;
            }

            Console.WriteLine($"a) After 7 days whole distance will be {Math.Round(wholeDistance, 2)} km");
            Console.WriteLine($"b) Whole distance will be 100 km or greater after {daysWhenGreater} days");

            for (; dailyDistance <= 20; days++)
            {
                dailyDistance += dailyDistance * 0.1;
                wholeDistance += dailyDistance;
            }

            Console.WriteLine($"c) Daily distance will be greater than 20 km after {days} days");
            #endregion

            #endregion

            #region Third level
            Console.WriteLine("\n------ Third level ----------------------\n");

            #region Task 1
            Console.WriteLine("Task 1:");
            double xfPower2;
            double xfPowerSum;
            double term;
            double y;

            for (decimal xf = 0.1m; xf <= 1; xf += 0.1m)
            {
                s = 0;
                sign = -1;
                fact = 1;

                xfPower2 = (double)(xf * xf);
                xfPowerSum = xfPower2;

                // Zero term calculation
                term = xfPower2;
                s += term;

                for (int i = 1; term >= 0.0001; i++)
                {
                    sign = -sign;
                    fact *= i;

                    term = xfPowerSum / fact;
                    s += term * sign;

                    xfPowerSum *= xfPower2;
                }

                y = Math.Cos((double)xf);

                Console.WriteLine($"x = {xf} \t y = {Math.Round(y, 3)} \t   s = {Math.Round(s, 3)}");
            }
            #endregion

            #region Task 3
            Console.WriteLine("\nTask 3:");

            for (decimal xf = 0.1m; xf <= 1; xf += 0.1m)
            {
                s = 0;
                fact = 1;

                term = 1;

                for (int i = 1; term >= 0.0001; i++)
                {
                    fact *= i;
                    term = Math.Cos((double)(i * xf)) / fact;

                    s += term;
                }

                s += 1;
                y = Math.Exp(Math.Cos((double)xf)) * Math.Cos(Math.Sin((double)xf));

                Console.WriteLine($"x = {xf} \t y = {Math.Round(y, 3)} \t   s = {Math.Round(s, 3)}");
            }
            #endregion

            #endregion
        }
    }
}
