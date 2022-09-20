using System;


namespace _1st
{
    internal class Program
    {
        static void Main()
        {
            #region lvl1 - 4
            Console.WriteLine("enter x");
            long x = int.Parse(Console.ReadLine());
            double s = Math.Cos(x);
            double m;
            if (x == 0)
            {
                Console.WriteLine("ban blyat");
            }
            else
            {
                for (m = 1; m < 9; m++)
                {
                    s += Math.Cos((m + 1) * x) / Math.Pow(x, m);
                }
                Console.WriteLine(s);
            }
            #endregion



            #region lvl1 - 9

            double s = 0;
            int m;
            double e = 1;
            for (m = 1; m < 7; m++)
            {
                e *= m;
                s += Math.Pow(-1, m) * Math.Pow(5, m) / e;
            }
            Console.WriteLine(s);

            #endregion

            #region lvl1 - 15

            double s;
            double ver = 0, niz = 0;
            double ver1 = 2, niz1 = 1, niz2 = 1, ver2 = 1;
            for (int i = 1; i < 4; i++)
            {
                ver = ver1 + ver2;
                niz = niz1 + niz2;
                ver2 = ver1;
                ver1 = ver;
                niz2 = niz1;
                niz1 = niz;
            }
            Console.WriteLine(niz / ver);
            #endregion

            #region lvl1 - 16
            ulong vl = 2;
            ulong grain = 0;
            for (int pow = 1; pow <= 64; pow++)
            {
                grain = (ulong)Math.Pow(vl, pow) - 1;
            }
            Console.WriteLine("Количество зёрен");
            Console.WriteLine(grain);
            #endregion

            #region lvl1 - 18

            int d = 10;
            for (int i = 3; i < 25; i += 3)
            {
                d = d * 2;
                Console.WriteLine(" количество амёб " + d + " прошедшее время(часы) " + i);
            }

            #endregion

            #region lvl2 2
            int p = 1;
            int n;
            for (n = 1; p * n < 30000; n += 3)
            {
                p *= n;
            }
            Console.WriteLine(n - 3);
            #endregion

            
            #region lvl2 4
            double x, s = 1;

            x = Convert.ToDouble(Console.ReadLine());

            if (Math.Abs(x) >= 1)
                Console.WriteLine("|x| >= 1");
            else
            {
                for (int i = 1; (x / (2 * i)) > 0.0001; i++)
                {
                    s += x / (2 * i);
                }
                Console.WriteLine("s = {0}", s);

            }
            #endregion

            
            #region lvl2 7-8
            double d_1_dist = 10;
            double s7;
            double Alldist = 0;
            double distfor7d;
            int nd = 1;
            for (; nd <= 6; nd += 1)
            {
                s7 = d_1_dist + (d_1_dist * 0.1);
                d_1_dist = s7;
                Alldist += s7;
            }
            distfor7d = Alldist + 10;
            Console.WriteLine($"путь за 7 дней {distfor7d}");
            d_1_dist = 10;
            Alldist = 0;
            nd = 1;
            while (Alldist < 100)
            {
                s7 = d_1_dist + (d_1_dist * 0.1);
                d_1_dist = s7;
                Alldist += s7;
                nd += 1;
            }
            Console.WriteLine($"кол-во дней до 100км общ. пути {nd}");
            d_1_dist = 10;
            nd = 1;
            while (d_1_dist < 20)
            {
                d_1_dist += d_1_dist * 0.1;
                nd += 1;
            }
            Console.WriteLine($"кол-во дней до 20+км/день {nd}");
            #endregion

            
            #region lvl3 1
            for (double x = 0.1; x <= 1; x += 0.1)
            {
                double s = 1;
                int i = 1;
                double i0 = 2;
                while (true)
                {
                    if (i > 2)
                    {
                        i0 = i0 * (i0 * (i - 1));
                    }
                    double a = 0;
                    a = (Math.Pow(-1, i) * Math.Pow(x, 2 * i) / i0);
                    if (Math.Abs(a) < 0.0001)
                    {
                        break;
                    }
                    s += a;
                    i++;
                }
                Console.WriteLine($"X: {x}; S: {s};  Y: {Math.Cos(x)};");
            }
            #endregion

            #region lvl3 4
            for (double x = 0.1; x <= 1; x += 0.1)
            {
                double s = 0;
                int i = 0;
                double z = Math.Pow(Math.E, x);
                double i0 = 2;
                while (true)
                {
                    if (i > 2)
                    {
                        i0 = i0 * (i0 * (i - 1));
                    }
                    double a = 0;
                    a = (2 * i + 1) * Math.Pow(x, 2 * i) / i0;
                    if (Math.Abs(a) < 0.0001)
                    {
                        break;
                    }
                    s += a;
                    i++;
                }

                double y = ((1 + 2 * Math.Pow(x, 2)) * Math.Pow(z, 2));
                Console.WriteLine($"X: {x}; S: {s};  Y: {y};"); ;
            }
            #endregion
        }

        public static double Fact(int n)
        {
            if (n == 0)
                return 1;
            else
                return n * Fact(n - 1);
        }
        public static double Fibonachi(int n)
        {
            if (n == 0 || n == 1) return n;

            return Fibonachi(n - 1) + Fibonachi(n - 2);
        }
    }
}
