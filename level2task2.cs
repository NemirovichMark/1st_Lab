using System;
class HelloWorld
{
    static void Main()
    {
        //string vvod = Console.ReadLine();
        //double x = Convert.ToInt32(vvod);
        double count = 10;
        double L = 30000;
        double p = 1;
        double n = 1;
        for (int i = 1; p * n < L; i++)
        {
            n = n + 3;
            p = p * n; 
        }
        Console.WriteLine(n);
        }
    }
