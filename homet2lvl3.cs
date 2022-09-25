using System;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;

class homet2lvl3                   
{
    static void Main()
    {
        #region Level3Task1
        Console.WriteLine("choose task (1 or 5)");
        int numb = Convert.ToInt32(Console.ReadLine());
        double a = 0.0;
        double b = 0.0;
        double h = 0.0;
        if (numb == 1)
        {
            a = 0.1;
            b = 1;
            h = 0.1;
        }
        else if (numb == 5)
        {
            a = Math.PI / 5;
            b = Math.PI;
            h = Math.PI / 25;
        }
        else
        { Console.WriteLine("None"); }
        if ((numb == 1) || (numb == 5))
        {
            double s = 0.0;
            double x = a;
            int i = 1;
            int fact = 1;
            double obj1 = 0.0;
            while ((x >= a) && (x <= b))
            {
                    do { 
                        fact = fact * (2 * i) * (2 * i - 1);
                        if (numb == 1)
                            obj1 = ((Math.Pow(-1, i)) * (Math.Pow(x, 2 * i)) / fact);
                            else obj1 = Math.Pow(-1, i) * Math.Cos(i * x) / Math.Pow(i, 2); 
                        s = s + obj1;
                        i = i + 1;
                    } while (Math.Abs(obj1) > 0.0001);
                i = 1;
                fact = 1;
                x = x + h;
                Console.WriteLine($"result -> {s}");
            }

            //Console.WriteLine($"result -> {s}");
            Console.WriteLine("Do you want to see a function please write 1 - yes; 0 -  no");
            int yesorno = Convert.ToInt32(Console.ReadLine());
            if (yesorno == 1)
            {
                for (double xx = a; xx <= b; xx += h)
                {
                    if (numb == 1) Console.WriteLine(Math.Cos(xx));
                    else Console.WriteLine((Math.Pow(x, 2) - (Math.Pow(Math.PI, 2)) / 3) / 4); 
                }
            }
        }
        else  Console.WriteLine("None");
        #endregion
    }
}
