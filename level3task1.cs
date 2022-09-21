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
        double tochnostfuncii = 0;
         for (double x = 0.1; x <= 1; x = x + 0.1)
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
                    d = Math.Pow(-1, i/2) * Math.Pow(x, i) / factorial;
                    sum = sum + d;
                    if (d < 0) { d = d * -1; }
                    if (d < 0.0001) { proverka = 1; }
                    //Console.WriteLine("1");
                }
            }
            rad = x * 0.0175; //перевод в радианы
            tochnostfuncii = Math.Cos(rad) - sum;
            Console.WriteLine("Summ " + t + " = " + sum);
            Console.WriteLine("Accuracy of function " + t + " = " + tochnostfuncii);
            t = t + 1;
            sum = 0;
         }
        return 0;
    }
}
/*
Summ 1 = 0,9950041666666667
Accuracy of function 1 = 0,004994302083724089
Summ 2 = 0,9800666666666666
Accuracy of function 2 = 0,019927208339585945
Summ 3 = 0,9553364875
Accuracy of function 3 = 0,044649731281653726
Summ 4 = 0,9210609777777777
Accuracy of function 4 = 0,07891452232226381
Summ 5 = 0,8775824652777777
Accuracy of function 5 = 0,12237925371646396
Summ 6 = 0,8253352
Accuracy of function 6 = 0,174609675506459
Summ 7 = 0,7648421950399306
Accuracy of function 7 = 0,23508277464834615
Summ 8 = 0,6967067387936509
Accuracy of function 8 = 0,3031952628070054
Summ 9 = 0,6216100637700894
Accuracy of function 9 = 0,3782659075438479
Summ 10 = 0,5403025793650794
Accuracy of function 10 = 0,4595442995427583*/
