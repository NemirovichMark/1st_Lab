using System;
namespace _1st_Lesson
{
    class Excercises
    {
        static void Main(string[] args)
        {
            #region Excercise first level number 4
            Console.Write("Introduce the value of x: ");
            double sumatory = 0;
            double x = Double.Parse(Console.ReadLine());
            for (int i = 1; i <= 9; i++)
            {
                double k = i - 1;
                double s = Math.Cos(x * i) / Math.Pow(x, k);
                s = Math.Round(s, 2);
                sumatory += s;
                Console.WriteLine($"S{i} = {s}");
                if (i >= 9)
                {
                    Console.WriteLine("The sum is: " + Math.Round(sumatory, 2));
                }
            }
            #endregion
            #region Excercise first level number 9 
            double sum = 0;
            double s = 1.00;
            int pow3 = 1, pow2 = 1;
            double pow1 = 1;
            for (int i = 1; i <= 6; i++)
            {
                pow1 *= -1;
                pow2 *= 5;
                pow3 *= i;
                s = pow1 * pow2 / pow3;
                sum += s;
            }
            Console.WriteLine(sum);
            #endregion
            #region Excercise first level number 15
            int n = 5;
            int first = 1, second = 1, next;
            for (int i = 1; i <= n; i++)
            {
                if (i <= 1)
                {
                    next = i;
                }
                else
                {
                    next = first + second;
                    first = second;
                    second = next;
                }
                Console.WriteLine($"{next} / {first}");
            }
            #endregion
            #region Excercise first level number 16
            double SumGrains = 1.0;
            int gram = 15;
            double NumberCell = 1;
            double AmountOfGrainGrams;
            for (int i = 0; i < 64; i++)
            {
                SumGrains += NumberCell;
                NumberCell *= 2;
            }
            AmountOfGrainGrams = SumGrains / gram;
            Console.WriteLine($"Task16: {AmountOfGrainGrams}");
            #endregion
            #region Excercise first level number 18
            int cells = 10;
            for (int h = 3; h <= 24; h += 3)
            {
                cells *= 2;
                Console.WriteLine(cells);
            }
            #endregion
            #region Excercise second level number 2
            int pp = 1;
            while (pp * (pp + 3) < 30000)
            {
                pp += 3;
            }
                Console.WriteLine(pp);
            #endregion
            #region Excercise second level number 4 
            Console.WriteLine("Introduce the value of x [ -1 < x < 1 ]");
            double x_base = double.Parse(Console.ReadLine()), pow = 1;
            if (x_base < 1 && x_base > -1)
            {
                int n_exponent = 0; // exponent
                double s_summatory = 0.0; //summatory's variable
                while (pow >= 0.0001)
                {
                    s_summatory += pow;
                    Console.WriteLine($"n = {n_exponent} and s = {s_summatory}");
                    n_exponent += 2;
                    pow *= (x_base * x_base);

                }
            }
            else
            {
                Console.WriteLine("Introduce the value of x following the condition  [ -1 < x < 1 ] ");
            }
            #endregion
            #region Excercise second level number 7 and 8
            double path = 10000;
            double increasedPathPerDay = 0.10; // 10%
                                               // Excercise A
            for (int i = 1; i <= 7; i++)
            {
                path += path * increasedPathPerDay;
            }
            Console.WriteLine($"in 7 days the runner runs {path} km");
            //Excercise B 
            path = 10000;
            double goal_path = 100000;
            int days = 0;
            //(int i = 1; i <= 7; i++)
            while (path <= goal_path)
            {
                path += path * increasedPathPerDay;
                days++;
            }
            Console.WriteLine($"in {days} days the runner achieves the 100km goal");
            //Excercise C
            path = 10000;
            days = 0;
            while (path <= 20000)
            {
                path += path * increasedPathPerDay;
                days++;
            }
            Console.WriteLine($"in {days} days the runner runs more than 20km per day");
            #endregion
            #region Excercise third level number 1
            double sum3, nSum;
            double y3;
            double product2;
            double product1;
            double sign;
            for (double x3 = 0.1; x3 < 1; x3 += 0.1)
            {
                sum3 = 0;
                nSum = 0;
                int i = 0;
                product2 = 1.0;
                product1 = 1.0;
                sign = -1;
                do
                {
                    sign = -sign;
                    nSum = sign * product1 / product2;
                    sum3 += nSum;
                    i++;
                    product2 *= 2 * product2 * i * (2 * i - 1);
                    product1 *= (x3*x3);
                }
                while (nSum >= 0.0001);
                y3 = Math.Cos(x3);
                Console.WriteLine($"X: {x3}, S: {sum3}, Y: {y3}");
            }
            #endregion
            #region Excercise third level number 8
            double sum38, nSum;
            double y38;
            double product2;
            double product1;
            for (double x38 = 0.1; x38 <= 1; x38 += 0.05)
            {
                sum38 = 0;
                nSum = 0;
                int i = 0;
                product2 = 1.0;
                product1 = 1.0;
                do
                {
                    nSum = product1 / product2;
                    sum38 += nSum;
                    i++;
                    product2 *= i;
                    product1 *= 2 * x38;
                }
                while (nSum >= 0.0001);
                y38 = Math.Pow(Math.E, 2 * x38);
                Console.WriteLine($"X: {x38}, S: {sum38}, Y: {y38}");
            }
            #endregion
        }
    }
}