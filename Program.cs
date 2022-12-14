#region Task_1.4
double N = Convert.ToDouble(Console.ReadLine());
int UP = 1;
int DOWN = 0;
double a = 0;
double x = N;
for (UP = 1; UP <= 9; UP += 1)
{
    x = UP * N;
    a = a + (Math.Cos(x) / Math.Pow(N, DOWN));
    DOWN = DOWN + 1;
    Console.WriteLine(a);
}
#endregion

#region Task_1.9
double x = 0;
double a = 0;
double f = 0;
for (x = 1; x <= 6; x += 1)
{
    f = f + x;
    a = a + Math.Pow(-1, x) * (Math.Pow(5, x) / f);
}
Console.Write(a);
#endregion

#region Task_1_15
double up1 = 2;
double up2 = 3;
double up3 = 0;
double down = 2;
double x = 1;
for (x = 1; x <= 5; x += 1)
{
    up3 = up2 + up1;
    down = up2;
    up1 = up2;
    up2 = up3;
    Console.WriteLine(up3 + "/" + down);
}
#endregion

#region Task_1_16
double x = 0;
double n = 2;
double s = 0;
for (x = 1; x <= 64; x += 1)
{
    s = s + n;
    n = n * 2;
}
Console.WriteLine(s / 15 + " grams");
#endregion

#region Task_1_18
double x1 = 10;
double f = 0;
for (f = 0; f <= 24; f += 3)
{
    x1 = x1 * 2;
}
Console.WriteLine(x1);
#endregion

#region Task_2_2
int p = 1;
int n = 1;
int L = 1;
while (L <= 30000)
{
    n = n + 3;
    p = p * n;
    L = p * (n + 3);
}
Console.WriteLine(n);
#endregion

#region Task_2_4
double x = Convert.ToDouble(Console.ReadLine());
double s = 1;
double n = 1;
if (Math.Abs(x) < 1)
{
    while (Math.Pow(x, n * 2) >= 0.0001)
    {
        s = s + Math.Pow(x, n * 2);
        n += 1;
    }
    Console.WriteLine(s);
}
else
{
    Console.WriteLine("Вы ввели некоректное число");
}
#endregion

#region Task_2_8а
double x = 10;
double n = 1;
double s = 0;
for (n = 1; n <= 7; n = n + 1)
{
    s = s + x;
    x = x + x / 10;
}
Console.WriteLine(Math.Round(s, 2) + " км");
#endregion

#region Task_2_8б
double x = 10;
double n = 0;
double s = 0;
while (s < 100)
{
    n = n + 1;
    s = s + x;
    x = x + x / 10;

}
Console.WriteLine(n);
#endregion

#region Task_2_8в
double x = 10;
double n = 0;
double s = 0;
while (x < 20)
{
    n = n + 1;
    s = s + x;
    x = x + x / 10;
}
Console.WriteLine(n);
#endregion

#region Task_3_1
double high = 1;
double low = 0.1;
double step = 0.1;
double x;
double s = 1;
for (x = low; x <= high; x += step)
{
    double y = 1; double f = 1; double i;
    for (i = 1; Math.Abs(y) >= 0.0001; i++)
    {
        f *= (2 * i - 1) * 2 * i;
        y = Math.Pow(-1, i) * Math.Pow(Math.Round(x, 1), 2 * i) / f;
        s = s + y;
    }
    Console.WriteLine("Answer: " + s + "\ny = " + Math.Cos(s) + "\n");
}
#endregion

#region Task_3_5
double pi = Math.PI;
double b = pi;
double a = pi / 5;
double step = pi / 25;
double x;
double s = 0;
for (x = a; x <= b; x += step)
{
    double y = 1; double i;
    for (i = 1; Math.Abs(y) >= 0.0001; i++)
    {
        y = Math.Pow(-1, i) * Math.Cos(x * i) / Math.Pow(i, 2);
        s = s + y;
    }
    Console.WriteLine("Answer " + s);
    Console.WriteLine("y = " + (Math.Pow(x, 2) - Math.Pow(pi, 2)) / 4);
}
#endregion