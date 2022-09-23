using System;

namespace _1st_Lab
{
    class Program
    {
        static void Main(string[] args)
        {

            #region Task_1_4
            Console.WriteLine("enter x");
            double x = Convert.ToDouble(Console.ReadLine());
            double s = Math.Cos(x);
            if (x == 0)
            {
                Console.WriteLine("x can't be 0");
            }
            else
            {
                for (int j = 1; j <= 8; j++)
                {
                    s += Math.Cos(x * (j + 1)) / Math.Pow(x, j);
                }
                Console.WriteLine(s);
            }
            #endregion
            
            #region Task_1_9
            double s = 0;
            double n = 1;
            for (int j = 1; j <= 6; j++)
            {
                n *= j;
                s += Math.Pow(-1, j) * Math.Pow(5, j) / n;
            }
            Console.WriteLine(s);
            #endregion
            
            #region Task_1_15
            double a = 1, b = 1;
            for (int i = 0; i < 4; i++)
            {
                a += b;
                b = a - b;
            }
            Console.WriteLine(a / b);
            #endregion
            
            #region Task_1_16
            double s = 1;
            double cur = 1;
            for (int i = 2; i <= 64; i++)
            {
                cur *= 2;
                s += cur;
            }
            Console.WriteLine(s / 15);
            #endregion
            
            #region Task_1_18
            int n = 10;
            for (int i = 3; i <= 24; i += 3)
            {
                n *= 2;
                Console.WriteLine($"quantity of cells after {i} hours: {n}");
            }           
            #endregion
            
            #region Task_2_2
            int p = 1;
            int L = 30000;
            int i = 1;

            while (p < L)
            {         
                i += 3;
                p *= i;
            }

            Console.WriteLine(i - 3);
            #endregion
            
            #region Task_2_4
            double x = Convert.ToDouble(Console.ReadLine());
            double s = 1;
            double e = 0.0001;
            int n = 1;
            double absX = Math.Abs(x);
            if (absX >= 1) Console.WriteLine("absolute x has to be less than 1");
            else
            {
                while (true)
                {
                    double i = Math.Pow(x, 2 * n);
                    if (i < e) break;
                    else s += i;
                    n += 1;
                }
            }
            if (absX < 1) Console.WriteLine(s);
            #endregion
            
            #region Task_2_7
            double FirstDayPath = 10;
            double cur = FirstDayPath;
            double s = 0;
            double a;
            double n = 1.1;

            for (int i = 1; i <= 7; i ++)
            {               
                s += cur;
                cur *= n;
            }

            Console.WriteLine($"path after 7 days: {s}");
            s = 0;
            cur = FirstDayPath;
            int j = 1;

            while (s < 100)
            {
                s += cur;
                cur *= n;
                j++;
            }
            Console.WriteLine($"100 km in total after: {j - 1} days");

            int k = 1;
            cur = FirstDayPath;
            while (cur <= 20)
            {
                cur *= n;
                k++;
            }
            Console.WriteLine($"20 km in 1 day after: {k} days");
            #endregion
            
            #region Task_3_1
            double e = 0.0001;  
            double y;

            for (double a = 0.1; a < 1; a += 0.1)
            {
                int c = 1;
                double x;
                int i = 0;
                double s = 0;
                double fac = 1;
                do
                {
                    x = c * Math.Pow(a, 2 * i) / fac;
                    s += x;
                    i ++;
                    fac *= ((2 * i - 1) * 2 * i);
                    c = -c;
                } while (Math.Abs(x) > e);
                y = Math.Cos(a);
                Console.WriteLine($"x = {a}; s = {s};  y = {y}");
            }
            #endregion
            
            #region Task_3_6
            double e = 0.0001;
            double y;
            int i = 1;
            double s = 0;
            int c = 0;

            static int Factorial(int n)
            {
                if (n == 0) return 1;
                if (n == 1) return 1;
                return n * Factorial(n - 1);
            }

            double k;
            while (c != 1)
            {
                for (double a = 0.1; a < 1; a += 0.1)
                {
                    k = Math.Pow(a, 2 * i + 1) / (4 * Math.Pow(i, 2) - 1);
                    y = (Math.Atan(a) * (1 + a*a) - a) / 2;
                    Console.WriteLine($"x = {a}; s = {s};  y = {y}; k = {k}");
                    if (Math.Abs(k) < e) c = 1;
                    if (c == 1) break;
                    if (i % 2 == 0)
                    {
                        s -= k;
                    }
                    else
                    {
                        s += k;
                    }
                }

                i++;
            }
            Console.WriteLine(s);
            #endregion
        }
    }
}
