using System;

namespace LABA_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 1lvl, 4
            double x = double.Parse(Console.ReadLine());
            double s = 0;
            for (int i = 1; i <= 9; i++)
            {
                s += Math.Cos(x * i) / Math.Pow(x, i - 1);
            }
            Console.WriteLine(s);
            #endregion;

            #region 1lvl, 9
            double sum = 0;
            int f = 1;
            for (int i = 1; i <= 6; i++)
            {
                f *= i;
                sum += (Math.Pow(-1, i) * Math.Pow(5, i)) / f;
            }
            Console.WriteLine(sum);
            #endregion;

            #region 1lvl, 15
            int a = 1;
            int b = 1;
            int c = 2;
            int d = 1;
            double r = 0;
            for (int i = 3; i <= 5; i++)
            {
                r = (double)(a + c) / (b + d);
                int oldA = a;
                int oldB = b;
                a = c;
                b = d;
                c = oldA + c;
                d = oldB + d;
            }
            Console.WriteLine(c + "/" + d);
            Console.WriteLine(r);
            #endregion;

            #region lvl 1,16
            double s = 0;
            for (int x = 0; x <= 63; x++)
            {
                s += Math.Pow(2, x);
            }
            Console.WriteLine(s / 15);
            #endregion;

            #region lvl 1,18
            int cnt = 10;
            for (int i = 0; i < 24; i += 3)
            {
                cnt *= 2;
                Console.WriteLine(cnt);
            }
            #endregion;

            #region lvl 2,2
            int n = 1;
            int L = 30000;
            int p = 1;
            int i = 1;
            while (p <= L)
            {
                p *= i;
                n = i;
                i += 3;
            }


            Console.WriteLine(n);

            #endregion;

            #region lvl 2, 4
            double a = 1;
            double E = 0.0001;
            double x = double.Parse(Console.ReadLine());
            double s = 0;
            while (Math.Abs(a) >= E)
            {
                s += a;
                a *= x * x;
            }
            Console.WriteLine(s);
            #endregion;

            #region lvl 2,7-8
            double a = 10;
            double s = 0;
            double d = 0;
            double t = a;
            while (d < 7)
            {
                a *= 1.1;
                t += a;
                d++;
            }
            Console.WriteLine(t);


            double a = 10;
            double s = 100;
            double d = 0;
            double t = a;
            while (t < s)
            {
                a *= 1.1;
                t += a;
                d++;
            }
            Console.WriteLine(d);

            double a = 10;
            double s = 20;
            double d = 0;
            double t = a;
            while (a <= 20)
            {
                a += 1.1;
                t = +a;
                d++;
                Console.WriteLine(d + "  " + a);
            }
            Console.WriteLine(d);
            #endregion;


            #region  lvl 3, 1
            double a = 0.1;
            double b = 1;
            double h = 0.1;
            for (double x = a; x <= b; x += h)
            {
                Console.WriteLine("x=" + x);
                Console.WriteLine("y=" + Math.Cos(x));
                double z = 1;
                double sum = 0;
                for (int i = 0; i <= 10000; i++)
                {
                    double j = Math.Pow(-1, i);
                    double k = Math.Pow(x, 2 * i);
                    double s = (j * k) / z;
                    z = z * (i * 2 + 1) * (i * 2 + 2);
                    sum += s;
                    Console.WriteLine("  " + s);
                    if (Math.Abs(s) < 0.0001)
                    {
                        break;
                    }

                }
                Console.WriteLine("summa s=" + sum);
            }
            #endregion;

            #region lvl 3, 5
            double a = Math.PI / 5;
            double b = Math.PI;
            double h = Math.PI / 25;
            for (double x = a; x <= b; x += h)
            {
                Console.WriteLine("x=" + x);
                Console.WriteLine("y=" + (Math.Pow(x, 2) - Math.Pow(Math.PI, 2) / 3) / 4);
                double sum = 0;
                for (int i = 1; i <= 10000; i++)
                {
                    double j = Math.Pow(-1, i);
                    double k = Math.Cos(i * x);
                    double z = Math.Pow(i, 2);
                    double s = (j * k) / z;

                    sum += s;
                    Console.WriteLine("  " + s);
                    if (Math.Abs(s) < 0.0001)
                    {
                        break;
                    }

                }
                Console.WriteLine("summa s=" + sum);
            }
            #endregion;



        }
    }
}
