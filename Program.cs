using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Diagnostics.Eventing.Reader;
using System.Globalization;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TaskForLab1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Task#1.4
            int i = 1;
            int n = 0;
            Console.Write("x:");
            double x = Convert.ToDouble(Console.ReadLine());
            double s = 0, a;
            if (x != 0)
            {
                for (n = 0; n <= 8; n++)
                {
                    a = Math.Cos(x * i) / Math.Pow(x, n);
                    s = s + a;
                    i = i + 1;
                }
                Console.WriteLine(s);

            }
            else
            {
                Console.WriteLine("Error");
            }
            #endregion
            #region Task#1.9
            int nn, d;
            int fac = 1;
            double s1 = 0;
            for (nn = 1; nn <= 6; nn++)
            {
                for (d = nn; d <= nn; d++)
                {
                    fac *= d;
                    s1 += Math.Pow(-1, nn) * Math.Pow(-5, nn) / fac;
                }
            }
            Console.WriteLine("{0:f4}", s1);
            #endregion
            #region Task#1.15
            int num1 = 1;
            int den1 = 1;
            int den2 = 1;
            int num2 = 2;
            int sumnum, sumden;
            for (int g = 1; g <= 3; g++)
            {
                sumden = den1 + den2;
                sumnum = num1 + num2;
                num1 = num2;
                den1 = den2;
                den2 = sumden;
                num2 = sumnum;
            }
            Console.WriteLine("{0}/{1}", num2, den2);
            #endregion
            #region Task#1.16
            ulong kl = 1;
            ulong ss = 1;
            for (int j = 1; j <= 63; j++)
            {
                kl = kl * 2;
                ss += kl;
            }
            Console.WriteLine("Amount of grain: {0}, in grams: {1}", ss, ss / 15);
            #endregion
            #region Task#1.18
            int am = 10;
            for (int jj = 0; jj <= 24; jj = jj + 3)
            {
                am *= 2;
            }
            Console.WriteLine(am);
            #endregion
            #region Task#2.2
            int p = 1;
            int n1 = 1;
            int L = 30000;
            for (int ii = 1; ; ii += 3)
            {
                if (p <= L)
                {
                    p *= i;
                    n1 += 3;
                }
                else
                {
                    Console.WriteLine(n1);
                    break;
                }
            }
            #endregion
            #region Task#2.4
            double xx = Convert.ToDouble(Console.ReadLine());
            const double eps1 = 0.0001;
            double rez = 1.0;
            double aa;
            if ((Math.Abs(xx) < 1) && (Math.Abs(xx) >= eps1))
            {
                for (int i5 = 2; ; i5 = i5 + 2)
                {
                    aa = Math.Pow(xx, i5);
                    if (aa < eps1)
                        break;
                    rez += aa;
                }
                Console.WriteLine(rez);
            }
            else if (xx == 0)
            {
                Console.WriteLine(rez);
            }
            else
            {
                Console.WriteLine("Error");
            }
            #endregion
            #region Task#2.8
            double distance = 10.0;
            double speed = 10.0;
            bool br = false;
            for (int day = 2; ; day++)
            {
                speed *= 1.1;
                distance += speed;
                if (day == 7)
                {
                    Console.WriteLine("In 7 days: {0} km", distance);
                }
                if ((distance >= 100) && (br == false))
                {
                    br = true;
                    Console.WriteLine("After {0} distanse is 100 km", day);

                }
                if (speed > 20.0)
                {
                    Console.WriteLine("After {0} speed is more 20 km/days", day);
                    break;
                }

            }

            #endregion
            #region Task#2.9
            double vklad = 10_000.0;
            for (int month = 1; ; month++)
            {
                vklad *= 1.08;
                if (vklad >= 20_000)
                {
                    Console.WriteLine("After {0} the contribution will double", month);
                    break;
                }
            }
            #endregion
            #region Task#3.1
            const double xh = 0.1, xk = 1.0, h = 0.2, eps = 0.0001;
            double x3, y3, s3, a3;
            int n3 = (int)((xk - xh) / h + 1), i3;
            x3 = xh;
            for (int j3 = 1; j3 <= n3; j3++)
            {
                s3 = 1; a3 = 1; i3 = 1;
                do
                {
                    a3 = (-a3 * x3 * x3) / ((2 * i3 - 1) * 2 * i3);
                    s3 += a3;
                    i3 += 1;
                }
                while (Math.Abs(a3) >= eps);
                y3 = Math.Cos(x3);
                Console.WriteLine("x3= {0:f4} s3= {1:f4} y3= {2:f4}", x3, s3, y3);
                x3 += h;
            }
            #endregion
            #region Task#3.7
            const double xh7 = 0.1, xk7 = 1.0, h7 = 0.05, eps7 = 0.0001, E = 2.718281;
            double x7, y7, s7, a7;
            int n7 = (int)((xk7 - xh7) / h7 + 1), i7;
            x7 = xh7;
            for (int j7 = 1; j7 <= n7; j7++)
            {
                s7 = 1; a7 = 1; i7 = 1;
                do
                {
                    a7 = (a7 * x7 * x7) / ((2 * i7 - 1) * 2 * i7);
                    s7 += a7;
                    i7 += 17;
                }
                while (Math.Abs(a7) >= eps7);
                y7 = ((Math.Pow(E, x7)) + (Math.Pow(E, -x7))) / 2;
                Console.WriteLine("x7= {0:f4} s7= {1:f4} y7= {2:f4}", x7, s7, y7);
                x7 += h7;
            }
            #endregion
        }
    }

}
