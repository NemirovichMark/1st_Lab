using System;

namespace _1st_Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Level 1

            #region Task 1.4 (+)

            try
            {
                Console.Write("Enter the number: ");
                double x = Convert.ToDouble(Console.ReadLine());
                double ss = 0;

                for (int i = 1; i <= 9; i++)
                {
                    ss += Math.Cos(i * x) / Math.Pow(x, i - 1);
                }

                Console.WriteLine($"Answer for task 1.4: {ss}\n");
            }

            catch
            {
                Console.WriteLine("Task 1.4 skipped due to incorrect input. Try again!\n");

            }


            #endregion

            #region Task 1.9 (+)

            double answer_1_9 = 0;
            int factorial = 1;
            int pp = 1;

            for (int power = 1; power < 7; power++)
            {
                factorial *= pp;

                answer_1_9 += Math.Pow(-1, power) * Math.Pow(5, power) / factorial;

                pp++;
            }

            Console.WriteLine($"Answer for task 1.9: {answer_1_9:f3}\n");

            #endregion

            #region Task 1.15 (+)

            int chis1 = 1;
            int znam1 = 1;
            int chis2 = 2;
            int znam2 = 1;

            int chis3 = 0;
            int znam3 = 0;

            for (int i = 3; i <= 5; i++)
            {
                chis3 = chis2 + chis1;
                znam3 = znam2 + znam1;

                chis1 = chis2;
                chis2 = chis3;

                znam1 = znam2;
                znam2 = znam3;
            }

            Console.WriteLine($"Answer for task 1.15: {chis3}/{znam3} = {(chis3 * 1.0) / znam3}\n");



            #endregion

            #region Task 1.16 (+)

            double sum_grains = 0;

            // Console.WriteLine("\nSolution for task 1.16:\n");

            for (int pow = 0; pow < 64; pow++) // 1 cell = 2^0; 2 cell = 2^1 ...
            {
                sum_grains += Math.Pow(2, pow);
                // Console.WriteLine($"cell = {pow + 1}\tcount = {Math.Pow(2, pow)}\tsum = {sum_grains}");
            }

            Console.WriteLine($"Answer for task 1.16: {sum_grains / 15 / 1000 / 1000} tons\n"); // :15 to convert to grams

            #endregion

            #region Task 1.18 (+)

            int cnt = 10;

            Console.WriteLine("Answer for task 1.18: ");

            for (int hours = 3; hours <= 24; hours += 3)
            {
                cnt *= 2;
                Console.WriteLine($"hours: {hours}\tamoeba: {cnt}");
            }

            #endregion

            #endregion

            #region Level 2

            #region Task 2.2 (+)

            int p = 1;
            int L = 1;
            int n = 1;

            while (L < 30000)
            {
                n = p;
                p += 3;
                L *= p;
                // Console.WriteLine($"n = {n}\tL = {L}");
                // This is for checking the answer.
            }

            n -= 3;

            Console.WriteLine($"\nAnswer for task 2.2: {n}\n");

            #endregion

            #region Task 2.4 (+)

            try
            {
                Console.Write("Enter the number ( |x| < 1 ): ");
                double x = Convert.ToDouble(Console.ReadLine());

                if (Math.Abs(x) < 1)
                {
                    double ss = 0;
                    double eps = 1;

                    for (int i = 0; eps >= 0.0001; i += 2)
                    {
                        ss += Math.Pow(x, i);
                        eps = Math.Pow(x, i);
                    }

                    Console.WriteLine($"Answer for task 2.4: {ss}\n");
                }

                else
                    Console.WriteLine("The absolute value of x must be less than 1\n" +
                        "Task 2.2 skipped due to incorrect input. Try again!\n");
            }



            catch
            {
                Console.WriteLine("Task 1.4 skipped due to incorrect input. Try again!\n");
            }

            #endregion

            #region Task 2.7 & Task 2.8 (+++)

            // -------------------------
            // Task 2.8 A

            double distance = 10;
            double sum_dist = distance;
            int day = 1;
            Console.WriteLine($"day: {day}\tdistance: {distance:f3}km\tsum_distance: {sum_dist:f3}km");
            for (day = 2; day <= 7; day++)
            {
                distance += distance * 0.1;
                sum_dist += distance;
                Console.WriteLine($"day: {day}\tdistance: {distance:f3}km\tsum_distance: {sum_dist:f3}km");
            }



            Console.WriteLine($"Answer for task 2.8 A: {sum_dist}km\n");

            // -------------------------
            // Task 2.8 B

            distance = 10;
            sum_dist = distance;
            day = 1;

            Console.WriteLine($"day: {day}\tdistance: {distance:f3}km\tsum_distance: {sum_dist:f3}km");

            while (sum_dist < 100)
            {
                distance += distance * 0.1;
                sum_dist += distance;
                day++;
                Console.WriteLine($"day: {day}\tdistance: {distance:f3}km\tsum_distance: {sum_dist:f3}km");
            }

            Console.WriteLine($"Answer for task 2.8 B: {day} day(s)\n");

            // -------------------------
            // Task 2.8 C

            distance = 10;
            sum_dist = distance;
            day = 1;

            Console.WriteLine($"day: {day}\tdistance: {distance:f3}km\tsum_distance: {sum_dist:f3}km");

            while (distance < 20)
            {
                distance += distance * 0.1;
                sum_dist += distance;
                day++;
                Console.WriteLine($"day: {day}\tdistance: {distance:f3}km\tsum_distance: {sum_dist:f3}km");
            }


            Console.WriteLine($"Answer for task 2.8 C: {day} day(s)\n");

            #endregion

            #endregion

            #region Level 3

            #region Task 3.1

            Console.WriteLine("Answer for task 3.1:");

            double s = 1.0;
            for (double x = 0.1; x <= 1; x += 0.1)
            {
                x = Math.Round(x, 1);
                int i = 0;
                double qwe;
                double znam = 1.0;
                do
                {
                    qwe = Math.Pow(-1, i) * Math.Pow(x, 2 * i) / znam;
                    i++;
                    s += qwe;
                    znam *= (2 * i) * (2 * i - 1);
                }

                while (qwe >= 0.0001);

                double y = Math.Cos(x);

                Console.WriteLine($"x = {x:f1};\ts = {s:f5};\ty = {y:f5}");
            }

            #endregion

            #region Task 3.6

            Console.WriteLine("\nAnswer for task 3.6:");

            double s6 = 1.0;

            for (double x = 0.1; x <= 1; x += 0.1)
            {
                int i = 1;
                double qwe;

                do
                {
                    qwe = Math.Pow(-1, i + 1) * (Math.Pow(x, 2 * i + 1) / (4 * Math.Pow(i, 2) - 1));
                    s6 += qwe;
                    i++;
                }

                while (qwe >= 0.0001);

                double y = (((1 + Math.Pow(x, 2)) * Math.Atan(x)) / 2) - (x / 2);

                Console.WriteLine($"x = {x:f1};\ts = {s6:f5};\ty = {y:f5}");

            }

            #endregion

            #endregion
        }
    }
}
