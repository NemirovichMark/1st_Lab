namespace _1_lab
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Task 1_4

            Console.Write("Enter a number: ");
            string vvod;
            double x;
            vvod = Console.ReadLine();
            double.TryParse(vvod, out x);
            int a = 1;
            double s = 0, slag = 0, kof = 2;
            s = Math.Cos(x);
            for (int i = 2; i <= 9; i++)
            {
                slag = Math.Cos(kof * x) / Math.Pow(x, a);
                s += slag;
                a++;
                kof++;
            }
            Console.WriteLine(s);

            #endregion


            #region Task 1_9
            int demominator = 1, kof = 1;
            double answ = 0;
            for (int i = 1; i <= 6; i++)
            {
                kof *= -1;
                demominator *= i;
                answ += kof * Math.Pow(5, i) / demominator;
            }
            Console.WriteLine(answ);
            #endregion

            #region Task 1_15
            double num_1 = 1, dem_1 = 1, num_2 = 2, dem_2 = 1, num = 0, dem = 0;
            double answ;
            for (int i = 3; i <= 5; i++)
            {
                num = num_1 + num_2;
                num_1 = num_2;
                num_2 = num;
                dem = dem_1 + dem_2;
                dem_1 = dem_2;
                dem_2 = dem;
            }
            answ = (num_2 / dem_2);
            Console.WriteLine(answ);
            #endregion

            #region Task 1_16
            double sum = 1, grain = 1;
            for (int i = 2; i <= 64; i++)
            {
                grain = grain * 2;
                sum += grain;
            }
            Console.WriteLine(sum * 1 / 15);
            #endregion

            #region Task 1_18
            int ready = 10;
            for (int i = 3; i <= 24; i += 3)
            {
                ready *= 2;
                Console.WriteLine($"After {i} hours, {ready} cells", i, ready);
            }
            #endregion

            #region Task 2_2
            int p = 1, n = 0;
            for (int i = 1; p * i <= 30_000; i += 3)
            {
                p *= i;
                n = i;
            }
            Console.WriteLine(n);
            #endregion

            #region Task 2_4
            double s = 1, x, elem = 1, chek = elem;
            string vvod;
            Console.Write("Enter the number:");
            vvod = Console.ReadLine();
            double.TryParse(vvod, out x);
            if (Math.Abs(x) < 1)
            {
                while (chek >= 0.0001)
                {
                    elem *= Math.Pow(x, 2);
                    s += elem;
                    chek = elem * Math.Pow(x, 2);
                }
                Console.WriteLine(s);
            }
            else
            {
                Console.WriteLine("Error");
            }
            #endregion

            #region Task 2_7
            double distance_a = 10, norma_a = 10;
            const double percent = 1.1;
            for (int i = 2; i <= 7; i++)
            {
                norma_a = norma_a * percent;
                distance_a += norma_a;
            }
            Console.WriteLine($"a) {distance_a}", distance_a);

            double distance_b = 10, norma_b = 10;
            int day = 1;
            while (distance_b < 100)
            {
                norma_b = norma_b * percent;
                distance_b += norma_b;
                day += 1;
            }
            Console.WriteLine($"b) {day}", day);

            double norma_c = 10;
            int day_c = 1;
            while (norma_c <= 20)
            {
                norma_c = norma_c * percent;
                day_c += 1;
            }
            Console.WriteLine($"c) {day_c}", day_c);
            #endregion

            #region Task 3_1
            double a = 0.1, b = 1, h = 0.1, eps = 0.0001;
            double s = 1, kof = 1, dem = 1, element = 1;
            for (double x = a; x <= b; x += h)
            {
                double y = Math.Cos(x);
                for (int i = 1; Math.Abs(element) >= eps; i++)
                {
                    dem *= (2 * i - 1) * 2 * i;
                    kof *= -1;
                    s += kof * Math.Pow(x, 2 * i) / dem;
                    element = kof * Math.Pow(x, 2 * i) / dem;
                }
                Console.WriteLine($"answer: {s}", s);
                Console.WriteLine($"y = {y}", y);
            }
            #endregion

            #region Task 3_8
            double a = 0.1, b = 1, h = 0.05, eps = 0.0001;
            double s = 1, dem = 1, element = 1;
            for (double x = a; x <= b; x += h)
            {
                double y = Math.Pow(Math.E, 2 * x);
                for (int i = 1; element >= eps; i++)
                {
                    dem *= i;
                    s += Math.Pow(2 * x, i) / dem;
                    element = Math.Pow(2 * x, i) / dem;
                }
                Console.WriteLine($"answer: {s}", s);
                Console.WriteLine($"y = {y}", y);
            }
            #endregion 
        }
    }
}
