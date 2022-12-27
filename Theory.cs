using System;
namespace lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 1-4
            double x = Convert.ToDouble(Console.ReadLine());
            double S = Math.Cos(x);

            if (x != 0)
            {
                for (int i = 2; i < 9; i++)
                {
                    S += Math.Cos(i * x) / Math.Pow(x, i - 1);
                }
                Console.WriteLine(S);
            }
            else
            {
                Console.WriteLine("error");
            }
            #endregion
            #region 1-9
            {
                double S0 = 0;

                int h = 1;

                for (int i = 1; i < 7; i++)
                {
                    h *= i;
                    S0 += Math.Pow(-1, i) * Math.Pow(5, i) / h;
                }
                Console.WriteLine(S0);
            }
            #endregion
            #region 1-16
            {
                double sum = 0.0;
                double s = 1.0;
                for (int i = 1; i <= 64; i++)
                {
                    s *= 2;
                    sum += s;
                }
                Console.WriteLine($"Всего зерен: {sum}");
                Console.WriteLine($"Всего грамм: {sum / 15}");

            }
            #endregion
            #region 1-18
            {
                double g = 0;
                for (int i = 0; i <= 8; i++)
                {
                    g = 10 * Math.Pow(2, i);
                    Console.WriteLine(g);
                }
            }
            #endregion
            #region 1-15
            {
                double v = 0.0;
                double z1 = 1.0;
                double z2 = 1.0;
                double z3 = 2.0;
                double z4 = 1.0;
                double z5, z6;
                for (int i = 1; i <= 3; i++)
                {
                    z5 = z1 + z3;
                    z6 = z2 + z4;
                    v = z5 / z6;
                    z1 = z3;
                    z3 = z5;
                    z2 = z4;
                    z4 = z6;
                }
                Console.WriteLine(v);
            }
            #endregion
            #region 2-2
            {
                double p = 1;
                double n = 1;
                while (p <= 30000)
                {
                    n += 3;
                    p *= n;
                }
                Console.WriteLine(n);
            }
            #endregion
            #region 2-4
            {
                double s = 1;
                double n = 1;
                if (double.TryParse(Console.ReadLine(), out double x1) & Math.Abs(x1) < 1)
                {
                    while (x1 >= 0.0001)
                    {
                        s += Math.Pow(x1, n);
                        x1 = Math.Pow(x1, n);
                        n *= 2;
                    }
                    Console.WriteLine(s);
                }
                else
                {
                    Console.WriteLine("error");
                }
            }
            #endregion
            #region 2-7,8
            {
                int sv = 0, sv1 = 0;
                double s1 = 10.0;
                double s = 10.0;
                for (int i = 0; i <= 6; i++)
                {
                    s1 *= 1.1;
                    s += s1;
                    sv += 1;
                    if (s >= 100)
                    {
                        Console.WriteLine($"100 km {sv + 1}");
                        break;
                    }
                }
                Console.WriteLine($"7 days {s - s1}");
                s1 = 10;
                while (s1 < 20)
                {
                    s1 *= 1.1;
                    sv1 += 1;
                }
                Console.WriteLine($"20km in 1 day {sv1 + 1}");
            }
            #endregion
            #region 3-1
            {
                double s = 1.0;
                for (double l = 0.1; l <= 1; l += 0.1)
                {
                    l = Math.Round(l, 1);
                    int i = 0;
                    double t = 0.0;
                    double zxc = 1.0;
                    do
                    {
                        t = Math.Pow(-1, i) * Math.Pow(l, 2 * i) / zxc;
                        i++;
                        s += t;
                        zxc *= 2 * i * (2 * i - 1);
                    } while (t >= 0.0001);
                    double y = Math.Cos(l);
                    Console.WriteLine($"x = {l};    s = {s};    y = {y}");
                }
            }
            #endregion

            #region 3-9
            {
                double s = 1.0;
                for (double c = 0.1; c <= 0.5; c += 0.05)
                {
                    c = Math.Round(c, 3);
                    int i = 0;
                    double t = 0.0;
                    do
                    {
                        t = Math.Pow(-1, i) * (Math.Pow(c, 2 * i + 1) / (2 * i + 1));
                        i++;
                        s += t;
                    } while (t >= 0.0001);
                    double y = Math.Atan(c);
                    Console.WriteLine($"x = {c};    s = {s};    y = {y}");
                }
            }
            #endregion 

        }
    }
}
