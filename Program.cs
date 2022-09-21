using System;
using System.Runtime.InteropServices;
using static System.Math;
{
    double x = Convert.ToDouble(Console.ReadLine());
    double rad;
    rad = (x * Math.PI) / 180;
    double s = 0;
    if (x != 0)
    {
        for (int i = 0; i < 9; i++)
        {
            s = s + (Cos(rad * (i + 1)) / Pow(x, i));
        }
        Console.WriteLine($"N4,1 = {s}");
    }
    else
        Console.WriteLine("N1,4 = Деление на 0");


    double summ = 0;
    double f = 1;
    for (int i = 1; i < 7; i++)
    {
        f = f * i;
        summ = summ + (Pow((-1), i) * Pow(5, i) / f);
    }
    Console.WriteLine($"N1,9 = {summ}");


    double a1 = 1;
    double b1 = 1;
    double a2 = 2;
    double b2 = 1;
    double a0 = 0;
    for (int i = 1; i < 4; i++)
    {
        a0 = a2;
        a2 = a1 + a2;
        a1 = a0;
        a0 = b2;
        b2 = b1 + b2;
        b1 = a0;
    }
    Console.WriteLine($"N1,15 = {a2 / b2}");


    double ss = 1;
    double z = 1;
    for (int i = 1; i < 64; i++)
    {
        z = z * 2;
        ss = ss + z;
    }
    ss = ss / 15;
    Console.WriteLine($"N1,16 = {ss} gramm");


    double d = 10;
    Console.WriteLine($"N1,18=");
    for (int i = 1; i < 9; i++)
    {
        d = d * 2;
        Console.WriteLine($"Через {3 * i} часа = {d}");
    }

    double n = 1;
    double p = 1;
    while (p <= 30000)
    {
        n += 3;
        p = p * n;
    }
    Console.WriteLine($"N2,2 = {n - 3}");


    double h = Convert.ToDouble(Console.ReadLine());
    double gg = 0;
    double s1 = 0;
    double c = 2;
    if (Abs(h) < 1)
    {
        while (c > 0.0001)
        {
            s1 += Pow(h, gg);
            gg += 2;
            c = Pow(h, gg);
        }
        Console.WriteLine($"N2,4 = {s1}");
    }
    else
    {
        Console.WriteLine($"N2,4 = Число по модулю больше 1");
    }

    double ff = 10;
    double dd = 1;
    double s3 = 10;
    double gf = 0;
    Console.WriteLine($"N2,7-8:");
    while (ff <= 20)
    {
        dd += 1;
        ff = ff * 1.1;
        s3 += ff;
        if (dd == 7)
        {
            Console.WriteLine($"За 7 дней путь {s3} км");
        }
        if (s3 >= 100 & gf == 0)
        {
            gf = 1;
            Console.WriteLine($"100 км он пробежит за {dd} дней");
        }
    }
    Console.WriteLine($"Скорость станет больше 20 км на {dd} день");


    double x0 = 0.1;
    double gh = -1;
    double fe = 0;
    double ds = 1;
    Console.WriteLine($"N3,1:");
    while (x0 <= 1)
    {
        gh += 1;
        for (int i = 1; i < 2 * gh + 1; i++)
        {
            ds = ds * i;
        }
        Console.WriteLine($"При i={gh} y = {Cos(x0)}");
        fe = fe + (Pow(-1, gh) * Pow(x0, 2 * gh) / ds);
        x0 += 0.1;
        ds = 1;
    }
    Console.WriteLine($"Общая Сумма = {fe}");
    x0 = 0.1;
    fe = 0;


    double hg = 0;
    double y = 0;
    Console.WriteLine($"N3,2:");
    while (x0 <= 0.8)
    {
        hg += 1;
        y = (x0 * Sin(Math.PI / 4)) / (1 - 2 * x0 * Cos(Math.PI / 4) + Pow(x0, 2));
        Console.WriteLine($"При i={hg} y = {y}");
        fe = fe + Pow(x0, hg) * (Sin(hg * Math.PI / 4));
        x0 += 0.1;
    }
    Console.WriteLine($"Общая Сумма = {fe}");
}
