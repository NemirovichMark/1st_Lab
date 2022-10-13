using System;

namespace _1st_Lab_P3
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 3/1

            double s = 0, i = 0, fact = 1, cur = 1;

            for (double x = 0; x <= 1; x += 0.1)
            {
                s = 0;
                fact = 1;
                Console.WriteLine($"y = {Math.Cos(x)}");

                while (i < 9999)
                {

                    if (i > 0)
                    {
                        fact *= (2 * i * (2 * i - 1));
                    }
                    cur = Math.Pow(-1, i) * (Math.Pow(x, 2 * i) / fact);
                    s += cur;
                    i++;
                    if (Math.Abs(cur) < 0.0001)
                    {
                        Console.WriteLine($"summ = {s}");
                        break;
                    }
                }
                i = 0;
            }

            #endregion 3/1
            Console.WriteLine("----------");
            #region 3/8

            s = 0;
            i = 0;
            fact = 1;
            for (double z = 0; z <= 1; z += 0.05)
            {
                fact = 1;
                i = 0;
                s = 0;
                Console.WriteLine($"y = {Math.Pow(Math.E, 2 * z)}");
                while (i < 99999)
                {   
                    if (i > 1)
                    {
                        fact *= i;
                    }
                    s += Math.Pow(2 * z, i) / fact;
                    i += 1;
                    if (Math.Pow(2 * z, i) / fact < 0.0001)
                    {
                        Console.WriteLine($"summ = {s}");
                        break;
                    }
                    
                }
            }


            #endregion 3/8
        }
    }
}