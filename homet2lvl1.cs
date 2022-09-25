using System;
using System.Numerics;
using System.Security.Cryptography;

class Hometask2

{
    static void Main()
    {
       #region Level1_task4
       double res1 = 0.0;
       int x = Convert.ToInt32(Console.ReadLine());
       if (x != 0) {
            for (int i = 1; i != 10; i++)
            { res1 = (Math.Cos(i * x)) / Math.Pow(x, i - 1) + res1;}
         Console.WriteLine($"result1 sum(cos)-> {res1}");
       }
       else {Console.WriteLine("if you want to write '0' please think again ;p ");}
       #endregion
       #region Level1_task9
       double res2 = 0.0;
        int del = 1;
       for (int i = 1; i != 7; i++) {
            if (i == 1) del = 1;
            else del = del * i;
            res2 = Math.Pow(-1, i) * Math.Pow(5, i) / del;
        }
       Console.WriteLine($"result2 (pow) -> {res2}");
        #endregion
        #region Level1_task15
        double numerat1 = 0.0;
        double numerat2 = 0.0;
        double numeratx = 0.0;
        double denomerat1 = 0.0;
        double denomerat2 = 0.0;
        double denomeratx = 0.0;
        for (int i = 1; i!=6; i++)
        {
            if (i == 1)
            {
                numerat1 = 1;
                denomerat1 = 1;
            }
            else if (i == 2)
            {
                numerat2 = 2;
                denomerat2 = 1;
            }
            else 
            {
                numeratx = numerat1 + numerat2;
                numerat1 = numerat2;
                numerat2 = numeratx;
                denomeratx = denomerat1+denomerat2;
                denomerat1 = denomerat2;
                denomerat2 = denomeratx;
                
            }
        }
        Console.WriteLine(numerat2);
        Console.WriteLine(denomerat2);
        //double y1 = numerator(5);
        //double y2 = denomerator(5);
        double res3 = numerat2 / denomerat2;
        Console.WriteLine($"result3 - > {res3}");
        #endregion
       #region Level1_task16
        double p1 = 1.0;
        //double ix = 0;
        //int step = 0;
        for (int i = 1; i <= 64; i++)
        {
            p1 = Math.Pow(2, i) + p1;
        }

        Console.WriteLine($"count of corn -> {p1}");
        #endregion
       #region Level1_task18
        Console.Write("Введите время конца деления ->");
        double hours = Convert.ToDouble(Console.ReadLine());
        int volume = 10;
        double step2 = hours / 3;
        double res5 = Math.Pow(2, step2)*volume;
        Console.WriteLine($"ameba -> {res5}");
        #endregion
    }
}
