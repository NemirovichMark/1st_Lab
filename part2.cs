using System;

#region 2/2

double a = 1, c = 1;
while (a <= 30000)
{
    c = c + 2;
    a = a * c;
}
Console.WriteLine($"{c - 2}");

#endregion 2/2

#region 2/4

double n = 1, x = 1, s = 1;

while (Math.Abs(x) >= 1)
{
    try
    {
        Console.WriteLine("Enter value for x");
        x = Convert.ToDouble(Console.ReadLine());
        if (Math.Abs(x) >= 1)
        {
            Console.WriteLine("X's value got to be less than 1, more than -1");
        }
    }
    catch 
    {
        Console.WriteLine("X is number, not a symbol(s)");
    }
}

while (Math.Pow(x, 2*n) >= 0.0001)
{
    s = s + Math.Pow(x, 2*n);
    n += 1;
}
Console.WriteLine($"{s}");

#endregion 2/4

#region 7/4

double z = 1, v = 1;
s = 10;
while (z < 7)
{
    s *= 1.1;
    z += 1;
}
Console.WriteLine($"{s}");
s = 0;
z = 10;
while (s < 100)
{
    s += z;
    v += 1;
    z *= 1.1;
}
Console.WriteLine($"{v}");
v = 1;
z = 10;
while (z < 20)
{
    z *= 1.1;
    v += 1;
    Console.WriteLine($"{v}, {z}");
}
Console.WriteLine($"{v}, {z}");

#endregion 7/4