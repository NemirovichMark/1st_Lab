using System;

# region 1/4

double n = 1, x, k = 1;
Console.WriteLine("Type value for x (radians)");
x = Convert.ToDouble(Console.ReadLine());
while (x == 0)
{
    Console.WriteLine("X can't be equal 0, try another value");
    x = Convert.ToDouble(Console.ReadLine());
}
double s = Math.Cos(x);
while (n <= 9) {
    k += 1;
    n += 1;

    s = s + ( Math.Cos(k * x) / ((k - 1) * x) );
}
Console.WriteLine($"{s}");

#endregion 1/4
Console.WriteLine("-------");
#region 1/9

double c = 0, cf = 1;
s = 0;
while (c < 6) {
    c += 1;
    cf *= c;
    s += Math.Pow(-1, c) * Math.Pow(5, c) / cf;
}
Console.WriteLine($"{s}");

#endregion 1/9 
Console.WriteLine("-------");
#region 1/15

double ch0 = 1, zn0 = 1, ch1 = 2, zn1 = 1, cur = 0;
c = 0;
while (c < 3) {
    c += 1;
    cur = (ch0 + ch1) / (zn0 + zn1);
    ch1 = ch1 + ch0;
    ch0 = ch1 - ch0;
    zn1 = zn1 + zn0;
    zn0 = zn1 - zn0;
}
Console.WriteLine(cur);

#endregion 1/15 
Console.WriteLine("-------");
#region 1/16

double f = 1;
c = 1;
s = 0;
while (c <= 64)
{
    c++;
    s += f;
    f *= 2;
}
Console.WriteLine($"Mass of seed equals {s}");
#endregion 1/16 
Console.WriteLine("-------");
#region 1/18

c = 0;
f = 10;
while (c < 24)
{
    c += 3;
    f *= 2;
}
Console.WriteLine($"{f}");
Console.WriteLine("-------");
#endregion 1/18 