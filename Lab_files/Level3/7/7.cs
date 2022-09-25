using System;

namespace LaboratoryL3N7
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            double a = 0.1, h = 0.05, b = 1;
            double x = a, sigma = 0;
            double s,y;
            s = Math.Pow(x, (2*i));
            
            while ((Math.Abs(s) >= 0.0001) && (x <= b))
            {
                sigma += s;
                y = (Math.Exp(x) + Math.Exp(-x)) / 2;
                Console.WriteLine($"i = {i}, y(x) = {y}, current = {sigma}");
                x += h;
                i += 1;
                int Factorial = 1;
                for (int j = 2*i; j >= 1; j--)
                {
                    Factorial *= j;
                }
                s = ((Math.Pow(x, (2*i))) / Factorial);
            }
            Console.WriteLine($"Final sum = {sigma}");
        }
    }
}
