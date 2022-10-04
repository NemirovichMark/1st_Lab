using System;

namespace FirstLab
{
    class Program
    {
        static void Main(string[] args)
        {
            #region task_1.4

            double sum = 0;

            Console.Write("Input: ");
            string input = Console.ReadLine();
            bool result = float.TryParse(input, out var x);
            if (result == false || x == 0)
            {
                Console.WriteLine("Incorrect data");

            }

            double a = Math.Cos(x);
            for (int i = 2; i < 10; i++)
            {
                sum = sum + a;
                a = Math.Cos(i * x) / Math.Pow(x, (i - 1));
            }
            Console.WriteLine($"1.4 Answer: {sum}");

            #endregion
            #region task_1.9

            double sum2 = 0;
            double a2;
            int Factorial = 1;

            for (int i = 1; i < 7; i++)
            {
                Factorial *= i;
                a = Math.Pow(-1, i) * Math.Pow(5, i) / Factorial;
                sum += a;
            }
            Console.WriteLine($"1.9 Answer: {sum}");

            #endregion
            #region task_1.15

            double chisl1 = 1, chisl2 = 2, chisl3 = 0;
            double znam1 = 1, znam2 = 1, znam3 = 0;
            for (int i = 1; i < 4; i++)
            {
                chisl3 = chisl1 + chisl2;
                znam3 = znam1 + znam2;
                chisl1 = chisl2;
                znam1 = znam2;
                chisl2 = chisl3;
                znam2 = znam3;
            }
            Console.WriteLine($"1.15 Answer: {chisl3 / znam3}");

            #endregion
            #region task_1.16

            ulong seeds = 1;
            sum = 1;
            for (int i = 1; i < 64; i++)
            {
                seeds *= 2;
                sum += seeds;
            }
            Console.WriteLine($"1.16 Answer: {sum} {sum / 15}");

            #endregion
            #region task_1.18

            ushort amebi = 10;
            sum = 0;

            for (int i = 3; i < 25; i += 3)
            {
                amebi *= 2;
                Console.WriteLine($"1.18 Hour: {i} Answer: {amebi}");
            }

            #endregion
        }
    }
}