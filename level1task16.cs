using System;
class HelloWorld
{
    static void Main()
    {
        string vvod = Console.ReadLine();
        double x = Convert.ToInt32(vvod);
        double sum = 0;
        double perem = 1;
        for (int i = 0; i < 64; i++)
        {
            perem = perem * 2;
            sum = sum + perem;
        }
        double mass = sum / 15000000;
        Console.WriteLine("Mass in tones:" + mass);
    }
}

