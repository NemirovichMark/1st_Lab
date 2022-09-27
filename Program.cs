using System;

class lub1
{
    static int Factorial(int n)
    {
        if (n == 1) return 1;
        return n * Factorial(n - 1);
    }
    static void Main()
    {


        #region Lvl1_task4
        double s = 0.0;
        int x = Convert.ToInt32(Console.ReadLine());
        if (x != 0)
        {
            for (int i = 1; i != 10; i++)
            {
                s = Math.Cos(i * x) / Math.Pow(x, i - 1) + s;

            }
        }
        Console.WriteLine($"L1,task4 {s}");
        #endregion

        #region Lvl1_task9
        double s9 = 0.0;
        for (int i9 = 1; i9 < 7; i9++)
        {
            s9 = (Math.Pow((-1), i9) * Math.Pow(5, i9)) / Factorial(i9) + s9;

        }
        Console.WriteLine($"L1,task9 {s9}");
        #endregion

        #region lvl1_task15
        double n15 = 1, d15 = 1;
        for (int i15 = 0; i15 < 4; i15++)
        {
            n15 += d15;
            d15 = n15 - d15;
        }
        Console.WriteLine($"L1,task15 { n15 / d15}");
        #endregion

        #region Lvl1_task16
        double n16 = 1;
        for (int i16 =0; i16<65; i16++)
        {
            n16 += n16 * 2;
        }
        Console.WriteLine($"L1,task16 {n16/15}");
        #endregion

        #region Lvl1_task18
        int am = 10;
        for (int h = 0; h < 24; h+=3) 
        {
            am = am * 2;
            Console.WriteLine($"L1,task18 {am}");
        }
        #endregion



        #region Lvl2_task2
        int p = 1;
        int i2 = 1;
        int L = 30000;
        while (p < L)
        {
            i2 += 3;
            p = p * i2;
        }
        Console.WriteLine($"Lvl2_task2 {i2-3}");
        #endregion

        #region Lvl2_task4
        double x4 = Convert.ToDouble(Console.ReadLine());
        double s4 = 1;
        double e = 0.0001;
        int n = 1;

        if (Math.Abs(x4) >= 1) Console.WriteLine("wrong x");
        else
        {
            while (true)
            {
                double i4 = Math.Pow(x4, 2 * n);
                if (i4 < e) break;
                else s4 += i4;
                n += 1;
            }
        }
         Console.WriteLine($"Lvl2_task4 {s4}");
        #endregion

        #region Lvl2_task8
        double d1 = 10;
        double sum = 0;
        for (int k = 0; k < 7; k++)
        {
            sum += d1;
            d1 += d1 * 0.1;
        }
        Console.WriteLine($"Lvl2_task8(a) {sum}");
        double s2 = 0;
        double day1 = 10;
        int days = 0 ;
        while (s2<100)
        {
            s2 += day1;
            day1 = day1 * 1.1;
            days += 1;
        }
        Console.WriteLine($"Lvl2_task8(b) {days}");
        double day3 = 10;
        int days3 = 1;
        while(day3<20)
        {
            day3 = day3 * 1.1;
            days3 += 1;
        }
        Console.WriteLine($"Lvl2_task8(c) {days3}");
        #endregion

        #region Lvl3_task1
        double a1 = 0.1;
        double b3 = 1;
        double h3 = 0.1;
        double s33 = 0;
        double sum1 = 0;
        double hod = 0;
        for (double xx = a1; xx <= b3; xx += h3)
        {
            int i3 = 1;
            hod = 0;
            int fctr = 1;
            do
            {
                fctr *= ((2 * i3 - 1) * 1 * 2);
                hod = Math.Pow(-1, i3) * Math.Pow(xx, i3 * 2) / (fctr * 2);
                s33 += hod;
                i3++;
            } while (hod >= 0.0001);
            double y = Math.Cos(xx);
            sum1 += s33;
            Console.WriteLine($"x: {xx}, y: {y}, s: {s33}");
        }
        Console.WriteLine("Sum: " + Math.Round(sum1));
        #endregion
        #region Lvl3_task1
        double a11 = 0.1;
        double b33 = 1;
        double h33 = 0.05;
        double s333 = 0;
        double sum11 = 0;
        double hod1 = 0;
        for (double xx1 = a11; xx1 <= b33; xx1 += h33)
        {
            int i33 = 1;
            hod1 = 0;
            int fctr1 = 1;
            do
            {
                fctr1 *= ((2 * i33 - 1) * 1 * 2);
                hod1 = Math.Pow(xx1, i33 * 2) / (fctr1 * 2);
                s333 += hod1;
                i33++;
            } while (hod1 >= 0.0001);
            double y1 = (Math.Exp(xx1)+Math.Exp(-xx1)) / 2;
            sum11 += s333;
            Console.WriteLine($"x: {xx1}, y: {y1}, s: {s333}");
        }
        Console.WriteLine("Sum: " + Math.Round(sum11));
        #endregion

    }
}
