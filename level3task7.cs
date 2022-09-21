using System;
using System.Security.Cryptography;

class HelloWorld
{
    static int Main()
    {
        //double x = Convert.ToDouble(Console.ReadLine());
        //if (x > 1 || x < 0.1) {Console.WriteLine("According to the conditions of the problem x<=1 and x>=0.1") ; return 0;}
        double sum = 0;
        double factorial = 1;
        double d = 0;
        double proverka = 0;
        double t=1;
        double rad = 0;
        double uravoty = 0;
        double tochnostfuncii = 0;
         for (double x = 0.1; x <= 1.05; x = x + 0.05)
         {
            //double x = 0.2;
            proverka = 0;
            for (double i = 0; proverka == 0; i++)
            {
                d = 1;
                factorial = factorial * i;
                if (i == 0) factorial = 1;
                if (i % 2 == 0 || i == 0)
                {
                    d =  Math.Pow(x, i) / factorial;
                    sum = sum + d;
                    if (d < 0) { d = d * -1; }
                    if (d < 0.0001) { proverka = 1; }
                    //Console.WriteLine("1");
                }
            }
            //rad = x * 0.0175; //перевод в радианы
            uravoty = (Math.Pow(Math.E, x) + Math.Pow(Math.E, -x)) / 2;
            tochnostfuncii = uravoty - sum;
            Console.WriteLine("Summ " + t + " = " + sum);
            Console.WriteLine("Accuracy of function " + t + " = " + tochnostfuncii);
            Console.WriteLine(x);
            t = t + 1;
            sum = 0;
         }
        return 0;
    }
}
