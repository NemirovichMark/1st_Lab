//4
using System.Net.NetworkInformation;

int x = int.Parse(Console.ReadLine());
double s = 0;
int st = 1;
if (x != 0)
{
    for (int i = 1; i < 10; i = i + 1)
    {
        s = s + Math.Cos(i * x) / st;
        st = st * x;
    }
    Console.WriteLine(s);
}
else
{
    Console.WriteLine("x=0");
}
//9
s = 0;
int f = 1;
int p = 1;
for (int i = 1; i < 7; i = i + 1)
{
    p = p * ((-1) * 5);
    f = f * i;
    s = s + (p / f);
}
Console.WriteLine(s);
//15
double x1 = 1;
double x2 = 2;
double z, y;
for (int i = 3; i < 6; i = i + 1)
{
    z = x1;
    x2 = x1 + x2;
    x1 = z;
    y = x1;
}
Console.WriteLine(x2 / x1);
//16
double c = 1;
double t = 1;
for (int i = 1; i < 65; i = i + 1)
{
    t = t * 2;
    c = c + t;
}
Console.WriteLine(c / 15);
//18
int count = 10;
for (int i = 3; i < 25; i = i + 3)
{
    count = count * 2;
    Console.Write("Через");
    Console.Write(i);
    Console.Write("часов:");
    Console.WriteLine(count);
}
Console.WriteLine("");
Console.WriteLine("");
Console.WriteLine("");
//2 уровень
//2
int p1 = 1;
int n = 1;
while (p < 30001)
{
    n = n + 3;
    p1 = p1 * n;
}
Console.WriteLine(p / n);
Console.WriteLine(n - 3);
//4
int s1 = 1;
double x3 = double.Parse(Console.ReadLine());
if (x3 > 0 & x3 < 1)
{
    double e = 1;
    while (e >= 0.0001)
    {
        e = e * x3 * x3;
        s = s + e;
    }
    Console.WriteLine(s);
}
//78
//a
double put = 10;
double put1 = 0;
for (int i = 1; i < 8; i = i + 1)
{
    put1 = put1 + put;
    put = put * 1.1;
}
Console.WriteLine(put1);
//b
double w = 0;
int k = 0;
double w1 = 10;
while (w < 100)
{
    w = w + w1;
    w1 = w1 * 1.1;
    k = k + 1;
}
Console.WriteLine(k);
//в
double w2 = 10;
int k1 = 0;
while (w2 <= 20)
{
    w2 = w2 * 1.1;
    k = k + 1;
}
Console.WriteLine(k);
//3 уровень
//1
for (double x0 = 0.1; x0 <= 1; x0 = x0 + 0.1)
{
    int factor = 1;
    int factor1 = 0;
    int zn = -1;
    double sum = 1;
    double sum1 = 1;
    double sum2;
    do
    {
        factor1 = factor1 + 2;
        factor = factor * (factor1 - 1) * (factor1);
        sum1 = zn * sum1 * (x0 * x0 / factor);
        sum = sum + sum1;
        zn = zn * (-1);
        sum2 = sum1;
        if (sum2 < 0)
        {
            sum2 = sum2 * (-1);
        }
    }
    while (sum2 < 0.0001);
    Console.WriteLine(Math.Cos(x0));
}
//9
for (double x9 = 0.1; x9 <= 0.5; x9 = x9 + 0.05)
{
    double sum1 = x9;
    double sum2;
    double sum = 0;
    int znak = 1;
    int q = 0;
    do
    {
        sum = sum + sum1;
        sum1 = znak * sum1 * ((x9 * x9) / (q * 2 + 1));
        q = q + 1;
        sum2 = sum1;
        if (sum2 < 0)
        {
            sum2 = 0 - sum2;
        }
    }
    while (sum2 < 0.0001);
    Console.WriteLine(Math.Atan(x9));
}






