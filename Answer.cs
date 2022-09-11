using System;

namespace _1st_Lab
{
    class Program
    {
        static void Main(string[] args) // Leave this method - it is start point of program
        {
            #region Task 1_1
            // s = 1 + 2 + 3 + ... + 100.

            int sum = 0;

            for (int i = 0; i <= 100; i++) // Be careful with in-equations
            {
                sum += i;
            }

            var average = sum / 100;

            Console.WriteLine($"Сумма последовательности = {sum}");
            Console.WriteLine($"Среднее арифметическое последовательности = {average}");

            #endregion
        }
    }
}
