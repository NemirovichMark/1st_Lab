using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics.CodeAnalysis;
using System.Diagnostics.Eventing.Reader;
using System.Globalization;
using System.Linq;
using System.Net.Security;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region

            double x;

            Console.WriteLine("Введите х");//4-ый номер 
            if (Double.TryParse(Console.ReadLine(), out x)&& x!=0) ;
            double s = 0, k, a;
            for (k = 0; k <= 8; k++)
            {
                a = Math.Cos((k + 1) * x) / (Math.Pow(x, k));
                s = s + a;
            }
            Console.WriteLine(s);
            #endregion



            double y;
            Console.WriteLine("Введите y");//Случайно сделал 12-ый номер
            if ((Double.TryParse(Console.ReadLine(), out y) && y!=0)) ;
            double ss = 1, kk;
            for (kk = 1; kk <= 10; kk++)
            {
                ss = ss + (1 / (Math.Pow(y, kk)));
            }
            Console.WriteLine(ss);


            #region
            double sum = 0;//9
            k = 1;
            for (int i = 1; i <= 6; i++)
            {
                k = 1;
                for (int j = 1; j <= i; j++)
                {
                    k *= j;
                }
                sum = sum + Math.Pow(-1, i) * Math.Pow(5, i) / k;
            }

            Console.WriteLine(sum);
            #endregion

            double n2 = 2,y2=1,n1=1,y1=1,sny=0;
            for (int i=3;i<=5;i++)
            {
                sny = n1 + n2;
                n1 = n2;
                n2 = sny;
                sny = y1 + y2;
                y1 = y2;
                y2 = sny;
            }
            Console.WriteLine(n2 / y2);

            double zern = 1, lol = 0;//16
            for (double i = 2; i <= 63; i++)
            {
                zern = zern + Math.Pow(2, i);
            }
            lol = zern / 15;
            Console.WriteLine($"{lol} grams");//Если быть точнее,там получается целое число 1 229 782 938 247 303 441 (так что с полной точностью получен результат)

            #region
            double aa = 10;//18
            for (int i = 3; i <= 24; i = i + 3)
            {
                aa *= 2;
                Console.WriteLine($"Количество часов {i}={aa} клеток");
            }
            Console.WriteLine();
            #endregion

            double p = 1, kl = 1;//2 из второго уровня
            for (int nn = 1; p * nn <= 30000; nn += 3)
            {
                p *= nn;
                kl = nn;
            }
            Console.WriteLine(kl);




            Console.WriteLine("Введите x");// 4
            double x1, s1 = 1, lp = 2;
            if (double.TryParse(Console.ReadLine(), out x1) && Math.Abs(x1) < 1)
            {
                while (Math.Pow(x1, lp) > 0.0001)
                {
                    s1 = s1 + Math.Pow(x1, lp);
                    lp = lp + 2;
                }

            }
            Console.WriteLine(s1);


            double sum1 = 10, a3 = 10;//8a
            for (int i = 1; i <= 6; i++)
            {
                a3 = a3 * 1.1;
                sum1 = sum1 + a3;
            }
            Console.WriteLine(sum1);


            double suma = 10, a4 = 10, v = 1;//8b
            while (suma <= 100)
            {
                a4 = a4 * 1.1;
                suma = suma + a4;
                v = v + 1;
            }
            Console.WriteLine($"Через {v} дней");


            double u = 10, dn = 1;//8в
            while (u <= 20)
            {
                u = u * 1.1;
                dn = dn + 1;
            }
            Console.WriteLine($"Через {dn} дней");


            #region
            
            double a0 = 0.1, b = 1, h = 0.1, xx, g = 1, summa = 0,io;
            for (xx = a0; xx <= b + 0.0001; xx = xx + h)
            {
                summa = 1;
                g = 1;
                io = 2;
                for (int i = 1; Math.Abs(g) >= 0.0001; i++)
                {
                     if (i>2)
                    {
                        io *= i * (i - 1);
                    }
                    
                    g = (Math.Pow(-1, i)) * (Math.Pow(xx, 2 * i) / io );

                    summa = summa + g;
                }
                y = Math.Cos(xx);
                Console.WriteLine($"x={xx} \t y={Math.Round(y, 3)} \t s={Math.Round(summa, 3)}");
            }
            #endregion



            double PI= 3.1415926535897931,sle,sprav,shag,gg,summa2,yy;//5-ая
            sle = PI / 5;
            sprav = PI;
            shag = PI / 25;
            for (double x2=sle;x2<=sprav+0.00001;x2=x2+shag)
            {
                summa2 = 0;
                gg = 1;
                for (int i=1; Math.Abs(gg) >= 0.0001;i++)
                {
                    gg=(Math.Pow(-1, i)) * (Math.Cos(i*x2)/Math.Pow(i,2));
                    summa2 = summa2 + gg;
                }
                yy=(Math.Pow(x2,2)-(Math.Pow(PI,2)/3))/4;
                Console.WriteLine($"x={x2} \t y={Math.Round(yy, 3)} \t s={Math.Round(summa2, 3)}");
            }














        }
    }
}
