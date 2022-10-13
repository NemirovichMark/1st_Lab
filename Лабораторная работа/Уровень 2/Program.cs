using System;

namespace FirstLab
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Task_2.2
            int p = 1, L = 30000, n = 1;
            while (true)
            {
                p *= n;
                if (p * (n + 3) > L)
                {
                    break;
                }
                n += 3;

            }
            Console.WriteLine($"2.2 Answer: {n}");
            #endregion
            #region Task_2.4
            while (true)
            {
                Console.WriteLine($"2.4 Input: ");
                string input = Console.ReadLine();
                bool result = double.TryParse(input, out var x);
                if (((x < 1) && (x > -1) && (result == true)) == false)
                {
                    Console.WriteLine("2.4 Incorrect data, try again");

                }
                else
                {
                    double s, sum = 0;
                    int i = 0;
                    while (true)
                    {
                        s = Math.Pow(x, 2 * i);
                        if (s < 0.0001)
                        {
                            Console.WriteLine($"2.4 Answer: {sum}");
                            break;
                        }
                        sum += s;
                        i++;

                    }
                    break;
                }
            }
            #endregion
            #region Task_2.7
            float distance = 10.0f;
            float total = 0.0f;
            bool flag = true;
            for (int i = 2; ; i++)
            {
                distance *= 1.1f;
                total += distance;
                if (i == 7)
                {
                    Console.WriteLine($"2.7 Answer a): {distance}");
                }
                if (total >= 100.0f && flag)
                {
                    flag = false;
                    Console.WriteLine($"2.7 Answer b): {i}");
                }
                if (distance > 20)
                {
                    Console.WriteLine($"2.7 Answer c): {i}");
                    break;

                }
            }
            #endregion
        }
    }
}