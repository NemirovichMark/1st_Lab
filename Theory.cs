using System;
class Laboratorka1
{
    public static void Main(string[] args)
    {
        #region lvl1, tsk 4
        
        double s = 0;
        int i;
        double z;
        Console.WriteLine("Enter x");
        double x = Convert.ToDouble(Console.ReadLine());
        for (double v = 1; v <= 9; v++)
        {
            z = 1;
            if (v >= 2)
            {
                for (int j = 1; j <= v - 1; j++)
                {
                    z = z * x;
                }
            }
            s += Math.Cos(x * v) / z;
        }
        Console.WriteLine(s);
        #endregion

        #region lvl1, tsk9
        s = 0;
        z = 0;
        int factorial = 1;
        i = 0;
        for (i = 1; i < 7; i++)
        {
            factorial = factorial * i;
            z = Math.Pow(-1, i) * Math.Pow(5, i) / factorial;
            s = s + z;
        }
        Console.WriteLine(s);

        #endregion


        #region lvl1, tsk15
        double a1 = 1;
        double a2 = 1;
        double a3 = 2;
        double a4 = 1;
        double a;
        double b;
        for (i = 3; i < 7; i++)
        {
            a = a4 + a2;
            a2 = a4;
            a4 = a;
            b = a1 + a3;
            a1 = a3;
            a3 = b;
           
        }
        Console.WriteLine($"drob = {a4} / {a2}");
        #endregion

        #region lvl1, tsk16
        double e = 1;
        a = 1;
        for (i = 1; i < 64; i++)
        {
            e = e * 2;
            a = a + e;
        }
        Console.WriteLine($"Amount of sed = {a/15000} kg");
        #endregion

        #region lvl1, tsk18
        double kletka = 0;
        for (i = 1; i <= 24; i += 3)
        {
            kletka *= 2;

        }
        Console.WriteLine($"After 24h, amount of ameba = {kletka*10}");
        #endregion

        #region lvl2, tsk2
        a = 1;
        b = 4;
        for (i = 0; a * b < 30000; i += 3)
        {
            a *= b;
            Console.WriteLine(b);
            b += 3;
        }
        


        #endregion

        #region lvl2, tsk4
        double E = 0.0001; 
        Console.WriteLine("Enter x");
        x = Convert.ToDouble(Console.ReadLine());
        while (s < E)
        {
            s = 1 + Math.Pow(x, i);
        }
        #endregion

        #region lvl2, tsk7,8
        double way1 = 10;
        double ttlway = 10;

        for (i = 1; i < 7; i++)
        {
            way1 = way1 * 1.1;
            ttlway += way1;
        }
        Console.WriteLine(ttlway);

        double waypd = 10;
        int k = 1;
        double way2 = 10;

        while (way2 <= 100)
        {
            waypd = waypd * 1.1;
            way2 += waypd;
            k += 1;
        }
        Console.WriteLine(k);

        double way3 = 10;
        int k2 = 1;

        while (way3 < 20)
        {
            way3 = way3 * 1.1;
            k2 += 1;
        }
        Console.WriteLine(k2);
        #endregion

        #region lvl3, tsk1
        const double xh = 0.1, h = 0.1, eps = 0.0001;
        double y, c;
        int n = 10;
        x = xh;
        for (int j = 1; j <= n; j++)
        {
            s = 1; c = 1; i = 1;
            do
            {
                c *= ((-1) * x * x) / (4 * i * i - 2 * i);
                s = s + c;
                i = i + 1;
            } while (Math.Abs(c) >= eps);
            y = Math.Cos(x);

            Console.WriteLine("x = {0:f1} s = {1:f4} y = {2:f4} i = {3}", x, s, y, i);
            x = x + h;
        }
        #endregion
        Console.WriteLine("-------------------");
        #region lvl3, tsk4
        
        n = 10;
        x = xh;
        for (int j = 1; j <= n; j++)
        {
            s = 1; c = 1; i = 1;
            do
            {
                c *= Math.Pow(x, 2) * (2 * i + 1) / i / (2 * i - 1);
                s = s + c;
                i = i + 1;
            } while (Math.Abs(c) >= eps);
            y = (1 + 2 * x * x) * Math.Exp(Math.Pow(x, 2));

            Console.WriteLine("x = {0:f1} s = {1:f4} y = {2:f4} i = {3}", x, s, y, i);
            x = x + h;
        }
        #endregion

        #region lvl3, tsk6;

        #endregion
    }
}

