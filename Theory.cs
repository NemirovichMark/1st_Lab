// lev.1 ex.4
Console.WriteLine("Enter the x value. But no less -2 147 483 648 and no more 2 147 483 647");
int x = checked(Convert.ToInt32(Console.ReadLine()));
double s = 0;
if (s != 0)
{
    Console.WriteLine("The value of the variable is zero!");
}
    for (int i = 1; i < 10; i++)
    {
        double a = Math.Cos(i * x) / Math.Pow(x,i-1);
        s = s + a;
    }

Console.WriteLine($"The value of the expression is {s}");
#endregion
#region ex 9
int factorial = 1;
int s = 0;
int one = -1;
int f = 5;

for (int i = 1; i <7; i++)
{
    s += one * f / factorial;
    factorial *= i;
    f *= 5;
    one = -one;
}
Console.WriteLine(s);

#endregion

#region ex.15
double n0 = 1;
    double d0 = 1;
    double n1 = 2;
    double d1 = 1;
    double a;
    double b;
    for (int i = 3; i < 6; i++)
    {
        a = d1 + d0;
        d0 = d1;
        d1 = a;
        b = n0 + n1;
        n0 = n1;
        n1 = b;
    }
    Console.WriteLine($"{n1 / d1}");
#endregion 
#region ex.16
double count = 0;
    for (int i = 1; i < 65; i++, count++)
    {
        count *= 2;
        count += count;
    }
    Console.WriteLine($"The king owes the sage {count / 15} grams of grain");
#endregion 

#region ex.17 Выполнил по ошибке, но решил оставить
int r = 6350;
    double d = 0;
for (int i = 1; i < 11; i++)
{
    d = Math.Sqrt(i * (2 * r + i));
    Console.WriteLine($"At a altitude of {i} km the distance to the horizon will be {d} km");
}
#endregion 
#region  ex.18
int s = 10;
    int num = 10;
    for (int i = 3; i < 25; i += 3)
    {
        s *= 2;
        Console.WriteLine($"After {i} hours will be {s} cells");
    
    }
#endregion 
#region  lev. 2 ex.2
int p = 1;
    int n = -2;
    while (p * n < 30000)
    {
        n += 3;
        p *= n;
    }
    Console.WriteLine(n);
#endregion 
#region  ex.4
Console.WriteLine("Введите число по модулю меньшее еденице, и не ноль");
    double x = Convert.ToDouble(Console.ReadLine());
    double sum = 0;
    int n = 0;
    if (x >= 1 | x <= (-1.0) | x == 0)
    {
        Console.WriteLine("The number is not in the range");

    }
    else
    {
        while (Math.Pow(x, 2 * n) > 0.0001)
        {
            sum += Math.Pow(x, 2 * n);
            n++;
        }
        Console.WriteLine(sum);
    }
#endregion 
#region ex.8.a
double n = 10;
    double d = 0.1;
    double sum = 0;
    double c = 0;
    double res = 0;
    for (int i = 1; i < 8; i++)
    {
        sum += c * d;
        c = sum + n;
        res += c;
    }
    Console.WriteLine(res);
#endregion 
#region ex8.b
double n = 10;
    double d = 0.1;
    double sum = 0;
    double c = 0;
    double res = 0;
    int i = 0;

    while (sum < 100)
    {
        i++;
        sum += n;
        c = sum + n;
        res += c;
        n *= 1.1;
    }
    Console.WriteLine($"After {i} days");
#endregion 
#region ex. 8.
double n = 10;
    double d = 0.1;
    double sum = 0;
    double c = 0;
    double res = 0;
    int i = 0;
    while (c < 20)
    {
        sum += c * d;
        c = sum + n;
        res += c;
        i++;
    }
    Console.WriteLine($"After {i} days");

#endregion 

#region ex. 1

double s, a, x, y, zn ;
int i = 0;
double xh = 0.1, xk=1.0, h = 0.1;  
int n = (int)((xk-xh)/ h );
x = xh;
for (int j = 1; j <= n; j++)
{ 
    s = 1; a = 1; zn = -1; i = 0;

    while (0.0001 <= Math.Abs(a)) 
    {
        i++;
        a *= zn*i*i*Math.Pow(x, i)/(2*i);
        s += a;

    } 
    y = Math.Cos(x);
    Console.WriteLine($"{Math.Round(x,2)} {Math.Round(s,3)} {Math.Round(y,3)}");

    x += h;
#endregion
}
#region ex.8
double x, y, a, s, fact;

for (x = 0.1; x <= 1 + 0.0001; x += 0.05)
{
    s = 1;
    a = 1;
    fact = 1;
    for (int i = 1; Math.Abs(a) > 0.0001; i += 1)
    {
        fact *= i;
        a = Math.Pow(2*x, i) / (fact);
        s += a;
    }

    y = Math.Pow(Math.E, 2 * x);

    Console.WriteLine($"x={Math.Round(x, 3)}  y={Math.Round(y, 3)}  s={Math.Round(s, 3)}");
}

#endregion 
