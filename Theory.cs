using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace lab1s
{
    internal class Program
    {
        static void Main()
        {
            #region task1_4
            double x = Convert.ToInt32(Console.ReadLine());
            double s = 0, grade=0;
            if (x <= 0)
            {
                Console.WriteLine($"Enter normal number");
            }
            else
            {
                double aa = 1 / x;
                for (int yyy = 1; yyy <= 9; yyy++)
                {
                    grade = grade + x;
                    aa = aa * x;
                    s = s + (Math.Cos(grade) / aa);
                }
                Console.WriteLine($"answer on task 1_4 - {s}");
            }
            #endregion
            #region task1_9
            int factorial = 1, five=1;
            double sum = 0;
            for (int z = 1; z <= 6; z++)
            {
                factorial *= z;
                five *= -5;
                sum = sum + five / factorial;

            }
                Console.WriteLine($"answer on task 1_9 - {sum}");
                #endregion
                #region task1_15
                double chislitel = 1 ;
                double znamenatel = 1;
            double summ = 1;
                double flag;
            if (znamenatel == 0)
            {
                Console.WriteLine($"znamenatel ne dolzen bit 0");
            }
            else
            {
                for (int j = 2; j <= 5; j++)
                {
                    flag = chislitel;
                    chislitel = chislitel + znamenatel;
                    znamenatel = flag;
                    summ = summ + chislitel / znamenatel;
                }
                Console.WriteLine($"answer on task 1_15 - {summ}");
            }

            #endregion
            #region task1_16
            ulong  mas = 15;
            ulong zerna = 1;
            ulong kolichestvo = 1;
            for (int j=1; j<=63; j++)
            {
                zerna *=2;
                kolichestvo += zerna;
            }
            ulong otvet = kolichestvo / mas;
            Console.WriteLine($"answer on task1_16 - {otvet}");
            #endregion
            #region task1_18
            double ameba = 10;
            for (int w=3; w<=24;w+=3)
            {
                ameba *=2;
                Console.WriteLine($"answer on task 1_18 - hours {w}, kletok {ameba}");
            }
            #endregion
            #region task2_2
            int p = 1, n = 1, L = 30000;
            while (p<L)
            {
                n += 3;
                p *= n;
            }
            Console.WriteLine($"answer on task 2_2 - {n-3}");
            #endregion
            #region task2_4
            double sym=1;
            double d = double.Parse(Console.ReadLine());
            if (d >= 1)
            {
                Console.WriteLine($"Write d < 1");
            }
            else
            {
                while (d>0.0001)
                {
                    d =d* d;
                    sym = sym + d;
                }
                Console.WriteLine($"answer on task 2_4 - {sym - d}");
            }
            #endregion
            #region task 2_7 and 8
            int lamp = 0;
            double distance = 10, days=1,finish=0,norma=10,lastday=0,maxnorma=0;
            for (int q = 1; q<=7; q++)
            {
                norma = norma * 1.1;
                distance = distance + norma;
            }
            Console.WriteLine($"answer on task 2_7 and 8 a) {distance}");
            distance = 10;
            norma = 10;
            while (distance <100)
            {
                norma = norma * 1.1;
                distance = distance + norma;
                days += 1;
            }
            Console.WriteLine($"answer on task 2_7 and 8 b) {days}");
            days = 1;
            norma = 10;
            while (norma<=20)
                {
                norma = norma * 1.1;
                days += 1;
            }
            Console.WriteLine($"answer on task 2_7 and 8 c) {days}");
            #endregion
            #region task 3_1
            for (x = 0.1; x <= 1; x+=0.1)
            {
                sum = 1;
                int ii = 1;
                if (ii == 0)
                {

                }
                else
                {
                    double first = -1;
                    double q = 1;
                    while (q > 0.0001)
                    {
                        q *= (x * x) / (2 * ii * (2 * ii - 1));
                        sum = sum + q * first;
                        ii += 1;
                        first = -first;
                    }
                    double yy = Math.Cos(x);
                    Console.WriteLine("sum - {0:f5} y - {1:f5} x - {2:f5}", sum, yy, x);
                }
            }
            #endregion
            #region task3_2
            double k = 1,y;
            int i = 1;
            double b,f,h;
            s = 0;
            for ( x= 0.1; x <=0.8; x+=0.1) 
            {
                do
                {
                    k *= x;
                    s += k * Math.Sin((i * Math.PI) / 4);
                    i += 1;
                }
                while (Math.Abs(k * Math.Sin((i * Math.PI) / 4)) > 0.0001);
                i = 1;
                k = 1;
                y = (x*Math.Sin(Math.PI/4)) / (1-2*x*Math.Cos(Math.PI/4)+x*x);
                Console.WriteLine("x={0:f5}, y={1:f5} , s={2:f5}", x, y, s);
                s = 0;
            }
            #endregion
        }
    }
}
