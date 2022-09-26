using System;

namespace LaboratoryL2N2
{
    class Program
    {
        static void Main(string[] args)
        {
            int p = 1, L = 30000, n = 1;
            bool flag = true;
            while (flag)
            {
                p *= n;
                if (p > L)
                {
                    flag = false;
                    Console.WriteLine($"Answer: {n-3}");
                }
                n += 3;
            }
        }
    }
}