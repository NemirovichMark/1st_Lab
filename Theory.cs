using System;

namespace _1st_Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            #region task 1.1.4

            double x;
            double.TryParse(Console.ReadLine(), out x);
            while (x == 0)
            {
                Console.WriteLine("x cannot be zero");
                double.TryParse(Console.ReadLine(), out x);
            }
            double s = 0.0, a, b = 1.0;
            for (int i = 1; i <= 9; i = i + 1)
            {
                a = Math.Cos(i * x) / b;
                s = s + a;
                b = b * x;
            }
            Console.WriteLine($"s = {s}");

            #endregion


            #region task 1.1.9

            double s_q = 0.0, a_q, p = 1.0;
            int d = 1, m = 5;
            for (int i = 1; i <= 6; i = i + 1)
            {
                d = d * i;
                a_q=-p*m/d;
                s_q=s_q+a_q;
                p = -p;
                m = 5 * m;
            }
            Console.WriteLine($"s = {s_q}");

            #endregion


            #region task 1.1.15
            double nth = 0.0, a_w = 2.0, b_w = 1.0;
            double c = 1, d_w = 1, m_w, l;
            for (int i = 1; i <= 3; i = i + 1)
            {
                nth = (a_w+c)/(b_w+d_w);
                m_w = c;
                c = a_w;
                a_w = a_w + m_w;
                l = d_w;
                d_w = b_w;
                b_w = b_w + l;
            }
            Console.WriteLine($"nth = {nth}");

            #endregion


            #region task 1.1.16

            double amount = 0, amount_tonns = 0, real_amount = 0;
            double a_e = 1;
            for (int i = 1; i <= 8; i = i + 1)
            {
                for (int j = 1; j <= 8; j = j + 1)
                {
                    a_e = a_e * 2;
                    amount = (amount + a_e);
                }
                amount_tonns = amount / 15000000000;
                real_amount = real_amount + amount_tonns;
            }
            Console.WriteLine($"amount of grain (thousands of tonns) = {real_amount}");

            #endregion


            #region task 1.1.18

            int sum = 10;
            for (int i = 3; i <= 24; i = i + 3)
            {
                sum = sum * 2;
                Console.WriteLine($"sum = {sum} at {i} hour");
            }

            #endregion


            #region task 1.2.2

            int p_r = 1, n = 1;
            while (p_r<=30000)
            {
                p_r = p_r * n;
                n = n + 3;
            }
            n = n - 6;
            Console.WriteLine($"n = {n}");


            #endregion


            #region task 1.2.4

            double x_t;
            double.TryParse(Console.ReadLine(), out x_t);
            while (Math.Abs(x_t)>=1)
            {
                Console.WriteLine("-1 < x < 1");
                double.TryParse(Console.ReadLine(), out x_t);
            }
            double s_t = 0.0, a_t = 1.0;
            while (a_t>=0.0001)
            {
                s_t = s_t + a_t;
                a_t = x_t * x_t * a_t;
            }
            Console.WriteLine($"s = {s_t}");

            #endregion


            #region task 1.2.7-8 (a)

            double length = 10.0, sum_length = 10.0;
            for (int i = 1; i <= 6; i = i + 1)
            {
                sum_length = sum_length * 1.1;
                length = sum_length + length;
            }
            Console.WriteLine($"a) sum length = {length}");

            #endregion


            #region task 1.2.7-8 (b)

            double whole_length = 10.0, daily_length = 10.0;
            int day = 1;
            while (whole_length < 100)
            {
                daily_length = daily_length * 1.1;
                whole_length = whole_length + daily_length;
                day =day + 1;
            }
            Console.WriteLine($"b) day = {day}");

            #endregion


            #region task 1.2.7-8 (c)

            int day_more = 1;
            double length_day = 10.0;
            while (length_day < 20)
            {
                length_day = length_day * 1.1;
                day_more = day_more + 1;
            }
            Console.WriteLine($"c) day = {day_more}");

            #endregion


            #region task 1.3.1

            double z, y, с, fx;
            int ij;
            double yh = 0.1, yk = 1.0, h = 0.1;
            y = yh;
            for (y = yh; y <= yk + 0.0001; y=y+h)
            {
                z = 1.0;
                c = 1;
                ij = 1;
                do
                {
                    c = (-c) * y * y / ((2 * ij - 1) * 2 * ij);
                    z = z + c;
                    ij = ij + 1;
                } while (Math.Abs(c) >= 0.0001);
                fx = Math.Cos(y);
                Console.WriteLine($"x = {y}, s = {z}, f(x) = {fx}");
            }

            #endregion


            #region task 1.3.7

            Console.WriteLine($"3 level task for my choice");

            double ss, xx, cc, yy, v, vv;
            int ii;
            double xxh = 0.1, xxk = 1.0, hh = 0.05;
            xx = xxh;
            for (xx = xxh; xx <= xxk + 0.0001; xx = xx + hh)
            {
                ss = 1.0;
                cc = 1;
                ii = 1;
                do
                {
                    cc = cc * xx * xx / ((2 * ii - 1) * 2 * ii);
                    ss = ss + cc;
                    ii = ii + 1;
                } while (Math.Abs(cc) >= 0.0001);
                vv = Math.Exp(xx);
                v = Math.Exp(-xx);
                yy = (vv+v)/2;
                Console.WriteLine($"x = {xx}, s = {ss}, f(x) = {yy}");
            }

            #endregion

        }
    }
}
