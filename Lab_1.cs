using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Task 1 - 4
            double s = 0;
            double x = Convert.ToDouble(Console.ReadLine());
            for (int i = 1; i < 10; i++)
            {
                s += Math.Cos(x * i) / (Math.Pow(x, i - 1));
            }
            Console.WriteLine(s + "\n");
            #endregion
            
            #region Task 1 - 9
            double sum1 = 0;
            int fuct = 1;
            for (int i = 1; i < 7; i++)
            {
                fuct *= i;
                sum1 = Math.Pow(-1, i) * Math.Pow(5, i) / fuct;

            }
            Console.WriteLine(sum1 + "\n");
            #endregion



            #region Task 1 - 15
            int numer = 1;
            int denomin = 1;
            double sum2 = 0;
            for (int i = 1; i < 6; i++)
            {
                sum2 = numer / denomin;
                denomin = numer;
                numer = numer + denomin;
            }
            Console.WriteLine(sum2 + "\n");
            #endregion


            #region Task 1 - 16
            ulong count_grainds = 0;
            for (int i = 0; i < 64; i++)
            {
                count_grainds += (ulong)Math.Pow(2, i);
            }
            Console.WriteLine(count_grainds / 15 + "\n");

            #endregion



            #region Task 1 - 18
            int ameba = 10;
            for (int i = 3; i < 25; i += 3)
            {
                ameba *= 2;
                Console.WriteLine(ameba + " " + i + "\n");
            }
            #endregion



            #region Task 2 - 2
            int p = 1;
            int j = 1;
            while (p * j <= 30000)
            {
                p *= j;
                j += 3;
            }
            Console.WriteLine(j - 3 + " " + p + "\n");
            #endregion



            #region Task 2 - 4
            double x1 = Convert.ToDouble(Console.ReadLine());
            int n = 0;
            double sn = 0;
            while (Math.Pow(x1, 2 * n) >= 0.0001)
            {
                sn += Math.Pow(x1, 2 * n);
                n++;
            }
            Console.WriteLine(sn + "\n");
            #endregion



            
            #region Task 2 - 7/8

            double day_l = 10;
            double kilomet = 0;
            for (int i = 1; i < 8; i++)
            {
                kilomet += day_l;
                day_l += day_l * 0.1;
            }
            Console.WriteLine("Пробежит за 7 дней: " + kilomet);

            day_l = 10;
            int days = 0;
            kilomet = 0;
            while (kilomet < 100)
            {
                kilomet += day_l;
                day_l += day_l * 0.1;
                days += 1;
            }
            Console.WriteLine("За " + days + " дней пробежит спортсмен 100 км");

            day_l = 10;
            days = 1;
            while (day_l <= 20)
            {
                day_l += day_l * 0.1;
                days += 1;
            }
            Console.WriteLine(days + " - столько дней понадобится, чтобы спортсмен начал пробегать 20 км ежедневно" + "\n");

            #endregion


            #region Task 3 - 1
            double a = 0.1;
            int b = 1;
            double h = 0.1;
            double sum3 = 0;
            double intermid_value = 0;
            for (double x2 = a; x2 <= b; x2 += h)
            {
                int i1 = 1;
                int fuct2 = 1;

                while (true)
                {
                    fuct2 *= 2 * i1;
                    intermid_value = Math.Pow(-1, i1) * Math.Pow(x2, 2 * i1) / fuct2;
                    sum3 += intermid_value;

                    if (Math.Abs(intermid_value) < 0.0001)
                    {
                        Console.WriteLine("Значение функции y = " + Math.Cos(x2));
                        break;
                    }
                    i1++;
                }
            }
            Console.WriteLine("Значение s = " + sum3 + "\n");

            #endregion

            #region Task 3 - 7
            double a2 = 0.1;
            int b2 = 1;
            double h2 = 0.1;
            double sum4 = 0;
            double intermid_value2 = 0;
            for (double x2 = a2; x2 <= b2; x2 += h2)
            {
                int i2 = 1;
                int fuct3 = 1;

                while (true)
                {
                    fuct3 *= 2 * i2;
                    intermid_value2 = Math.Pow(x2, 2 * i2) / fuct3;
                    sum4 += intermid_value2;

                    if (Math.Abs(intermid_value2) < 0.0001)
                    {
                        Console.WriteLine("Значение функции y = " + (Math.Exp(x2) + Math.Exp(-1 * x2)) / 2);
                        break;
                    }
                    i2++;
                }
            }
            Console.WriteLine("Значение s = " + sum4);

            #endregion
        }
    }
}
