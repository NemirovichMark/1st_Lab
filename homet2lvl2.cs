using System;
using System.Net.NetworkInformation;
using System.Security.Cryptography.X509Certificates;

class MyClass
{
    static double distance(int n)
    {
        if (n == 1) return 10;
        else return distance(n - 1) * 1.1;
    }
    static void Main()
    {
        #region Level2task2
        int p = 1;
        int n = 4;
        do
        {
            p = p * n;
            n = n + 3;
        } while (p * n <= 30000);
        Console.WriteLine($"result1 -> {p}");
        #endregion
        #region Level2task4
        Console.WriteLine("введите значение |x|<1");
        double x = Convert.ToDouble(Console.ReadLine());
        if ((x>(-1)) && (x<1))
        {
            double x1 = Math.Pow(x, 0);
            double res2 = x1;
            int n2 = 1;
            while (Math.Pow(x, 2 * (n2)) >= 0.0001)
            {
                x1 = Math.Pow(x, 2*n2);
                res2 = res2 + x1;
                n2++;
            } 
            Console.WriteLine($"result sum(funct) -> {res2}");
        }
        else
        {
            Console.WriteLine("please write another");
        }
        
        #endregion
        #region Level2tasks7-8
        double days7 = 0.0;
        for (int i = 1; i < 8; i++)
            {
            if (i == 1) days7 = 10;
            else days7 = days7 * 1.1;
            }
        Console.WriteLine($"a) 7 days -> {days7}");
        int n1 = 1;
        do {
            n1 = n1 + 1;
            if (n1 == 1) days7 = 10;
            else
            {
                days7 = days7 * 1.1;
            }
        } 
        while (days7 < 100);
        Console.WriteLine($"b) summary way 100km -> {n1}");
        double raz = 0.0;
        int n4 = 1;
        double d7 = 0.0;
        do
        {
            if (n4 == 1) days7 = 10;
            else
            {
                d7 = days7;
                days7 = days7 * 1.1;
            }

            raz = days7 - d7;
            n4 = n4 + 1;
        } while (raz < 20);
        Console.WriteLine($"c) summary 20 days > {n4}");
        #endregion
    }
}
