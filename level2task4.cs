using System;
class HelloWorld
{
    static int Main()
    {
        double x = Convert.ToDouble(Console.ReadLine());
        double k = 0;
        double n;
        int i = 1;
        if (x == 0) { Console.WriteLine("x ot equal to zer0"); return 0; }
        if ((x >= 1) || (x <= -1)) { Console.WriteLine("By condition: |x| < 1"); return 0; }

        double sum = 1;
        while (k == 0)
        {

            n = Math.Pow(x, i * 2);
            if (n < 0.0001) { break; }
            sum = sum + n;
            i = i + 1;
        }
        Console.WriteLine(sum);
        return 0;
    }
}

