using System;
using System.Diagnostics.CodeAnalysis;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            #region task_3.1
            double c;
            double a;


            for (double x = 0.1; x <= 1; x += 0.1)
            {
                a = 0;
                c = 1;
                double sum = 1;
                double i = 1;
                double v = 1;
                do
                {
                    v = v * x * x;
                    c = -c * v / ((2 * i - 1) * (2 * i));
                    a = c * (2 * i - 1);
                    sum += a;
                    i++;
                } while (Math.Abs(a) >= 0.0001);
                Console.WriteLine($"answer 3.1: прирост суммы {sum:f4} стал очень мал при {i} для x = {x}, y = {Math.Cos(x)}");
            }

            #endregion
            #region Task_3.6

            for (double x = 0.1; x <= 1; x += 0.1)
            {

                double sum = 0;
                double i = 1;
                double elem = 0;
                int p = 1;
                double asd = x;

                while (true)
                {
                    asd *= x * x;
                    elem = p * asd / ((4 * Math.Pow(i, 2) - 1) * 1.0);
                    sum += elem;

                    if (Math.Abs(elem) < 0.0001) break;


                    p = -p;



                    i++;

                }
                Console.WriteLine($"Answer 3.6: Прирост суммы {sum:f4} стал очень мал при {i} для x = {x:f4}, y = {((Math.Atan(x) * (1 + x * x) - x) / 2)}");
            }

            #endregion




        }
    }

}