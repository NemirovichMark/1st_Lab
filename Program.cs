using System;

namespace _1st_Lab
{
    class Program
    {
        static void Main(string[] args)
        {

            #region Task_1_4
            double s = 0;
            double x = Convert.ToDouble(Console.ReadLine());
            for (int j = 1; j <= 8; j++)
            {
                s += Math.Cos(x * j) / (Math.Pow(x, j - 1)); 
            }
            Console.WriteLine(s);
            #endregion
            
            #region Task_1_9
            double s = 0;
            
            static int Factorial(int n)
            {
                    if (n == 1) return 1;
                    return n * Factorial(n - 1);
            }
        
            for (int j = 1; j <= 6; j++)
            {
                if (j % 2 == 0)
                {
                    s += Math.Pow(5, j) / Factorial(j);
                }
                else
                {
                    s -= Math.Pow(5, j) / Factorial(j);
                }
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
            static int ameba(int n)
            {
                if (n == 0) return 10;
                return 2 * ameba(n - 3);
            }

            for (int i = 0; i <= 24; i += 3)
            {
                Console.WriteLine($"quantity of cells after {i} hours: {ameba(i)}");
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
            
            #region Task_2_7-8
            double FirstDayPath = 10;
            double s = 0;
            double a;
            double n = 1.1;

            double Path(int days)
            {
                if (days == 1) return FirstDayPath;
                return Path(days - 1) * n;
            }

            for (int i = 1; i <= 7; i ++)
            {
                s += Path(i);
            }

            Console.WriteLine($"path after 7 days: {s}");
            s = 0;
            int j = 1;

            while (true)
            {
                a = Path(j);
                s += a;
                if (s >= 100)
                {
                    Console.WriteLine($"100 km in total after: {j} days");
                    break;
                }
                j++;
            }

            int k = 1;

            while (true)
            {
                a = Path(k);
                if (a > 20)
                {
                    Console.WriteLine($"20 km in 1 day after: {k} days");
                    break;
                }
                k++;
            }
            #endregion
            
            #region Task_3_1
            double e = 0.0001;
            double y;
            int i = 0;
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
                    k = Math.Pow(a, 2 * i) / Factorial(2 * i);
                    y = Math.Cos(a);
                    Console.WriteLine($"x = {a}; s = {s};  y = {y}; k = {k}");
                    if (Math.Abs(k) < e) c = 1;
                    if (c == 1) break;
                    if (i % 2 == 0)
                    {
                        s += k;
                    }
                    else
                    {
                        s -= k;
                    }
                }
                
                i++;
            }
            Console.WriteLine(s);
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
