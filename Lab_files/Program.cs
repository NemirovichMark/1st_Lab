using System;

namespace Laboratory
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
            double a = 0.1, b = 1, h = 0.1;
            double x = a, sigma = 0;
            double s = ((Math.Pow(-1.00, i)) * Math.Pow(x, (2*i)));

            while ((Math.Abs(s) >= 0.0001) || (x > b))
            {
                Console.WriteLine($"i = {i}, y(cos(x)) = {Math.Cos(x)}");
                sigma += s;
                s = (((Math.Pow(-1.00, i)) * Math.Pow(x, (2*i))) / Factorial(2*i));
                x += h;
                i += 1;
            }
        }
    }
}
