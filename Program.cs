using System;

namespace _1st_Lesson
{

    class Program
    {

        static void exercise_1_4()
        {
            string s;
            double ans = 0, div = 1, arg, x;

            s = Console.ReadLine();

            if (!double.TryParse(s, out x))
            {
                Console.WriteLine("ошибка");
                return;
            }

            if(x == 0)
            {
                Console.WriteLine("не определеность");
                return;
            }

            arg = x;

            for (int i = 0; i < 9; ++i)
            {
                ans += Math.Cos(arg) / div;
                arg += x;
                div *= x;

            }

            Console.WriteLine(ans);

        }
        static void exercise_1_9()
        {
            double ans = 0, arg1 = -1, arg2 = 5, arg3 = 1;

            for (int i = 1; i <= 6; ++i)
            {
                ans += (arg1 * arg2) / arg3;
                arg1 *= -1;
                arg2 *= 5;
                arg3 *= i;
            }

            Console.WriteLine(ans);
        }
        static void exercise_1_15()
        {
            double arg1 = 2, pr1 = 1;
            double arg2 = 1, pr2 = 1;

            for (int i = 2; i < 5; ++i)
            {
                double new1,new2;
                new1 = arg1 + pr1;
                new2 = arg2 + pr2;
                pr1 = arg1;
                pr2 = arg2;
                arg1 = new1;
                arg2 = new2;
            }
            Console.WriteLine(arg1 / arg2);

        }
        static void exercise_1_16()
        {
            double ans = 0, arg = 1 / 15.0;

            for (int i = 1; i <= 64; ++i)
            {
                ans += arg;
                arg *= 2;

            }

            Console.WriteLine(ans);
        }
        static void exercise_1_18()
        {
            double ans = 10;

            for (int i = 0; i <= 24; i += 3)
            {
                ans *= 2;
                Console.WriteLine(ans);
            }
        }
        static void exercise_2_2()
        {
            ulong n = 1, mult = 1, L = 30000;

            while ((n + 3) * mult <= L)
            {
                n += 3;
                mult *= n;
            }

            Console.WriteLine(n);
        }
        static void exercise_2_4()
        {
            double eps = 0.0001, x, arg, sum = 1;
            string s;
            s = Console.ReadLine();

            if (!double.TryParse(s, out x))
            {
                Console.WriteLine("ошибка");
                return;
            }
            if (Math.Abs(x) >= 1)
            {
                Console.WriteLine("неверный x");
                return;
            }
            arg = x * x;

            while (eps <= arg)
            {
                sum += arg;
                arg *= x * x;
            }

            Console.WriteLine(sum);
        }
        static void exercise_2_7()
        {
            double k = 1.1, sum = 10;
            bool fl3 = true, fl2 = true, fl1 = true;
            double ans1 = 0;
            int ans2 = 0, ans3 = 0;
            List<double> list = new List<double>() { 10 };
            while (list.Count < 7 || list[list.Count - 1] <= 20 || sum <= 100)
            {
                
                double New = list[list.Count - 1] * k;
                list.Add(New);
                sum += New;
        
                if (list.Count == 7)
                {
                    ans1 = sum;
                }

                if (sum > 100 && fl2)
                {
                    fl2 = false;
                    ans2 = list.Count;
                }

                if (New > 20 && fl3) 
                {
                    fl3= false;
                    ans3 = list.Count;
                }
            }

            Console.WriteLine($" 1) {ans1} 2) {ans2} 3) {ans3}");
        }
        static void exercise_3_5()
        {
            double eps = 0.0001; 
            double h = Math.PI / 25, a = Math.PI / 5, b = Math.PI;
            for (double x = a; x <= b; x += h)
            {
                double y = (x * x - Math.PI * Math.PI / 3) / 4;
                int z = -1;
                double arg = z * Math.Cos(x * 1);
                double sum = arg;

                for (int i = 2; Math.Abs(arg) >= eps; ++i) 
                {
                    z *= -1;
                    arg = z * Math.Cos(x * i) / (i * i);
                    sum += arg;
                }

                Console.WriteLine($"y = {y} s = {sum}");
            }

        }

        static void exercise_3_1()
        {
            Console.WriteLine("3_1");
            double eps = 0.0001;
            double h = 0.1, a = 0.1, b = 1;
            for (double x = a; x <= b; x += h)
            {
                double y = Math.Cos(x);
                int z = 1;
                double arg = 1;
                double sum = 1;
                double fact = 1;
                for (int i = 1; Math.Abs(arg) >= eps; ++i)
                {

                    fact *= (2*i-1)*i*2;
                    z *= -1;
                    arg = z * Math.Pow(x, 2 * i) / fact;
                    sum += arg;
                }

                Console.WriteLine($"y = {y} s = {sum}");
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            #region exercise 1_4
            exercise_1_4();
            #endregion

            #region exercise 1_9
            exercise_1_9();
            #endregion

            #region exercise 1_15
            exercise_1_15();
            #endregion

            #region exercise 1_16
            exercise_1_16();
            #endregion

            #region exercise 1_18
            exercise_1_18();
            #endregion

            #region exercise 2_2
            exercise_2_2();
            #endregion

            #region exercise 2_4
            exercise_2_4();
            #endregion

            #region exercise 2_7 - 2_8
            exercise_2_7();
            #endregion

            #region exercise 3_1
            exercise_3_1();
            #endregion

            #region exercise 3_5
            exercise_3_5();
            #endregion


        }
    }
}