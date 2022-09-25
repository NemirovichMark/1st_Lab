using System;
class HelloWorld
{
    static int Main()
    {
        //double x = Convert.ToDouble(Console.ReadLine());
        double denpervii = 10;
        double denocherednoy;
        double den100km=0;
        double sum7dney = 0;
        double sum = 0;
        double den20km=0;
        denocherednoy = denpervii;
        for (int i = 0; i < 7; i++)
        {
            sum7dney = sum7dney + denocherednoy;
            denocherednoy = denocherednoy * 1.1;
        }
        denocherednoy = denpervii;
        for (int i = 1; sum < 100; i++)
        {
            sum = sum + denocherednoy;
            denocherednoy = denocherednoy * 1.1;
            den100km = i;
        }
        denocherednoy = denpervii;
        for (int i = 1; denocherednoy <= 20; i++)
        {
            denocherednoy = denocherednoy * 1.1;
            den20km = i;
        }
        den20km = den20km + 1;
        Console.WriteLine("Answere for a: " + sum7dney);
        Console.WriteLine("Answere for b: " + den100km);
        Console.WriteLine("Answere for v: " + den20km);
        return 0;
    }
}

