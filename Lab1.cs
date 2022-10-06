using System;
namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 1.4
            Console.WriteLine($"Task 1.4");
            double x_3;
            Console.WriteLine($"Enter x");
            double.TryParse(Console.ReadLine(), out x_3);
            double stask4 = 0;
            if (x_3 == 0)
            {
                Console.WriteLine($"Not correct (div by zero)");
                return;
            }
            for (int l = 1; l <= 9; l++)
            {
                stask4 += Math.Cos(l * x_3) / (Math.Pow(x_3, l - 1));
            }
            Console.WriteLine($" The s for task 1.4 is {stask4}");
            #endregion
            #region 1.9
            Console.WriteLine($"Task 1.9");
            double Fac = 1;
            double stask9 = 0;
            if (Fac == 0)
            {
                Console.WriteLine($"incorrect");
            }    
            for (int b = 1; b <= 6; b++)
            {
                if (b == 1) { Fac = 1; }
                Fac *= b;
                stask9 += (Math.Pow(-1, b) * Math.Pow(5, b)) / Fac;

            }
            Console.WriteLine($" s for task 1.9 is {stask9}");
            //The check is here https://www.wolframalpha.com/input?i=%28%28–1%29%5E1·5%5E1%29+%2F1%21+%2B+%28%28–1%29%5E2+·5%5E2%29+%2F2%21+%2B+%28%28–1%29%5E3·5%5E3%29+%2F3%21+%2B+%28%28–1%29%5E4+·5%5E4%29+%2F4%21+%2B+%28%28–1%29%5E5·5%5E5%29+%2F5%21+%2B+%28%28–1%29%5E6+·5%5E6%29+%2F6%21

            #endregion
            #region 1.15
            Console.WriteLine($"Task 1.15");
            double prev_a2 = 2;
            double prev_b2 = 1;
            double prev_a1 = 3;
            double prev_b1 = 2;
            double cur_a = 0;
            double cur_b = 0;

            for (int i = 4; i <= 5; i = i + 1)
            {
                cur_a = prev_a1 + prev_a2;
                cur_b = prev_b1 + prev_b2;
                prev_a2 = prev_a1;
                prev_b2 = prev_b1;
                prev_a1 = cur_a;
                prev_b1 = cur_b;
            }

            Console.WriteLine($" Our term of the sequence is {cur_a}/{cur_b}");
            #endregion
            #region 1.16
            Console.WriteLine($"Task 1.16");
            double summseed = 0;
            double quan = 1;
            for (int kl = 1; kl <= 64; kl++)
            {
                quan *= 2;
                summseed += quan;
            }
            Console.WriteLine($"The amount of seeds is {summseed} the weigth of seeds is {summseed/15}");
            #endregion
            #region 1.18
            Console.WriteLine($"Task 1.18");
            double amoeba = 10;
            for (int i = 3; i <= 24; i += 3)
            {
                amoeba *= 2;
                Console.WriteLine($"The amount of amoebas after {i} hrs is {amoeba} ");


            }

            #endregion
            #region 2.2
            Console.WriteLine($"Task 2.2");
            int u = 1;
            int result = 1;
            for (int i = 1; ; i += 3)
            {
                if (u <= 30000)
                {
                    u *= i;
                    result = i - 3;
                }
                else
                {
                    Console.WriteLine($"The biggest number is {result}");
                    break;
                }
                
            }
            #endregion
            #region 2.4
            Console.WriteLine($"Task 2.4");
            double xx = -0.1;
            const double e = 0.0001;
            double summ = 0.0;
            double s = xx * xx;
            if (Math.Abs(xx) < 1)
            {
                while (Math.Abs(s) > e)
                {
                    summ = summ + s;
                    s = s * xx * xx;
                }
                Console.WriteLine($"The answer is {summ}");
            }
            else
            {
                Console.WriteLine($" x out of range");
            }

            #endregion
            #region 2.7 and 2.8
            Console.WriteLine($"Task 2.7 and 2.8");
            int day = 0;
            int dayForC = 0;
            double dayNormForC = 10;
            double dayNorm = 10;
            double summDistance = 0;
            double ans_a = 0;
            double ans_b = 0;
            double ans_c = 0;
            for (int i = 1; i <= 7; i++)
            {
                dayNorm *= 1.1;
                summDistance += dayNorm;
                day++;
                if (summDistance >= 100)
                {
                    ans_b = day;
                    break;
                }
            }
            for (int n = 1; ; n++)
            {
                dayNormForC *= 1.1;
                dayForC++;
                if (dayNormForC > 20)
                {
                    ans_c = dayForC;
                    break;
                }
            }

            ans_a = summDistance;
            Console.WriteLine($" answer for a) is {ans_a}");
            Console.WriteLine($" answer for b) is {ans_b}");
            Console.WriteLine($" answer for c) is {ans_c}");


            #endregion
            #region 3.1
            Console.WriteLine("Task 3.1");
            double a = 0.1;
            double bb = 1.0;
            double h = 0.1;
            double sume = 1.0;
            double devi;
            double t;
            double c;
            for (double x = a; x <= bb; x += h)
            {
                x = Math.Round(x, 1);
                t = 0.0;
                int j = 0;
                devi = 1.0;
                c = -1;
                do
                {
                    c = -c;
                    t = c * Math.Pow(x, 2 * j) / devi;
                    j++;
                    sume += t;
                    devi *= 2 * j * (2 * j - 1);

                }
                while (t >= 0.0001);
                double y = Math.Cos(x);
                Console.WriteLine($" x is {x} s is {sume}; y = {y}");

                Console.WriteLine(sume);
            }
            #endregion
            #region 3.9
            Console.WriteLine("Task 3.9");
            double summ_9 = 0.0;
            double a_9 = 0.1;
            double b_9 = 0.5;
            double h_9 = 0.05;
            double t_9;
            double j_9;
            double c_9;
            for (double x_9 = a_9; x_9 <= b_9; x_9 += h_9)
            {
                x_9 = Math.Round(x_9, 2);
                t_9 = 0.0;
                j_9 = 0.0;
                c_9 = -1;
                do
                {
                    c_9 = -c_9;
                    t_9 = c_9 * Math.Pow(x_9, 2 * j_9 + 1) / (2 * j_9 + 1);
                    j_9++;
                    summ_9 += t_9;
                }
                while (t_9 >= 0.0001);
                double y_9 = Math.Atan(x_9);
                Console.WriteLine($" x is {x_9} s is {summ_9} y is {y_9}");
            }
            Console.WriteLine(summ_9);
            
            #endregion














        }

    }













}