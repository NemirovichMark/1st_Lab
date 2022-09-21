using System;

namespace _1stlab
{
    class Program
    {
        static void Main(String[] args)
        {
            #region lvl1_task4
            Console.WriteLine("Enter x:");
            double x = Convert.ToInt32(Console.ReadLine());
            double s = 0;
            if (x != 0)
            {
                for (int i = 1; i < 10; i++)
                {
                    s += (Math.Cos(i * x) / Math.Pow(x, i - 1));
                }
                Console.WriteLine(Math.Round(s, 3));
            }
            else
            {
                Console.WriteLine("Wrong input... (x != 0)");
            }
            #endregion

            #region lvl1_task9
            s = 0;
            int fac = 1;
            for (int i = 1; i < 7; i++)
            {
                fac *= i;
                s += (Math.Pow(-1, i) * Math.Pow(5, i) / fac);
            }
            Console.WriteLine(Math.Round(s));
            #endregion

            #region lvl1_task15
            double num = 1, den = 1;
            for (int i = 0; i < 4; i++)
            {
                num += den;
                den = num - den;
            }
            Console.WriteLine(Math.Round(num / den, 3));
            #endregion

            #region lvl1_task16
            s = 0;
            for (int i = 0; i < 64; i++)
            {
                s += Math.Pow(2, i);
            }
            Console.WriteLine(Math.Round(s / 15, 3));
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
            for (int pow = 1; pow * p < l; pow += 3)
            {
                p *= pow;
            }
            Console.WriteLine(p);
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
                Console.WriteLine(Math.Round(s, 3));
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
            Console.WriteLine(Math.Round(s, 3));

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
                xx = Math.Round(xx, 3);
                s = 0;
                int i = 1;
                double term = 0;
                fac = 1;
                do
                {
                    fac *= i;
                    term = Math.Pow(-1, i) * Math.Pow(xx, i * 2) / (fac * 2);
                    s += term;
                    i++;
                } while (term >= 0.0001);
                double y = Math.Round(Math.Cos(xx), 3);
                s = Math.Round(s, 3);
                sum += s;
                Console.WriteLine($"x: {xx}, y: {y}, s: {s}");
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
                xx = Math.Round(xx, 3);
                s = 0;
                int i = 1;
                double term = 0;
                fac = 1;
                do
                {
                    fac *= i;
                    term = Math.Pow(xx, i * 2) / (fac * 2);
                    s += term;
                    i++;
                } while (term >= 0.0001);
                double y = Math.Round((Math.Exp(xx) + Math.Exp(-1 * xx)) / 2, 3);
                s = Math.Round(s, 3);
                sum += s;
                Console.WriteLine($"x: {xx}, y: {y}, s: {s}");
            }
            Console.WriteLine("Sum: " + sum);
            #endregion
            Console.ReadLine();
        }
    }
}
