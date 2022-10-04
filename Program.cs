using System;

namespace Lab_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string ERROR = "Input isn't correct!\n";

            #region Task_1_4
            Console.WriteLine("Task 1.4");
            double i, s = 0, c = 0, k = 1;
            try
            {
                double x = 30.0;
                if ((x <= 0) | (k != 1))
                {
                    Console.WriteLine(ERROR);
                    return;
                }
                for (i = 1; i <= 9; i = i + 1)
                {
                    c = c + x;
                    s = s + (Math.Cos(c) / k);
                    k = k * x;
                }
                Console.WriteLine($"Sum = {s}\n");
            }
            catch
            {
                Console.WriteLine(ERROR);
            }
        #endregion

            #region Task_1_9
            Console.WriteLine("Task 1.9");
            s = 0;
            int fact = 1 , upper = 1;
            try
            {
                for (int j = 1; j <= 6; j += 1)
                {
                    fact *= j;
                    upper *= -5;
                    s += (upper / fact);
                }
                Console.WriteLine(s + "\n");
            }
            catch
            {
                Console.WriteLine(ERROR);
            }
            #endregion

            #region Task_1_15
            Console.WriteLine("Task 1.15");
            int a = 1, b = 1, l = 2, q = 1, A = 0, B = 0;
            for (int j = 1; j <= 3; j += 1)
            {
                A = a + l;
                B = b + q;
                a = l;
                b = q;
                l = A;
                q = B;
            }
            Console.WriteLine($"{A}/{B}\n");
            #endregion

            #region Task_1_16
            Console.WriteLine("Task 1.16");
            double sumofseeds = 1, sumingramms = 0, n = 1;
            for (int j = 1; j <= 63; j += 1)
            {
                n *= 2;
                sumofseeds += n;
            }
            sumingramms = sumofseeds / 15;
            Console.WriteLine($"Amount of seeds in gramms: {sumingramms}\n");
            #endregion

            #region Task_1_18
            Console.WriteLine("Task 1.18");
            int ameba = 10;
            for (int j = 0; j <= 24; j += 3)
            {
                Console.WriteLine($"Time: {j}   Amount of amebas: {ameba}");
                ameba *= 2;
            }
            Console.WriteLine("\n");
            #endregion

            #region Task_2_2
            Console.WriteLine("Task 2.2");
            int p1 = 1, p2 = 1;
            for (int j = 1;;j += 3)
            {
                if (p1 <= 30000)
                {
                    p1 *= j;
                    p2 = j - 3;
                }
                else
                {
                    Console.WriteLine($"The biggest last member: {p2}\n");
                    break;
                }
            }
            #endregion

            #region Task_2_4
            Console.WriteLine("Task 2.4");
            double input = -0.9;
            const double EPSILON = 0.0001;
            double amount = 0.0;
            double sq = input * input;
            if (Math.Abs(input)<1)
            {
                while (Math.Abs(sq) > EPSILON)
                {
                    amount = amount + sq;
                    sq = sq * input * input;
                }
                Console.WriteLine(amount + "\n");
            }
            else
            {
                Console.WriteLine(ERROR);
            }
            #endregion

            #region Task_2_7-8
            Console.WriteLine("Task 2.7-8");
            double start = 10.0;
            double distance = 10.0;
            bool point = true;
            for (int j = 2; ; j++)
            {
                start *= 1.1;
                distance = distance + start;
                if (j == 7)
                {
                    Console.WriteLine($"Distance after 7 days: {distance}");
                }
                if ((distance >= 100) && (point == true))
                {
                    point = false;
                    Console.WriteLine($"100 km after {j} days");
                }
                if (start > 20)
                {
                    Console.WriteLine($"20 km per day on {j}'s day\n");
                    break;
                }

            }

            #endregion

            #region Task_3_1
            Console.WriteLine("Task 3.1");
            double summery = 0.0;
            for (double X = 0.1; X <= 1.0; X += 0.1)
            {
                X = Math.Round(X, 1);
                int j = 0;
                double member = 0.0, devider = 1.0;
                do
                {
                    member = Math.Pow(-1, j) * Math.Pow(X, 2 * j) / devider;
                    summery += member;
                    j += 1;
                    devider *= 2 * j * (2 * j - 1);
                } while (Math.Abs(member) >= 0.0001);
                double Y = Math.Cos(X);
                Console.WriteLine($"x = {X} summ = {summery} y = {Y}");
            }
            Console.WriteLine("\n");
            #endregion

            #region Task_3_9
            Console.WriteLine("Task 3.9");
            summery = 0.0;
            for (double X = 0.1; X <= 0.5; X += 0.05)
            {
                X = Math.Round(X, 2);
                int j = 0;
                double member = 0.0, devider = 1.0;
                do
                {
                    member = Math.Pow(-1, j) * Math.Pow(X, 2 * j + 1) / devider;
                    summery += member;
                    j += 1;
                    devider = 2 * j + 1;
                } while (Math.Abs(member) >= 0.0001);
                double Y = Math.Atan(X);
                Console.WriteLine($"x = {X} summ = {summery} y = {Y}");
            }
            #endregion
        }
    }
}
