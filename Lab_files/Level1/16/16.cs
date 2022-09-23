using System;

namespace LaboratoryL1N16
{
    class Program
    {
        static void Main(string[] args)
        {
            ulong count = 1;
            ulong last = 1;
            for (int i = 2; i <= 64; i++)
            {
                last = last * 2;
                count += last;
            }

            Console.WriteLine($"Seeds to be placed: {count}, weight: {count / 15}");
        }
    }
}
