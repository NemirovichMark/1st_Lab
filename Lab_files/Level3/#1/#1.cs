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
            double s;
            s = ((Math.Pow(-1.00, i)) * Math.Pow(x, (2*i)));

            while ((Math.Abs(s) >= 0.0001))
            {
                sigma += s;
                Console.WriteLine($"i = {i}, y(cos(x)) = {Math.Cos(x)}, current = {sigma}");
                x += h;
                i += 1;
                int Factorial = 1;
                for (int j = 2*i; j >= 1; j--)
                {
                    Factorial *= j;
                }
                s = (((Math.Pow(-1.00, i)) * Math.Pow(x, (2*i))) / Factorial);
            }
            Console.WriteLine($"Final sum = {sigma}");
        }
    }
}
