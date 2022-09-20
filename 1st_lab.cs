// See https://aka.ms/new-c
#region lvl1task4
double x = Convert.ToDouble(Console.ReadLine());
double S = Math.Cos(x);

if (x != 0)
{
    for (int i = 2; i < 9; i++)
    {
        S += Math.Cos(i * x) / Math.Pow(x, i - 1);
    }
    Console.WriteLine($"lvl1Task4 - {S}");
}
else
{
    Console.WriteLine("Please, input value non equal null");
}
#endregion



#region lvl1Task9
double S1 = 0;

int fact0 = 1;

for (int i = 1; i < 7; i++)
{
    fact0 *= i;
    S1 += Math.Pow(-1, i) * Math.Pow(5, i) / fact0;
}
Console.WriteLine($"lvl1Task9 - {S1}");
#endregion


#region lvl1Task16
double corn = 1;
for (int i = 0; i < 64; i++)
{
    corn += Math.Pow(2, i);
}
corn /= 15000;
Console.WriteLine($"lvl1Task16 - Requires {corn} a kilogram of grain");
#endregion

#region lvl1Task18
int cell_count = 10;
for (int i = 3; i <= 24; i += 3)
{
    cell_count *= 2;
    Console.WriteLine($"lvl1Task18 - {cell_count}");
}
#endregion

#region lvl1Task15
int first_numerator = 1, second_numerator = 2, temp_numerator = 0;
int first_unnumerator = 1, second_unnumerator = 1, temp_unnumerator = 0;
for (int i = 0; i < 3; i++)
{
    temp_numerator = second_numerator;
    second_numerator += first_numerator;
    first_numerator = temp_numerator;

    temp_unnumerator = second_unnumerator;
    second_unnumerator += first_unnumerator;
    first_unnumerator = temp_unnumerator;
}
Console.WriteLine($"lvl1Task15 - {second_numerator}/{second_unnumerator}");

#endregion


#region lvl2Task2
int number = 1;
int p = 1;
while (p < 30000)
{
    number += 3;
    p *= number;
}
Console.WriteLine($"lvl2Task2 - {number - 3}");
#endregion

#region lvl2Task4


double x1 = Convert.ToDouble(Console.ReadLine());

double s = 1;

double n = 1;

double eps = 0.0001;

if (x1 != 0 & x1 < 1 & x1 > -1)
{
    do
    {
        x1 = Math.Pow(x1, n);
        s += x1;
        n += 1;
    } while (x1 > eps);
    Console.WriteLine($"lvl2Task4 {s}");
}
else
{
    Console.WriteLine("Enter value in the range [-1;1]");
}
#endregion

#region lvl2Task7(a)
double way_a = 10;
double total_way = 10;

for (int i = 1; i < 7; i++)
{
    way_a *= 1.1;
    total_way += way_a;
}
Console.WriteLine($"lvl2Task8(a) - {total_way}");
#endregion

#region lvl2Task7(b)
double way_per_day = 10;
double way_b = 10;
int day_count_b = 1;
do
{
    way_per_day *= 1.1;
    way_b += way_per_day;
    day_count_b += 1;
} while (way_b < 100);
Console.WriteLine($"lvl2Task8(b) - {day_count_b}");
#endregion

#region lvl2Task7(c)
double way_c = 10;
double day_count_c = 1;
while (way_c < 20)
{
    way_c *= 1.1;
    day_count_c += 1;
}
Console.WriteLine($"lvl2Task8(c) - {day_count_c}");
#endregion


#region lvl3Task1
Console.WriteLine("lvl3Task1:");
double absol_3 = 0.0001;
int i_3 = 0;
double c_3 = 0;
double s_3 = 0;
int fact = 1;
for (double x_3 = 0.1; x_3 <= 1; x_3 += 0.1)
{
    i_3 = 0;
    fact = 1;
    while (true)
    {
        fact *= 2 * i_3;
        c_3 = Math.Pow(-1, i_3) * Math.Pow(x_3, 2 * i_3) / fact;
        s_3 += c_3;

        if (c_3 < absol_3)
        {
            Console.WriteLine($"S = {s_3}\nf(x) = {Math.Cos(x_3)}\n");
            break;
        }
        i_3 += 1;
    }

}

#endregion


#region lvl3Task4
Console.WriteLine("lvl3Task4:");
double absol_4 = 0.0001;
int i_4 = 0;
double s_4 = 0;
double c_4;
int fact1 = 1;
for (double x_4 = 0.1; x_4 <= 1; x_4 += 0.1)
{
    i_4 = 0;
    fact1 = 1;
    while (true)
    {
        fact *= i_3;
        c_4 = ((2 * i_4) + 1) * Math.Pow(x_4, 2 * i_4) / fact1;
        s_4 += c_4;
        if (c_4 < absol_4)
        {
            Console.WriteLine($"S = {s_4}\nf(x) = {(1 + (2 * x_4 * x_4)) * Math.Pow(Math.Exp(x_4), 2)}\n");
            break;
        }
        i_4 += 1;
    }

}

#endregion
