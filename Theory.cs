using System;
using System.Runtime.ExceptionServices;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;

namespace _1st_Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Task 1 - 4
            double s = 0;
            Console.WriteLine("Enter the x value");
            int x = Convert.ToInt32(Console.ReadLine());
            if (x == 0)
                Console.WriteLine("Enter the correct meaning");
            else
            {
                for (int i = 1; i < 10; i++)
                    s += Math.Cos(i * x) / (Math.Pow(x, i - 1));
                Console.WriteLine($"s={s}");
            }
            #endregion
            #region Task 1 - 9
            double s9 = 0;
            double a9 = 0;
            int i9 = 1;
            int p9 = 1;
            for (i9 = 1; i9 <= 6; i9 = i9 + 1)
            {
                p9 = p9 * i9;
                a9 = Math.Pow(-1, i9) * Math.Pow(5, i9) / p9;
                s9 = s9 + a9;
            }
            Console.WriteLine($"Task 9: {s9}");
            #endregion
            #region Task 1  - 15
            int a1 = 1, b1 = 1;
            int a2 = 2, b2 = 1;
            int a3, b3;
            for (int i = 1; i < 5; i++)
            {
                a3 = a1 + a2;
                b3 = b1 + b2;
                a1 = a2;
                b1 = b2;
                a2 = a3;
                b2 = b3;
            }
            Console.WriteLine(a1 / (b1 * 1.0));
            #endregion
            #region Task 1 - 16 
            double i16 = 0, n16 = 1;
            while (i16 < 64)
            {
                i16 = i16 + 1;
                n16 = n16 * 2;
            }
            Console.WriteLine($"number of kilograms {(n16 / 15)}");
            #endregion
            #region Task 1 - 18
            double n18 = 10;
            double i18;
            for (i18 = 3; i18 <= 24; i18 += 3)
            {
                n18 = n18 * 2;
                Console.WriteLine($"Number of cells {n18} after {i18} hours ");
            }
            #region Task 2 - 2
            double n2 = 1;
            double p2 = 1;
            int L2 = 30000;
            while (p2 * n2 < L2)
            {
                p2 = p2 * n2;
                if (p2 * n2 < L2)
                {
                    n2 += 3;
                }
            }
            Console.WriteLine(n2);
            #endregion
            #region Task 2 - 4 
            double epsilon = 0.0001;
            double s_4 = 1;
            Console.WriteLine($"enter x: ");
            double i_4 = 2;
            double x_4 = 1;

            if (double.TryParse(Console.ReadLine(), out x_4) && Math.Abs(x_4) < 1)
            {
                while (Math.Pow(x_4, i_4) > epsilon)
                {
                    s_4 = s_4 + Math.Pow(x_4, i_4);
                    i_4 = i_4 * 2;
                }
            }
            Console.WriteLine($"Task 2_4 : {s_4}");
            #endregion 

            #region Task 2 - 7,8
            #region a 
            double day_a = 10;
            double way_a = 10;
            for (double i7 = 1; i7 < 7; i7++)
            {
                day_a *= 1.1;
                way_a += day_a;
            }
            Console.WriteLine($"Task 2_7(a) : {way_a}");
            #endregion
            #region b
            double day_b = 10;
            double way_b = 10;
            double totaldays_b = 1;
            while (way_b < 100)
            {
                day_b *= 1.1;
                way_b += day_b;
                totaldays_b += 1;
            }
            Console.WriteLine($"Task 2_7(b) : {totaldays_b}");
            #endregion
            #region c
            double day_c = 10;
            double totaldays_c = 1;
            while (day_c <= 20)
            {
                day_c *= 1.1;
                totaldays_c += 1;
            }
            Console.WriteLine($"Task 2_7(c) : {totaldays_c}");
            #endregion
            #endregion
            double summa, g, i0;
            for (double x3 = 0.1; x <= 1 + 0.0001; x3 += 0.1)
            {
                summa = 1;
                g = 1;
                i0 = 2;
                for (int i = 1; Math.Abs(g) >= 0.0001; i++)
                {
                    if (i > 2)
                    {
                        i0 = i0 * (i0 * (i - 1));
                    }
                    g = (Math.Pow(-1, i) * Math.Pow(x, 2 * i) / i0);
                    summa += g;
                }
                double y = Math.Cos(x);
                Console.WriteLine($"x = {x} y = {y} Sum = {summa}");
                #endregion
                #region Task 3 - 2
                double x32, summ, d, y32;
                for (x32 = 0.1; x <= 0.8 + 0.0001; x32 += 0.1)
                {
                    summ = 1;
                    d = 1;
                    for (int i = 1; Math.Abs(d) >= 0.0001; i++)
                    {
                        d = (Math.Pow(x, i) * Math.Sin(i * Math.PI / 4));
                        summ += d;
                    }
                    y32 = (x32 * Math.Sin(Math.PI / 4) / (1 - 2 * x32 * Math.Cos(Math.PI / 4) + x32 * x32));
                    Console.WriteLine($"S = {summ} y = {y32} x = {x32}");
                #endregion




                }


            }
        }
    } }



