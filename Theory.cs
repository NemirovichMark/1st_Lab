using System;

namespace _1st_Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            #region task4
            double x;
            bool result = double.TryParse(Console.ReadLine(),out x);
            double s = 0;
            double c = 1.0;
            if (result)
            {
                for (int i = 1; i <= 9; i++)
                {
                    if (c!=0)
                    {
                        s = s + Math.Cos(x * i) / c;
                        c = c * x;
                    }
                    else
                    {
                        Console.WriteLine("Enter another number");
                        break;
                    }
    
                }
                Console.WriteLine($"Answer for the 4th task {s}");
            }
            else
            {
                Console.WriteLine("Operation is not available");
            }
            #endregion
            #region Task9
            {
                int k = -1;
                double l = 5;
                double n = 1;
                double ss = 0;
                int i = 1;
                for (int i9=1;i9<=6;i9+=1)
                {
                    ss += k * l / n;
                    i++;
                    n = n * i;
                    k = -k;
                    l *= l;
                }
                Console.WriteLine($"Answer for the 9th task {ss}");

            }
            #endregion
            # region Task15
            {
                int ch1 = 1;
                int zn1 = 1;
                int ch2 = 2;
                int zn2 = 1;
                int chis;
                int znam;
                for (int turn=0; turn<=3;turn++)
                {
                    chis = ch1;
                    znam = zn1;
                    ch1 = ch2;
                    zn1 = zn2;
                    zn2 += znam;
                    ch2 += chis;
                }
                Console.WriteLine("Ans for 15 task:");
                Console.WriteLine($"Numerator:{ch1} ,Denominator:{zn1}");
            }
            #endregion
            #region Task16
            {
                ulong sum = 0;
                ulong v = 1;
                for (int gg = 0; gg <= 64; gg=gg+1)
                {
                    sum += v;
                    v = v * 2;
                }
                sum = sum / 15;
                Console.WriteLine($"Answer for the 16th task {sum}");
            }
            #endregion
            #region Task18
            {
                Console.WriteLine("Answers for 18th Task");
                int kolvo = 10;
                for (int hour=3; hour<=24; hour+=3)
                {
                    kolvo = kolvo * 2;
                    Console.WriteLine("hour={0:f2}\tkolvo={1:f2}",hour,kolvo);
                }

            }
            #endregion
            #region Task2.2
            int per =1;
            int j = 0;
            int t = 1;
            int L = 30000;
            while (per<=L)
            {
                per = per * t;
                if (per > L)
                {
                    j = t - 3;
                }
                else
                {
                    j = t;
                    t += 3;
                }    
            }
            Console.WriteLine($"Answer for the 2.2 task is {j}");
            #endregion
            #region Task2.4
            {
                double x1;
                bool success = double.TryParse(Console.ReadLine(),out x1);
                double e = 0.0001;
                double sum = 1;
                if (success)
                {
                    while (x1 > e)
                    {
                        if (x1 > e)
                        {
                            x1 = x1 * x1;
                            sum += x1;
                        }
                        else
                        {
                            sum = sum - x1;
                        }
                    }

                    Console.WriteLine($"Answer for the 2.4 task is {sum}");
                }
                else
                {
                    Console.WriteLine("BAD VALUE");
                }
            }
            #endregion
            #region Task2.(7-8)
            {
                double a0 = 10;
                double summary = 0;
                int km = 20;
                int answer = 1;
                int mar = 100;
                for (int y = 1; y <= 7; y++)
                {
                    summary += a0;
                    a0 = 1.1 * a0;
                    //Console.WriteLine(a0);//Почему в конце числа еще цифры

                }
                Console.WriteLine($"Route for 7 days is {summary}");
                summary = 0;
                a0 = 10;
                int day = 0;
                while (summary < mar)
                {
                    summary += a0;
                    a0 = 1.1 * a0;
                    day += 1;
                }
                Console.WriteLine($"Will run more than 100km after {day}");
                a0 = 10;
                while (a0<=km)
                {
                    a0 = a0 * 1.1;
                    answer += 1;  
                }
                Console.WriteLine($"Will run more than 20km per day after {answer}");
            }
            #endregion
            #region Task3.1
            {
                const double a = 0.1;
                const int b = 1;
                double h = 0.1;
                double steps,y;
                double lose = 0.0001;
                double x11 = a;
                steps = (b - a) / h+1;
                for (int r=0;r<steps;r++)
                {
                    int fst = 1;
                    int i = 0;
                    double scn;
                    s = 0;
                    double fac=1;
                    do
                    {
                        scn =fst* Math.Pow(x11, 2 * i) / fac;
                        s += scn;
                        i += 1;
                        fac *= ((2 * i - 1) * 2 * i);
                        fst = -fst;

                    } while (Math.Abs(scn) > lose);
                    y = Math.Cos(x11);
                    Console.WriteLine("x11={0:f4} s={1:f4} y={2:f4}", x11, s, y);
                    x11 = x11 + h;
                }
                Console.WriteLine("end of 3.1 Task");
            }
            #endregion
            #region Task3.6
            {
                const double a6 = 0.1;
                const int b6 = 1;
                const double h6 = 0.05;
                int repets = (int)((b6 - a6) / h6 + 1);
                double x6 = a6;
                double eps6 = 0.0001;
                double y6;
                for (int qw=0;qw<repets;qw++)
                {
                    int kf = 1;
                    int i6 = 1;
                    double s6 = 0;
                    double isk6;
                    do
                    {
                        isk6 = kf * (Math.Pow(x6, 2 * i6 + 1) / (4 * i6 * i6 - 1));
                        s6 += isk6;
                        i6++;
                        kf = -kf;
                    } while (Math.Abs(isk6) > eps6);
                    y6 = ((1 + x6 * x6) * Math.Atan(x6) - x6) / 2;
                    Console.WriteLine("x6 {0:f4} s6 {1:f4} y6 {2:f4}", x6, s6, y6);
                    x6 = x6 + h6;
                }
            }
            #endregion
        }


    }
}
