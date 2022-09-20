using System;
using System.Security.Cryptography;

class HelloWorld
{
    static int Main()
    {
        //double x = Convert.ToDouble(Console.ReadLine());
        //if (x > 1 || x < 0.1) {Console.WriteLine("According to the conditions of the problem x<=1 and x>=0.1") ; return 0;}
        double x = 0.1; 
        double sum = 0;
        double factorial = 1;
        double d = 0;
        double proverka = 0;
        for (double i=0; proverka == 0; i++)
        {
            factorial = 1;
            for (double j=1; j<=2*i; j++)
            {
                factorial = factorial * j;
            }
            if (i == 0) factorial = 1;

            d = Math.Pow(x,2*i)/factorial;
            
            sum = sum + d;
            if (d<0) { d = d * -1; }
            if (d < 0.0001) { proverka = 1; break; }
            x = x + 0.05;
        }
        double uravoty = (Math.Pow(Math.E, x) + Math.Pow(Math.E, -x)) / 2;
        double tochnostfuncii = uravoty - sum;
        Console.WriteLine("Summ = " + sum);
        Console.WriteLine("Accuracy of function = " + tochnostfuncii);
        return 0;
    }
}

