using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Runtime.Intrinsics.Arm;

internal class Program
{
    private static void Main(string[] args)
    {
        double s = 0, x = 0;
        int i;
        int k = 1;
        //4
        Console.WriteLine("Введите значение x (Градусы):");
        if (double.TryParse(Console.ReadLine(), out x))
        {
            for (i = 1; i <= 9; i++)
            {
                s = s + Math.Cos(i * x) / Math.Pow(x, i - 1);
            }
        }
        Console.WriteLine(s);

        s = 0;

        //9

        for (i = 1; i <= 6; i++)
        {
            k = 1;
            for (int j = 1; j <= i; j++)
            {
                k *= j;
            }
            s = s + Math.Pow(-1, i) * Math.Pow(5, i) / k;
        }

        Console.WriteLine(s);

        //15

        double[,] nums = { { 1, 1 }, { 2, 1 }, { 3, 2 }, { 0, 0 }, { 0, 0 } };

        for (i = 3; i < nums.Length/2; i++)
        {
            nums[i,0] = nums[i-2,0] + nums[i-1,0];
            nums[i, 1] = nums[i-2,1] + nums[i-1,1];
        }
        Console.WriteLine(nums[3, 0] / nums[3,1]);
        Console.WriteLine(nums[4, 0] / nums[4, 1]);

        //16

        double seed = 1;
        for (i = 2; i <= 63; i++)
        {
            seed = seed + Math.Pow(2,i);
        }
        Console.WriteLine($"{seed/15} Грамм");

        k = 1;

        //18

        for (i = 3; i<= 24;i=i+3)
        {
            k *= 2;
            Console.WriteLine($"{i} Часов: {k*10} Клеток");
        }

        //2

        k = 1;
        int p = 1;
        while (p <= 30000)
        {
            k += 3;
            p *= k;
        }
        if (p >30000)
        {
            k = k - 3;
        }
        Console.WriteLine($"n = {k}");
        
        //4

        x = 0;
        s = 1;
        int step = 2;
        Console.WriteLine("Введите x:");
        if (double.TryParse(Console.ReadLine(), out x) && Math.Abs(x)<1)
        {
            while(Math.Pow(x, step) >= 0.0001)
            {
                s += Math.Pow(x,step);
                step += 2;
            }
            Console.WriteLine(s);
        }

        //7a

        s = 10;
        double s2 = 0;

        for (i = 2; i <= 7; i++)
        {
            s = s*1.1;
            s2 += s;
        }

        Console.WriteLine(s2+10);

        // 7b

        s2 = 0;

        s = 10;

        k = 1;


        while(s2 <= 100)
        {
            k++;
            s = s * 1.1;
            s2 += s;
        }

        Console.WriteLine($"{s2} через {k} дней");

        //7c

        s2 = 0;

        s = 10;

        k = 1;

        while (s <= 20)
        {
            k++;
            s = s * 1.1;
        }

        Console.WriteLine($">20км через {k} дней");


        //1

        double h = 0.1;
        decimal v = 0;
        double fact = 1;
        decimal x3;
        for (x3 = 0.1m; x3 <= 1; x3 += 0.1m)
        {
            v = 0;
            s = 0;
            i  = -1;
            while(Math.Abs(v)>=0.0001m || v == 0)
            {
                i++;
                fact = 1;
                for (int j = 2; j <= 2*i; j++) {
                    fact *= j;
                }

                v = (decimal)Math.Pow(-1, i) * (decimal)((double)Math.Pow((double)x3,2*i)/fact);

                s += (double)v;
            }

            Console.WriteLine($"x = {x3} y = {(decimal)Math.Cos((double)x3)} s = {s}");
        }

        //3

        Console.WriteLine("--------------------------------------------");

        h = 0.1;
        v = 0;
        fact = 1;
        for (x3 = 0.1m; x3 <= 1; x3 += 0.1m)
        {
            v = 0;
            s = 0;
            i = 0;
            while (Math.Abs(v) >= 0.0001m || v == 0)
            {
                i++;
                fact = 1;
                for (int j = 2; j <= i; j++)
                {
                    fact *= j;
                }

                v = (decimal)Math.Cos((double)i*(double)x3)/(decimal)fact;

                s += (double)v;
            }

            Console.WriteLine($"x = {x3} y = {(decimal)Math.Exp((double)Math.Cos((double)x3))*(decimal)Math.Cos(Math.Sin((double)x3))} s = {1 + s}");
        }
    }
}
