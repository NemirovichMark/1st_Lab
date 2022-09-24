using System;

namespace LaboratoryL3N7
{
    class Program
    {
        static int Factorial(int f)
        {
            if(f == 0)
            {
                return 1;
            }
            else
            {
                return f * Factorial(f-1); 
            }
        }
        static void Main(string[] args)
        {
            int i = 0;
            double a = 0.1, h = 0.05, b = 1;
            double x = a, sigma = 0;
            double s,y;
            s = (Math.Pow(x, (2*i))) / Factorial(2*i);


            while ((Math.Abs(s) >= 0.0001) && (x <= b))
            {
                sigma += s;
                y = (Math.Exp(x) + Math.Exp(-x)) / 2;
                Console.WriteLine($"i = {i}, y(x) = {y}, current = {sigma}");
                x += h;
                i += 1;
                s = ((Math.Pow(x, (2*i))) / Factorial(2*i));
            }
            Console.WriteLine($"Final sum = {sigma}");
        }
    }
}
