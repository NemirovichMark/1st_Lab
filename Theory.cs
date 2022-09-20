using System;
using System.ComponentModel;
using System.Threading.Channels;

namespace _1st_Lab_3_Level
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-----3 Level-----");
            Console.WriteLine("-----1 Task-----");
            #region 1TASK_3Level
            const double a = 0.1, b = 1, h = 0.1, eps = 0.0001;
            double x = 0;
            double q, chisl, znam, s;
            int fact, p, i;
            for (int n = 0; n < 10; n++)
            {
                q = 1;
                s = 0;
                fact = 1;
                p = 1;
                i = 0;
                x += 0.1;
                do
                {
                    chisl = p * Math.Pow(x, 2 * i);
                    znam = fact;
                    q = chisl / znam;
                    s += q;
                    i++;
                    p = -p;
                    fact *= 2 * i * (2 * i - 1);
            
                } while (Math.Abs(q) >= eps);
                double y = Math.Cos(x);
                Console.WriteLine($"s: {s}, y: {y}, x: {x}");
            }
            
            
            #endregion
            Console.WriteLine("-----5 Task-----");
            #region 5TASK_3Level
            
            const double aa = Math.PI / 5, bb = Math.PI, hh = Math.PI / 25;
            double step = (bb - aa) / hh;
            double x1 = aa;
            for (int n = 0; n < step; n++)
            {
                q = 1;
                s = 0;
                p = -1;
                i = 1;
                do
                {
                    chisl = p * Math.Cos(i * x1);
                    znam = Math.Pow(i, 2);
                    q = chisl / znam;
                    s += q;
                    i++;
                    p = -p;
            
                } while (Math.Abs(q) >= eps);
                double y = ((x1 * x1) - (Math.PI * Math.PI) / 3) / 4;
                Console.WriteLine($"s: {s}, y: {y}, x: {x1}");
                x1 += hh;
            }
            
            #endregion
            Console.WriteLine("-----1 Level-----");
            Console.WriteLine("-----4 Task-----");
            s = 0;
            q = 0;
            #region 4Task_1Level
            
            int f, c1, z1, c2, z2, c, zn;
            double z;
            Console.WriteLine("Введите x:");
            double.TryParse(Console.ReadLine(), out x);
            if (x == 0)
            {
                Console.WriteLine("S cannot be counted");
            }
            else
            {
                z = (1 / x);
                for (int n = 1; n <= 9; n++)
                {
                    q = Math.Cos(x * n) / (z * Math.Pow(x, n));
                    s += q;
                }

                Console.WriteLine($"Итоговая сумма: {s}");
            }
            
            #endregion

            q = 0;
            s = 0;
            p = -1;
            f = 1;
            Console.WriteLine("-----9 Task-----");
            #region 9Task_1Level

            for (int n = 1; n <= 6; n++)
            {
                q = p * Math.Pow(5, n) / f;
                s += q;
                f *= (n + 1);
                p = -p;
            }

            Console.WriteLine($"Итогавая сумма: {s}");
            #endregion

            c1 = 1;
            z1 = 1;
            c2 = 2;
            z2 = 1;
            c = 0;
            zn = 0;
            Console.WriteLine("-----15 Task-----");
            #region 15Task_1Level

            for (int n = 3; n <= 5; n++)
            {
                c = c1;
                zn = z1;
                c1 = c2;
                z1 = z2;
                c2 += c;
                z2 += zn;


            }
            Console.WriteLine($"Числитель: {c2}, знаменатель: {z2}");

            #endregion
            Console.WriteLine("-----16 Task-----");
            ulong ss = 1;
            ulong qq = 1;
            #region 16Task_1Level

            for (int n = 1; n <= 64; n++)
            {
                qq *= 2;
                ss += qq;
            }

            Console.WriteLine($"Зерен - {ss / 15} грамм");
            //ответ не точный, так как число не влезает даже в UINT64

            #endregion
            Console.WriteLine("-----18 Task-----");
            q = 10;
            #region 18Task_1Level
            for (int n = 3; n <= 24; n += 3)
            {
                q *= 2;
                Console.WriteLine($"Спустя {n} часов - {q} амёб");
            }
            #endregion
            Console.WriteLine("-----2 Level-----");
            Console.WriteLine("-----2 Task-----");
            s = 1;
            #region 2Task_2Level

            double pp = 1;
            do
            {
                s *= pp;
                pp += 3;
            } while ((s * pp) < 30000);

            Console.WriteLine($"Наибольшее значение сомножителя - {pp - 3}");

            #endregion

            q = 0;
            s = 0;
            z = 1;
            Console.WriteLine("-----4 Task-----");
            #region 4Task_2Level
            
            double xx;
            Console.WriteLine("Введите xx:");
            double.TryParse(Console.ReadLine(), out xx);
            do
            {
                z = Math.Pow(xx, q);
                s += z;
                q += 2;

            } while (Math.Abs(z) >= eps);

            Console.WriteLine($"Полученная сумма - {s}");
            #endregion

            q = 1;
            s = 10;
            z = 0;
            x = 0;
            Console.WriteLine("-----7-8 Task-----");
            #region 78Task_2Level

            while (z != 3)
            {
                x = 0.1 * s;
                s += x;
                q++;
                if (q == 7)
                {
                    Console.WriteLine($"Суммарный путь за 7 дней - {Math.Round(s, 4)} км");
                    z += 1;
                }

                if (s >= 100 & (z + 1) != 3)
                {
                    Console.WriteLine($"Спротсмен пробежит суммарный путь 100 км через - {q} дней");
                    z += 1;
                }
                if (x >= 20)
                {
                    Console.WriteLine($"Спротсмен будет пробегать в день больше 20 км через - {q} дней");
                    z += 1;
                }

            }
            

            #endregion
        }
    }
}
