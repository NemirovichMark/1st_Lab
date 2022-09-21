using System;
using System.Security.Cryptography;

class HelloWorld
{
    static int Main()
    {
        double a1 = 1;
        double a2 = 2;
        double a3 = 0;
        double b1 = 1;
        double b2 = 1;
        double b3 = 0;
        for (int i=3; i<=5; i++)
        {
            a3 = a1 + a2;
            b3 = b1 + b2;
            a1 = a2;
            a2 = a3;
            b1 = b2;
            b2 = b3;
        }
        Console.WriteLine(a3 / b3);
        return 0;
    }
}
