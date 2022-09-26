using System;

namespace LaboratoryL2N4
{
    class Program
    {
        static int Main(string[] args)
        {
            Console.Write("Input: ");
            string input = Console.ReadLine();
            bool result = double.TryParse(input, out var x);
            if (((x < 1) && (x > -1) && (result == true)) == false)
            {
                Console.WriteLine("Incorrect data");
                return 1;
            }
            double s = 0, sum = 0;
            bool flag = true;
            int i = 0;
            while (flag)
            {
                s = Math.Pow(x,2*i);
                if (s < 0.0001)
                {
                    flag = false;
                    Console.WriteLine($"Answer: {sum}");
                    return 0;
                }
                else
                {
                    sum += s;
                    i++;
                }
            }
            return 0;
        }
    }
}