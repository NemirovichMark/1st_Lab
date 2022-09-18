using System;

namespace _1st_Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            #region lvl_1
            #region Num_4
            double x;
            if (double.TryParse(Console.ReadLine(), out x))
            {
                if (x == 0)
                {
                    Console.WriteLine("Error");
                    return;
                }

                double s = 0;
                for (int i = 0; i < 9; ++i)
                {
                    s += Math.Cos(x * (i + 1)) / Math.Pow(x, i);
                }
                Console.WriteLine(s);
            }
            #endregion

            #region Num_9
            double s1 = 0;
            int k = 1;
            for (int i = 0; i < 6; ++i)
            {
                k *= (i + 1);
                s1 += Math.Pow(-1, (i + 1)) * Math.Pow(5, (i + 1)) / k;
            }
            Console.WriteLine(s1);
            #endregion

            #region Num_15
            double up = 1;
            double down = 1;
            for (int i = 0; i < 4; ++i)
            {
                up += down;
                down = up - down;
                
            }
            Console.WriteLine(up/down);
            #endregion

            #region Num_16
            double s2 = 0;
            for (int i = 0; i < 64; ++i)
            {
                s2 += Math.Pow(2, i);
            }
            Console.WriteLine(s2 / 15);
            #endregion

            #region Num_18
            double colvo = 10;
            for (int i = 3; i <= 24; i += 3)
            {
                colvo *= 2;
                Console.WriteLine($"{i} hours = {colvo}");
            }

            #endregion
            #endregion

            #region lvl_2

            #region Num_2
            double p = 1;
            double n = 1;
            while (p < 30000)
            {
                n += 3;
                p *= n;
            }
            n -= 3;
            Console.WriteLine(n);
            #endregion

            #region Num_4

            double x1;
            double sum = 1;
            double degree = 2;
            if (double.TryParse(Console.ReadLine(), out x1))
            {
                if (Math.Abs(x1) >= 1)
                {
                    Console.WriteLine("Error");
                    return;
                }
                while (Math.Pow(x1, degree) >= 0.0001)
                {
                    sum += Math.Pow(x1, degree);
                    degree *= 2;
                }
                Console.WriteLine(sum);
            }
            #endregion

            #region Num_7&8
            double start = 10;
            double summ = 10;
            for (int i = 0; i < 6; ++i)
            {
                start *= 1.1;
                summ += start;  
            }
            Console.WriteLine(summ);

            start = 10;
            summ = 10;
            double days = 1;
            while (summ < 100)
            {
                start *= 1.1;
                summ += start;
                ++days; 
            }
            Console.WriteLine(days);
            
            start = 10;
            days = 1;
            while (start < 20)
            {
                start *= 1.1;
                ++days;
            }
            Console.WriteLine(days);
            #endregion


            #endregion

            #region lvl_3


            #region Num_1
            double total = 0;
            for (double x2 = 0.1; x2 <= 1; x2 += 0.1)
            {
                x2 = Math.Round(x2, 1);
                total = 0;
                double cikl = 0;
                int i = 0;
                do
                {
                    double factarial = 1;
                    for (int step = 1; step <= (2*i); ++step) 
                    { 
                        factarial *= step;
                    }
                    cikl = Math.Pow(-1, i) * Math.Pow(x2, (2*i)) / factarial;
                    i++;
                    total += cikl;
                }
                while (cikl >= 0.0001);
                double y = Math.Cos(x2);
                Console.WriteLine($"x = {x2}; s = {total:f6};  y = {y:f6}");

            }
            #endregion

            #region Num_5
            for (int l = 0; l <= 20; ++l)
            {
                double x3 = Math.PI / 5 + (Math.PI / 25 ) * l;
                double total1 = 0;
                double cikl1 = 0;
                int i = 1;
                do
                {
                    cikl1 = Math.Pow(-1, i) * Math.Cos(i * x3) / Math.Pow(i, 2);
                    i++;
                    total1 += cikl1;
                }
                while (cikl1 >= 0.0001);
                double y = (Math.Pow(x3, 2) - Math.Pow(Math.PI, 2) / 3) / 4;
                Console.WriteLine($"x = {x3:f6}; s = {total1:f6};  y = {y:f6}");
            }
            #endregion

            #endregion
        }
    }
}
