using System;
using System.Net;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters;

namespace LB1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region lvl1

            #region ex4
            double s = 0;
            double x;
            Console.WriteLine();
            x = Int32.Parse(Console.ReadLine());
            if (x != 0)
            {
                for (int i = 1; i <= 9; i++)
                {
                    s += Math.Cos(x * i) / Math.Pow(x, i - 1);
                }
                Console.WriteLine(s);
            }
            else
            {
                Console.WriteLine("Error");
            }
            #endregion

            #region ex9
            s = 0;
            double y = 1;
            for (double i1 = 1; i1 <= 6; i1++)

            {
                y = y * i1;
                s = s + Math.Pow((-1), i1) * Math.Pow(5, i1) / y;
            }
            Console.WriteLine(s);
            #endregion

            #region ex15
            double a = 1;
            double b = 1;
            double c = 2;
            double d = 1;
            s = 0;
            for (double i2 = 1; i2 <= 3; i2++)
            {
                double e = a + c;
                double f = b + d;
                a = c;
                b = d;
                c = e;
                d = f;
                s = e / f;
            }
            Console.WriteLine(s);
            #endregion
            
            #region ex16
            a = 0;
            double r;
            s = 0;
            for (int i3 = 0; i3 < 64; i3++)
            {
                s += Math.Pow(2, i3);
            }
            r = s / 15.0 / 1000;
            Console.WriteLine(r);
            #endregion

            #region ex18
            int s1 = 10;
            for (int i4 = 3; i4 <= 24; i4 += 3)
            {
                s1 *= 2;
                Console.WriteLine(s1);
            }
            #endregion

            #endregion

            #region lvl2

            #region ex2
            s = 30000;
            a = 1; 
            b = 1;
            while (a <= s)
            {
                b += 3;
                a *= b;
            }
            b -= 3;
            Console.WriteLine(b);
            #endregion

            #region ex4
            x = Convert.ToDouble(Console.ReadLine());
            const double eps1 = 0.0001;
            double rez = 1.0;
            double aa;
            if ((Math.Abs(x) < 1) && (Math.Abs(x) >= eps1))
            {
                for (int i5 = 2; ; i5 = i5 + 2)
                {
                    aa = Math.Pow(x, i5);
                    if (aa < eps1)
                        break;
                    rez += aa;
                }
                Console.WriteLine(rez);
            }
            else if (x == 0)
            {
                Console.WriteLine(rez);
            }
            else
            {
                Console.WriteLine("Error");
            }
            #endregion
            
            #region ex7
            s = 10;
            a = 10;
            double i7 = 0;
            for (i7 = 2; i7 < 100; i7++)
            {
                a = a * 1.1;
                s = s + a;
                if (i7 == 7)
                {

                    Console.WriteLine("В сумме спортсмен за " + i7 + " дней пробежал " + s + " км");
                }
                if (s >= 100 && s < 120)
                {
                    Console.WriteLine("Через " + i7 + " дней спортсмен пробежит суммарно 100 км");
                }
                if (a >= 20 && a < 22)
                {
                    Console.WriteLine("На " + i7 + " день спортсмен начнёт бегать больше 20 км");
                }

            }
            #endregion

            #region ex8
            s = 10000;
            a = 20000;
            for (double i8 = 1; i8 <= 10; i8++)
            {
                s = s * 1.08;
                if (s >= a)
                {
                    Console.WriteLine("Через " + i8 + " месяцев сумма удвоится");
                    break;
                }
            }
            #endregion

            #endregion

            #region lvl3

            #region ex1
            double lg = 0.1;
            double ug = 1;
            double step = 0.1;
            for (double arg = lg; arg <= ug; arg += step)
            {
                int i = 0;
                double fact = 1;
                double elem;
                double sf = 0;
                do
                {
                    elem = Math.Pow(-1, i) * (Math.Pow(arg, 2 * i) / fact);
                    sf += elem;
                    i++;
                    fact *= 2 * i * (2 * i - 1);

                }while (Math.Abs(elem) >= 0.0001);
                Console.WriteLine("arg = {0:f2}   sf = {1:f2}   y = {2:f2}", arg, sf, Math.Cos(arg));
            }
            #endregion

            #region ex6
            Console.WriteLine("------------------");
            lg = 0.1;
            ug = 1;
            step = 0.1;
            for (double arg = lg; arg <= ug; arg += step)
            {
                double sf = 0;
                int i = 1;
                double elem;
                do
                {
                    elem = Math.Pow(-1, i + 1) * (Math.Pow(arg, 2 * i + 1) / (4 * (Math.Pow(i, 2)) - 1));
                    sf += elem;
                    i++;
                } while (Math.Abs(elem) >= 0.0001);
                double yx = (Math.Atan(arg) * (1 + Math.Pow(arg, 2))) / 2 - arg / 2;
                Console.WriteLine("arg = {0:f4}   sf = {1:f4}   y = {2:f4}", arg, sf, (Math.Atan(arg) * (1 + Math.Pow(arg, 2))) / 2 - arg / 2);
            }
            #endregion
            #endregion



        }
    }
}
