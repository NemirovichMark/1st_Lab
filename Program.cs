using System;


namespace lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            //goto used to test the tasks faster, not as a part of the program (please don't kill me)
            //goto task_9_lv1;
            //goto task_15_lv1;
            //goto task_16_lv1;
            //goto task_18_lv1;

            //goto task_2_lv2;
            //goto task_4_lv2;
            //goto tasks_7_8_lv2;

            //goto task_1_lv3;
            //goto task_9_lv3;

            #region task 4 lv1
            Console.WriteLine("Task 4 (level 1)");

            double s, a, x;
            double b = 1;

            Console.WriteLine("Enter x value.");

            try
            {
                x = double.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("");
                Console.WriteLine("Incorrect input.");
                Console.ReadLine();
                return;
            }

            Console.WriteLine("");
            Console.WriteLine($"The x value is {x}.");

            if (x == 0)
            {
                Console.WriteLine("s can not be calculated.");
                Console.ReadLine();
                return;
            }

            s = Math.Cos(x);
            for (int i = 2; i <= 9; i = i + 1)
            {
                a = Math.Cos(i * x);
                b = b * x;
                s = s + a / b;
            }

            Console.WriteLine($"s = {s}.");

            //test (for myself)
            //double s2 = Math.Cos(x) + Math.Cos(2 * x) / x + Math.Cos(3 * x) / Math.Pow(x, 2) + Math.Cos(4 * x) / Math.Pow(x, 3) + Math.Cos(5 * x) / Math.Pow(x, 4) + Math.Cos(6 * x) / Math.Pow(x, 5) + Math.Cos(7 * x) / Math.Pow(x, 6) + Math.Cos(8 * x) / Math.Pow(x, 7) + Math.Cos(9 * x) / Math.Pow(x, 8);
            //Console.WriteLine(s2);
            Console.ReadLine();

        #endregion

        task_9_lv1:
            #region task 9 lv1
            Console.WriteLine("Task 9 (level 1)");

            double ss = 0;
            double aa = 1;
            double bb = 1;
            double cc = 1;

            for (int i = 1; i <= 6; i = i + 1)
            {
                aa = aa * (-1);
                bb = bb * 5;
                cc = cc * i;
                ss = ss + aa * bb / cc;
            }

            Console.WriteLine($"s = {ss}.");
            Console.ReadLine();

        #endregion

        task_15_lv1:
            #region task 15 lv1
            Console.WriteLine("Task 15 (level 1)");

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

            Console.WriteLine($"The 5th term of the sequence is {cur_a}/{cur_b} or " + (cur_a/cur_b) + ".");
            Console.ReadLine();

        #endregion

        task_16_lv1:
            #region task 16 lv1
            Console.WriteLine("Task 16 (level 1)");
            ulong total = 1;
            ulong cur = 1;

            for (int i = 2; i <= 64; i = i + 1)
            {
                cur = cur * 2;
                total = total + cur;
                //Console.WriteLine(total);
            }

            Console.WriteLine($"The final result is {total} rice grains or around {total / 15} grams.");
            Console.ReadLine();

        #endregion

        task_18_lv1:
            #region task 18 lv1
            Console.WriteLine("Task 18 (level 1)");
            int cells = 10;
            for (int i = 3; i <= 24; i = i + 3)
            {
                cells = cells * 2;
                Console.WriteLine($"After {i} hours the number of cells is {cells}.");
            }

            Console.ReadLine();

        #endregion


        task_2_lv2:
            #region task 2 lv 2
            Console.WriteLine("Task 2 (level 2)");
            int p = 1;
            int n = 1;

            while (p <= 30000)
            {
                n += 3;
                p *= n;
            }

            Console.WriteLine($"The biggest n value is {n - 3}.");
            Console.ReadLine();

        #endregion

        task_4_lv2:
            #region task 4 lv 2
            Console.WriteLine("Task 4 (level 2)");
            s = 1;
            x = 0;

            Console.WriteLine("Enter the x value (-1 < x < 1).");

            try
            {
                x = double.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("");
                Console.WriteLine("Incorrect input.");
                Console.ReadLine();
                return;
            }

            if (Math.Abs(x) >= 1)
            {
                Console.WriteLine("");
                Console.WriteLine("Incorrect input.");
                Console.ReadLine();
                return;
            }

            Console.WriteLine("");
            Console.WriteLine($"The x value is {x}.");

            double x_og = x;
            x = x * x;
            s += x;
            //Console.WriteLine(x * 1000000);

            while (x >= 0.0001)
            {
                x = x * (x_og * x_og);
                s += x;
                //Console.WriteLine(x * 100000);
                
            }

            Console.WriteLine($"The result is {s}.");
            Console.ReadLine();

        #endregion

        tasks_7_8_lv2:
            #region tasks 7 8 lv 2
            Console.WriteLine("Tasks 7 and 8 (level 2)");
            double norm = 10;
            double all = 0;
            
            //Console.WriteLine($"dist = {all}");
            //Console.WriteLine(norm);
            
            for (int i = 1; i <= 7; i += 1)
            {
                all += norm;
                //Console.WriteLine($"dist = {all}");
                norm *= 1.1;
                //Console.WriteLine(norm);
                
            }
            Console.WriteLine($"The runner will run {all} km after 7 days.");

            norm = 10;
            all = 0;
            int days = 0;

            while (all < 100)
            {
                days += 1;
                //Console.WriteLine($"day {days}");
                all += norm;
                //Console.WriteLine($"dist = {all}");
                norm *= 1.1;
                //Console.WriteLine(norm);
            }
            Console.WriteLine($"The runner will run 100+ km after {days} days.");

            norm = 10;
            all = 0;
            days = 1;

            while (norm <= 20)
            {
                norm *= 1.1;
                //Console.WriteLine(norm);
                days += 1;
                //Console.WriteLine($"day {days}");
                all += norm;
                //Console.WriteLine($"dist = {all}");
            }
            Console.WriteLine($"The runner will run 20+ km per day after {days} days.");
            Console.ReadLine();
        #endregion


        task_1_lv3:
            #region task 1 lv 3
            Console.WriteLine("Task 1 (level 3)");
            double S = 0;
            double X;
            double A = 0.1;
            double B = 1;
            double H = 0.1;
            double cur_term;
            double I;
            //y = cos(x)

            for (X = A; X <= B; X += H)
            {
                cur_term = 1;
                S = 1;
                I = 1;
                while (Math.Abs(cur_term) >= 0.0001)
                {
                    S += cur_term;
                    cur_term *= -1 * (X * X) / ( 4 * (I * I) - 2 * I);
                    I += 1;
                    //Console.WriteLine(cur_term);
                }
                Console.WriteLine($"x = {X}; s = {S}; y = {Math.Cos(X)}.") ;
                //break;
            }
            Console.ReadLine();

        #endregion

        task_9_lv3:
            #region task 9 lv 3
            Console.WriteLine("Task 9 (level 3)");
            S = 0;
            A = 0.1;
            B = 0.5;
            H = 0.05;
            //y = arctg(x)

            for (X = A; X <= B; X += H)
            {
                cur_term = X;
                S = X;
                I = 1;
                while (Math.Abs(cur_term) >= 0.0001)
                {
                    S += cur_term;
                    cur_term *= (-1 * X * X * (2 * I - 1)) / (2 * I + 1);
                    I += 1;
                    //Console.WriteLine(cur_term);
                }
                Console.WriteLine($"x = {X}; s = {S}; y = {Math.Atan(X)}.");
                //break;
            }
            Console.ReadLine();

            #endregion
        }
    }
}
