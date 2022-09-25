using System;

namespace LaboratoryL3N1
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            double a = 0.1, h = 0.1;
            double x = a, sigma = 0;
            double s, s_prev;
            s = ((Math.Pow(-1.00, i)) * Math.Pow(x, (2*i)));

            while ((Math.Abs(s) >= 0.0001))
            {
                sigma += s;
                s_prev = s;
                Console.WriteLine($"i = {i}, y(cos(x)) = {Math.Cos(x)}, current = {sigma}");
                x += h;
                i += 1;
                s = -s_prev * ((Math.Pow(x,2)) / ((2*i-1) * (2*i)));
            }
            Console.WriteLine($"Final sum = {sigma}");
        }
    }
}
