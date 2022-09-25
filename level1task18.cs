using System;
class HelloWorld
{
    static void Main()
    {
        //string vvod = Console.ReadLine();
        //double x = Convert.ToInt32(vvod);
        double count = 10;
        Console.WriteLine("Amoebas in 0 hours: " + count);
        for (int i=3; i<=24; i=i+3)
        {
            count = count * 2;
            Console.WriteLine("Amoebas in " + i + " hours: " + count);
        }
        }
    }

