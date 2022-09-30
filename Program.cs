using System;
namespace _1st_Lesson
{
    class Program
    {
        public static double factorial(double number)
        {
            int fact = 1;

            for (int i = 1; i <= number; i++)
            {
                fact = fact * i;
            }


            return fact;
        }
        static void Main(string[] args)
        {
            #region level_1_task_1
            {
                int s = 0, step = 3;

                for (int i = 2; i <= 35; i = i + step)
                {
                    s = s + i;
                }
                /*
                 * Console.WriteLine(s);
                 */
            }

            #endregion

            #region level_1_task_4
            {
                double x;
                double s = 0.0;

                while (true)
                {
                    Console.Write("Please enter x: ");
                    if (!double.TryParse(Console.ReadLine(), out x))
                    {
                        Console.WriteLine("Wrong x, please try again...");
                    }
                    if (x == 0)
                    {
                        Console.WriteLine("X cannot be equal to zero, try again.");
                        continue;
                    }
                    break;
                }

                for (double i = 1.0; i <= 8 + 0.0001; i++)
                {
                    s = s + Math.Cos(i * x) / Math.Pow(x, i);
                }

                Console.WriteLine($"Level_1_task_4: {s}");

            }
            #endregion

            #region level_1_task_9
            {
                double factorial_value = 1;
                double s = 0;
                int max_num = 6;
                double p = 1;
                double five = 5.0;
                for (double i = 1.0; i < max_num; i++)
                {
                    p = -p;
                    five *= 5;
                    factorial_value *= i;
                    s += p * five / factorial_value;
                }
                Console.WriteLine($"level_1_task_9: {s}");
            }
            #endregion

            #region level_1_task_15
            {
                int i = 0;
                int nomenatorStart = 1;
                int denominatorStart = 1;
                int DenominatorFinal = 1;
                int NominatorFinal = 2;
                int Nominator_t = 0;
                int Denominator_t = 0;

                for (i = 1; i <= 3; i = i + 1)
                {
                    Nominator_t = NominatorFinal;
                    NominatorFinal = NominatorFinal + nomenatorStart;
                    nomenatorStart = Nominator_t;

                    Denominator_t = DenominatorFinal;
                    DenominatorFinal = DenominatorFinal + denominatorStart;
                    denominatorStart = Denominator_t;

                }
                Console.WriteLine($"level_1_task_15: {NominatorFinal}/{DenominatorFinal}");
            }
            #endregion

                #region task 16 level 1
            {
                int gramm = 15;
                int n = 64;
                int b1 = 1;


                double summa = -(b1 * (1 - Math.Pow(2.0, n)));
                Console.WriteLine($"task 16: {summa / gramm}");

            }
            #endregion

            #region level_1_task_18
            {
                int start = 3, step = 3, end = 24;
                int cells = 10;
                Console.WriteLine("Level_1_task_18");

                for (int i = start; i <= end; i = i + step)
                {
                    cells = cells * 2;
                    Console.WriteLine($"    {i}: {cells}");
                }
            }
            #endregion

            #region level_2_task_2
            {
                Console.WriteLine($"task 2 level 2 started");
                int n = 1;
                int L = 1;
                int d;
                do
                {
                    n = n + 3;
                    L *= n;
                    d = L * (n + 3);
                } while (d < 30000);
                Console.WriteLine($"Level_2_task_2:: {n}");
            }
            #endregion

            #region level_2_task_4
            {
                double x;
                double eps = 0.0001;
                double s = 1.0;
                int n = 2;

                while (true)
                {
                    Console.Write("Please enter x: ");
                    if (!double.TryParse(Console.ReadLine(), out x))
                    {
                        Console.WriteLine("Wrong x, please try again...");
                    }
                    if (Math.Abs(x) >= 1.0)
                    {
                        Console.WriteLine("x must be in range (-1; 1), try again.");
                        continue;
                    }
                    break;
                }

                while (true)
                {
                    double t = Math.Pow(x, n);
                    if (t < eps)
                    {
                        break;
                    }
                    s += t;
                    n += 2;
                }
                Console.WriteLine($"level_2_task_4: {s}");

            }
            #endregion

            #region level_2_task_7 & level_2_task_8
            {
                double start = 10.0;
                double p = 0.1;
                int days = 7;
                double s = 0.0;

                /*
                 * point a
                 */
                for (int i = 1; i <= days - 1; i++)
                {
                    start = start * (1 + p);
                    s += start;
                }
                Console.WriteLine($"Level 2 Task 8a: {s}");

                /*
                 * point b
                 */

                start = 10.0; s = 10; days = 1;

                while (s < 100)
                {
                    start *= (1 + p);
                    s += start;
                    ++days;
                }
                Console.WriteLine($"level 2 task 8b: {days}");

                start = 10.0;
                days = 1;
                while (start < 20)
                {
                    start *= (1 + p);
                    ++days;
                }
                Console.WriteLine($"level 2 task 8c: {days}");

            }
            #endregion

            #region Level_3_task_1
            {
                Console.WriteLine($"Level 3 task 1");
                double s = 1.0;
                double a = 0.1, b = 1.0, h = 0.1;
                double eps = 0.0001;
                double temporary;
                int i;
                double product;
                double sign;

                for (double xx = a; xx <= b; xx += h)
                {
                    xx = Math.Round(xx, 1);
                    temporary = 0.0;
                    i = 0;
                    product = 1.0;
                    sign = -1;



                    do
                    {
                        sign = -sign;
                        temporary = sign * Math.Pow(xx, 2 * i) / product;
                        i++;
                        s += temporary;
                        product *= 2 * i * (2 * i - 1);
                    } while (temporary >= eps);

                    double y = Math.Cos(xx);
                    Console.WriteLine($"    x = {xx}; s = {s:f5}; y = {y}");
                }
                Console.WriteLine($"    Level 3 task 1: {s}");
            }
            #endregion

            #region level_3_task_9
            {
                Console.WriteLine($"Level 3 task 9");
                double s = 0.0;
                double a = 0.1, b = 0.5, h = 0.05;
                double eps = 0.0001;
                double temporary;
                int i;
                double sign;

                for (double xx = a; xx <= b; xx += h)
                {
                    xx = Math.Round(xx, 2);
                    temporary = 0.0;
                    i = 0;
                    sign = -1;

                    do
                    {
                        sign = -sign;
                        temporary = sign * Math.Pow(xx, 2 * i + 1) / (2 * i + 1);
                        i++;
                        s += temporary;
                    } while (temporary >= eps);

                    double y = Math.Atan(xx);
                    Console.WriteLine($"    x = {xx}; s = {s:f5}; y = {y}");
                }
                Console.WriteLine($"    Level 3 task 9: {s}");
            }
            #endregion
        }
    }
}
