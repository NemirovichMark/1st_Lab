#region 1.4
Console.WriteLine("Go bez nulley");
double x = Convert.ToDouble(Console.ReadLine());
double s = Math.Cos(x), a;
if (x != 0)
{
    for (int n = 2; n < 9; n++)
    {
        a = Math.Cos(n * x) / Math.Pow(x, n - 1);
        s = s + a;
    }
    s = s + Math.Cos(x);
    Console.WriteLine($"lvl1 tsk4 {s}");
}
else
{
    Console.WriteLine("Why are u bulling me?");
}
#endregion
#region 1.9
double s1 = 0;
int rofl = 1;
for (int i = 1; i < 7; i++)
{
    rofl = rofl * i;
    s1 += Math.Pow(-1, i) * Math.Pow(5, i) / rofl;
}
Console.WriteLine($"lvl1 tsk9 {s1}");
#endregion
#region 1.15
int chisl1 = 1, chisl2 = 2, tempchisl;
int znam1 = 1, znam2 = 1, tempznam;
for (int i = 0; i < 3; i++)
{
    tempchisl = chisl2;
    chisl2 = chisl1 + chisl2;    //sry for this bullshit
    chisl1 = tempchisl;

    tempznam = znam2;
    znam2 = znam1 + znam2;
    znam1 = tempznam;
}
Console.WriteLine($"lvl1 tsk15 {chisl2}/{znam2}");
#endregion
#region 1.16
double zerno = 1;
for (int i = 1; i < 65; i++)
{
    zerno += Math.Pow(2, i);
}
zerno = zerno / 15000;
Console.WriteLine($"lvl1 tsk16 {zerno} killogram zeren nasipali dedu");
#endregion
#region 1.18
int cell = 10;
for (int i = 3; i < 25; i += 3)
{
    cell *= 2;
    Console.WriteLine($"lvl1 tsk18 {cell}");
}
#endregion
#region 2.2
int num = 1;
int p = 1;
while (p < 30000)
{
    num = num + 3;
    p = p * num;
}
num = num - 3;
Console.WriteLine($"lvl2 tsk2 {num}");
#endregion
#region 2.4
double eps = 0.0001;
double s2 = 1, n2 = 1;
double lol = Convert.ToDouble(Console.ReadLine());
if (lol < 1 & lol > -1 & lol != 0)
{
    while (lol > eps)
    {
        lol = Math.Pow(lol, n2);
        n2 += 1;
        s2 += lol;
    }
    Console.WriteLine($"lvl2 tsk4{s2}");
}
else
{
    Console.WriteLine("Vvedi po bratski ot -1 do 1 bez nulley");
}

#endregion
#region 2.7.a
double dist = 10, totdist = 0;
for (int i = 0; i < 100; i++)
{
    dist *= 1.1;
    totdist += dist;

}
Console.WriteLine($"lvl2 tsk7.a {totdist}");
totdist = 0;
dist = 10;
#endregion
#region 2.7.b
int daycount = 1;
while (totdist < 100)
{
    dist *= 1.1;
    totdist += dist;
    daycount++;

}
Console.WriteLine($"lvl2 tsk7.b {daycount}");
dist = 10;
daycount = 1;
#endregion
#region 2.7.c
while (dist <= 20)
{
    dist *= 1.1;
    daycount++;
}
Console.WriteLine($"lvl2 tsk7.c {daycount}");
#endregion
#region 3.1
for (double x1 = 0.1; x1 < 1.1; x1 += 0.1)
{
    double y = Math.Cos(x1);
    double summ = 0;
    double elem = -1;
    double i = 1;
    do
    {
        elem = elem * (-1) * Math.Pow(x1, 2) / (2 * i * (2 * i - 1));
        i += 1;
        summ += elem;
    } while (elem > 0.0001);
    Console.WriteLine($"lvl3 tsk1 x -  {x1} y -  {y} sum -  {summ}");
}
#endregion
#region 3.8
Console.WriteLine(" ");
for (double x2 = 0.1; x2 < 1.05; x2 += 0.05)
{
    double y2 = Math.Pow(Math.E,2*x2);
    double elem2 = 1;
    double summ2 = 0;
    double i = 1;
    do
    {
        elem2 = elem2 * 2 * x2 / i;
        i += 1;
        summ2 += elem2;
    } while (elem2 > 0.0001);
    Console.WriteLine($"lvl3 tsk8 x - {x2} y - {y2} sum - {summ2}");
}
#endregion
