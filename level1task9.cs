

using System;
class HelloWorld
{
    static void Main()
    {
        double sum = 0;
        double b = 1;
        for (int i = 1; i < 7; i++)
        {
            b = b * i;
            sum = sum + Math.Pow(-1, i) * Math.Pow(5, i) / b;
        }
        Console.WriteLine(sum);
    }
}

//8,368055555555557
