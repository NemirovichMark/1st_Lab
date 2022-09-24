using System;

namespace LaboratoryL1N18
{
    class Program
    {
        static void Main(string[] args)
        {
            int cells = 10;

            for (int i = 0; i < 24; i = i + 3)
            {
                cells = cells * 2;
                Console.WriteLine(cells);

            }
        }
    }
}
