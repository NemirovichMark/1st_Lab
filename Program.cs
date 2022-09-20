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
            #region level_1
            #region task_1
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
            Console.WriteLine($"Level 1");

            #region task_4
            {
                double x;
                double s = 0.0;
                double eps = 0.0001;

                while (true)
                {
                    Console.Write("     Please enter x: ");
                    if (!double.TryParse(Console.ReadLine(), out x))
                    {
                        Console.WriteLine("     Wrong x, please try again...");
                    }
                    if (x == 0)
                    {
                        Console.WriteLine("     X cannot be equal to zero, try again.");
                        continue;
                    }
                    break;
                }

                for (double i = 1.0; i <= 8 + eps; i++)
                {
                    s = s + Math.Cos(i * x) / Math.Pow(x, i);
                }

                Console.WriteLine($"    task_4: {s}");

            }
            #endregion

            #region task_9
            {
                double s = 0;
                int max_num = 6;
                double p = 1;
                double five = 5.0;
                double factor = 1.0;

                for (double i = 1.0; i < max_num; i++)
                {
                    p = -p;
                    five *= 5;
                    s += p * five / factor;
                    factor *= i;
                }
                Console.WriteLine($"    task_9: {s}");
            }
            #endregion

            #region task_15
            {

                double numerator = 1.0, denominator = 1.0;

                for (int i = 0; i < 4; i++)
                {
                    numerator += denominator;
                    denominator = numerator - denominator;
                }
                Console.WriteLine($"    task 15: {numerator / denominator}");
            }
            #endregion

            #region task_16
            {
                int gramm = 15;
                int n = 64;
                int b = 2;
                double summa = 0;

                for (int i = 0; i < n; i++)
                {
                    summa += Math.Pow(b, i);
                }

                Console.WriteLine($"    task 16: {summa / gramm}");

            }
            #endregion

            #region task_18
            {
                int start = 3, step = 3, end = 24;
                int cells = 10;
                Console.WriteLine("     task_18");

                for (int i = start; i <= end; i += step)
                {
                    cells *= 2;
                    Console.WriteLine($"    {i} hours: {cells} cells");
                }
            }
            #endregion
            #endregion

            #region level 2
            Console.WriteLine($"Level 2");
            #region task_2
            {
                double p = 1.0, n = 1.0;
                double step = 3;
                int L = 30000;

                while (p < L)
                {
                    n += step;
                    p *= n;
                }
                Console.WriteLine($"    Task 2: {n - 3}");
            }
            #endregion

            #region task_4
            {
                double x;
                double eps = 0.0001;
                double s = 1.0;
                int n = 2;

                while (true)
                {
                    Console.Write("     Please enter x: ");
                    if (!double.TryParse(Console.ReadLine(), out x))
                    {
                        Console.WriteLine("     Wrong x, please try again...");
                    }
                    if (Math.Abs(x) >= 1.0 || x == 0)
                    {
                        Console.WriteLine("     x must be in range (-1; 1) except {0}, try again.");
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
                Console.WriteLine($"    task_4: {s}");

            }
            #endregion

            #region task_7 & task_8
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
                Console.WriteLine($"    Task 8a: {s}");

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
                Console.WriteLine($"    task 8b: {days}");

                start = 10.0;
                days = 1;
                while (start < 20)
                {
                    start *= (1 + p);
                    ++days;
                }
                Console.WriteLine($"    task 8c: {days}");

            }
            #endregion
            #endregion

            #region level 3
            Console.WriteLine($"Level 3");
            #region task_1
            {
                Console.WriteLine($"    task 1");
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
                Console.WriteLine($"    task 1 s: {s}");
            }
            #endregion

            #region task_9
            {
                Console.WriteLine($"    task 9");
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
                Console.WriteLine($"    task 9 s: {s}");
            }
            #endregion
            #endregion
        }
    }
}