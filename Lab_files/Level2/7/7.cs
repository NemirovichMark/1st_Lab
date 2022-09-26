using System;

namespace LaboratoryL2N7
{
    class Program
    {
        static void Main(string[] args)
        {
            float distance = 10.0f;
            float total = 0.0f;
            bool flag2 = false, flag1 = false;
            for (int i = 2; ; i++)
			{
                distance *= 1.1f;
                total += distance;
                if (i == 7)
                {
                    Console.WriteLine($"Answer a): {distance}");
                }
                if ((total >= 100) && (flag1 == false))
                {
                    flag1 = true;
                    Console.WriteLine($"Answer b): {i} days");
                }
                if ((distance > 20) && (flag2 == false))
                {   
                    flag2 = true;
                    Console.WriteLine($"Answer c): on the {i}'th day");
                    break;
                }
			}
        }
    }
}