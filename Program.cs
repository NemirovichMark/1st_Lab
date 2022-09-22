using System;
using System.Collections.Generic;
using static System.Console;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region First level

            #region Task 4

            double x4 = 0;
            double s4 = 0;
            int i4;
            double a4 = 0;

            WriteLine("enter x: ");
            if (double.TryParse(ReadLine(), out x4) && x4 != 0)
                for (i4 = 0; i4 <= 8; i4++)
                {
                    a4 = Math.Cos((i4 + 1) * x4) / (Math.Pow(x4, i4));
                    s4 = s4 + a4;
                }
            WriteLine($"Task 4: {s4}");

            #endregion


            #region Task 9

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
            WriteLine($"Task 9: {s9}");

            #endregion


            #region Task 15

            double firstchisl = 1, secondchisl = 2;
            double firstznam = 1, secondznam = 1;
            double total = 0;
            for (double i5 = 3; i5 <= 5; i5++)
            {
                total = firstchisl + secondchisl;
                firstchisl = secondchisl;
                secondchisl = total;

                total = firstznam + secondznam;
                firstznam = secondznam;
                secondznam = total;
            }
            WriteLine($"Task 15: {secondchisl / secondznam}");

            #endregion


            #region Task 16

            double corn = 1;
            for (double i6 = 0; i6 <= 63; i6++)
            {
                corn = corn + Math.Pow(2, i6);
            }
            WriteLine($"Task 16: Amount of grain: {corn}");
            corn = corn / 15;
            WriteLine($"Task 16: Amount of grain in grams: {corn}");

            #endregion


            #region Task 18

            double n8 = 10;
            double i8 = 3;
            for (i8 = 3; i8 <= 24; i8 = i8 + 3)
            {
                n8 = n8 * 2;
                WriteLine($"Task 18: {i8} number of hours = {n8} cells");
            }
            #endregion

            #endregion




            #region Second level

            #region Task 2

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
            WriteLine($"Task 2_2 : {n2}");

            #endregion



            #region Task 4

            double epsilon = 0.0001;
            double s_4 = 1;
            WriteLine($"enter x: ");
            double i_4 = 2;
            double x_4 = 1;

            if (double.TryParse(ReadLine(), out x_4) && Math.Abs(x_4) < 1)
            {
                while (Math.Pow(x_4, i_4) > epsilon)
                {
                    s_4 = s_4 + Math.Pow(x_4, i_4);
                    i_4 = i_4 * 2;
                }
            }
            WriteLine($"Task 2_4 : {s4}");

            #endregion

            #region Task 7,8

            #region a

            double day_a = 10;
            double way_a = 10;

            for (double i7 = 1; i7 < 7; i7++)
            {
                day_a *= 1.1;
                way_a += day_a;
            }
            WriteLine($"Task 2_7(a) : {way_a}");

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
            WriteLine($"Task 2_7(b) : {totaldays_b}");

            #endregion

            #region c

            double day_c = 10;
            double totaldays_c = 1;

            while (day_c <= 20)
            {
                day_c *= 1.1;
                totaldays_c += 1;
            }
            WriteLine($"Task 2_7(c) : {totaldays_c}");

            #endregion

            #endregion

            #endregion

            #region Third level

            #region Task 1

            double absolute = 0.0001;
            int i1 = 0;
            double x1 = 0;
            double s1 = 0;
            int factorial = 1;
            double y1;
            for (double a1 = 0.1; a1 <= 1; a1 += 0.1)
            {
                i1 = 0;
                factorial = 1;
                while (true)
                {
                    factorial *= 2 * (i1 * (i1 - 1));
                    x1 = Math.Pow(-1, i1) * Math.Pow(a1, 2 * i1) / factorial;
                    s1 += x1;

                    if ((x1 < absolute) || (x1 > -absolute))
                    {
                        y1 = Math.Cos(a1);
                        WriteLine($"Task 3_1 : s = {s1} f(x) = {y1}");
                        break;
                    }
                    i1 += 1;
                }
            }
            WriteLine();
            #endregion
            
            #region Task 7

            double absolute1 = 0.0001;
            int i_1 = 0;
            double xx = 0;
            double ss = 0;
            int factorial1 = 1;
            double yy;
            double exp = 2.718281828459045;

            for (double aa = 0.1; aa <= 1; aa += 0.05)
            {
                i_1 = 0;
                factorial1 = 1;
                while (true)
                {
                    factorial1 *= 2 * (i_1 * (i_1 - 1));
                    xx = Math.Pow(aa, 2 * i_1) / factorial1;
                    ss += xx;

                    if ((xx < absolute) || (xx > -absolute))
                    {
                        yy = (Math.Pow(exp, aa) + Math.Pow(exp, -aa)) / 2; 
                        WriteLine($"Task 3_7 : sum = {ss} f(x) = {yy}");
                        break;
                    }
                    i_1 += 1;
                }
            }

            #endregion

            #endregion          

        }

    }
}    
