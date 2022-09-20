using System;

namespace _1stlab
{
    class Program
    {
        static int factorial(int n)
        {
            if (n == 1)
            {
                return 1;
            }
            else
            {
                return n * factorial(n - 1);
            }
        }

        static void Main(String[] args)
        {
            #region lvl1_task4
            Console.WriteLine("Enter x:");
            double x = Convert.ToInt32(Console.ReadLine());
            double s = 0;
            for (int i = 1; i < 10; i++)
            {
                s += (Math.Cos(i * x) / Math.Pow(x, i - 1));
            }
            Console.WriteLine(s);
            #endregion

            #region lvl1_task9
            s = 0;
            for (int i = 1; i < 7; i++)
            {
                s += (Math.Pow(-1, i) * Math.Pow(5, i) / factorial(i));
            }
            Console.WriteLine(s);
            #endregion

            #region lvl1_task15
            double num = 1, den = 1;
            for (int i = 0; i < 4; i++)
            {
                num += den;
                den = num - den;
            }
            Console.WriteLine(num / den);
            #endregion

            #region lvl1_task16
            s = 0;
            for (int i = 0; i < 64; i++)
            {
                s += Math.Pow(2, i);
            }
            Console.WriteLine(s / 15);
            #endregion

            #region lvl1_task18
            int cells = 10;
            for (int i = 1; i < 9; i++)
            {
                cells *= 2;
                Console.WriteLine($"{i * 3} hours = {cells}");
            }
            #endregion

            #region lvl2_task2
            int l = 30000;
            int p = 1;
            int pow = 4;
            while (p < l)
            {
                p *= pow;
                pow += 3;
            }
            pow -= 6;
            Console.WriteLine(pow);
            #endregion

            #region lvl2_task4
            s = 0;
            double e = 0.0001;
            Console.WriteLine("Enter x:");
            double x2 = Convert.ToDouble(Console.ReadLine());
            if (Math.Abs(x2) < 1)
            {
                for (int i = 0; Math.Pow(x2, i) > e; i += 2)
                {
                    s += Math.Pow(x2, i);
                }
                Console.WriteLine(s);
            }
            else
            {
                Console.WriteLine("Wrong value... (|x| < 1)");
            }
            #endregion

            #region lvl2_task8
            // a
            double length = 10;
            s = 10;
            double multiplier = 1.1;
            int days_count = 7;
            for (int i = 1; i < days_count; i++)
            {
                length *= multiplier;
                s += length;
            }
            Console.WriteLine(s);

            // b
            s = 0;
            length = 10;
            int days = 0;
            while (s < 100)
            {
                s += length;
                length *= multiplier;
                days++;
            }
            Console.WriteLine(days);

            // c
            s = 0;
            length = 10;
            days = 1;
            while (length < 20)
            {
                s += length;
                length *= multiplier;
                days++;
            }
            Console.WriteLine(days);
            #endregion

            #region lvl3_task1
            double a = 0.1, b = 1.0, h = 0.1;
            s = 0;
            double sum = 0;
            for (double xx = a; xx <= b; xx += h)
            {
                s = 0;
                int i = 1;
                double term = 0;
                do
                {
                    term = Math.Pow(-1, i) * Math.Pow(xx, i * 2) / factorial(i * 2);
                    s += term;
                    i++;
                } while (term >= 0.0001);
                double y = Math.Cos(xx);
                sum += s;
                Console.WriteLine($"x: {x}, y: {y}, s: {s}");
            }
            Console.WriteLine("Sum: " + sum);
            #endregion

            #region lvl3_task7
            a = 0.1;
            b = 1.0;
            h = 0.05;
            s = 0;
            sum = 0;
            for (double xx = a; xx <= b; xx += h)
            {
                s = 0;
                int i = 1;
                double term = 0;
                do
                {
                    term = Math.Pow(xx, i * 2) / factorial(i * 2);
                    s += term;
                    i++;
                } while (term >= 0.0001);
                double y = (Math.Exp(xx) + Math.Exp(-1 * xx)) / 2;
                sum += s;
                Console.WriteLine($"x: {x}, y: {y}, s: {s}");
            }
            Console.WriteLine("Sum: " + sum);
            #endregion
            Console.ReadLine();
        }
    }
}
