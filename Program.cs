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
            double x = double.Parse(Console.ReadLine());
            for (double i = 0; i <= 8; i++)
                for (double j = 1; j <= 9; j++)
                {
                    s = s + Math.Cos(j * x) / Math.Pow(x, i);
                }
            Console.WriteLine(s);
            #endregion

            #region ex9
            double s = 0;
            double y = 1;
            for (double i = 1; i <= 6; i++)

            {
                y = y * i;
                s = s + Math.Pow((-1), i) * Math.Pow(5, i) / y;
            }
            Console.WriteLine(s);
            #endregion

            #region ex15
            double a = 1;
            double b = 1;
            double c = 2;
            double d = 1;
            double s = 0;
            for (double i = 1; i <= 3; i++)
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
            double a = 0;
            double r;
            double s = 0;
            for (int i = 0; i < 64; i++)
            {
                s += Math.Pow(2, i);
            }
            r = s / 15.0 / 1000;
            Console.WriteLine(r);
            #endregion

            #region ex18
            int s = 10;
            for (int i = 3; i <= 24; i += 3)
            {
                s *= 2;
                Console.WriteLine(s);
            }
            #endregion

            #endregion

            #region lvl2
            
            #region ex2
            double s = 1;
            double n = 0;
            for (double i = 1; s * n < 30000; i += 3)
            {
                s = s * i;
                n = i;
            }
            Console.WriteLine(n);
            #endregion

            #region ex4
            double s = 0;
            double p = 1;
            Console.WriteLine("Введите x:");
            double x = double.Parse(Console.ReadLine());
            for (double i = 0; Math.Abs(p) > 0.0001; i = i + 2)
            {
                p = Math.Pow(x, i);
                s = s + p;


            }
            Console.WriteLine(s);
            #endregion

            #region ex7
            double s = 10;
            double a = 10;
            double i = 0;
            for (i = 2; i < 100; i++)
            {
                a = a * 1.1;
                s = s + a;
                if (i == 7)
                {

                    Console.WriteLine("В сумме спортсмен за " + i + " дней пробежал " + s + " км");
                }
                if (s >= 100 && s < 120)
                {
                    Console.WriteLine("Через " + i + " дней спортсмен пробежит суммарно 100 км");
                }
                if (a >= 20 && a < 22)
                {
                    Console.WriteLine("На " + i + " день спортсмен начнёт бегать больше 20 км");
                }

            }
            #endregion

            #region ex8
            double s = 10000;
            double a = 20000;
            for (double i = 1; i <= 10; i++)
            {
                s = s * 1.08;
                if (s >= a)
                {
                    Console.WriteLine("Через " + i + " месяцев сумма удвоится");
                    break;
                }
            }
            #endregion

            #endregion
            
            #region lvl3
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
        }
    }
}
