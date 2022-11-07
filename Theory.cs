using System;


namespace _1st_Lab
{
	class Program
	{
		static void Main(string[] args)
		{
			#region Lvl1_task4
			double s = 0.0;
			Console.WriteLine("Введите число не равное нулю");
			double x = Convert.ToDouble(Console.ReadLine());
			if (x != 0)
			{
				for (int i = 1; i != 10; i++)
				{
					s = Math.Cos(i * x) / Math.Pow(x, i - 1) + s;

				}
			}
			Console.WriteLine($"task 4: {s}");
			#endregion
			#region Lvl1_task9
			const int m = (-1);
			double z = 0;
			double Fact = 1;
			for (int i = 1; i <= 6; i++)
			{
				Fact *= i;
				z += Math.Pow(m, i) * Math.Pow(5, i) / Fact;
			}
			Console.WriteLine($"task 9: {z}");
			#endregion
			#region Lvl1_task15
			double a = 2, r = 1;
			double b = 1, u = 1;

			for (int i = 2; i < 5; ++i)
			{
				double t,g;
				t = a + r;
				g = b + u;
				r = a;
				u = b;
				a = t;
				b = g;
			}
			Console.WriteLine($"task 15: {a / b}");
			#endregion
			#region Lvl1_task16
			{
				int gramm = 15;
				int n = 64;
				int b1 = 1;


				double s1 = -(b1 * (1 - Math.Pow(2.0, n)));
				Console.WriteLine($"task 16: {s1 / gramm}");

			}
			#endregion
			#region lvl1_task18
			Console.WriteLine("task 18:");
			int cnt = 10;
			for (int i = 0; i < 24; i += 3)
			{
				cnt *= 2;
				
				Console.WriteLine(cnt);
			}
			#endregion
			#region lvl2_task2
			Console.WriteLine("(level 2)");
			int p = 1;
			int o = 1;

			while (p < 30000)
			{
				o += 3;
				p *= o;
			}

			Console.WriteLine($"task 2: {o - 3}");
			#endregion
			#region lvl2_task4
			double aс = 1;
            double E = 0.0001;
            double xс = double.Parse(Console.ReadLine());
            double sс = 0;
            while (Math.Abs(aс) >= E)
            {
                sс += a;
                aс *= xс * xс;
            }
            Console.WriteLine(s);
			#endregion
			#region lvl2_task7-8
			double start = 10;
			double summ = 10;
			for (int i = 0; i < 6; ++i)
			{
				start *= 1.1;
				summ += start;
			}
			Console.WriteLine(summ);
			double days = 1;
			start = 10;
			summ = 10;
			while (summ < 100)
			{
				start *= 1.1;
				summ += start;
				days = days + 1;
			}
			Console.WriteLine(days);
			start = 10;
			days = 1;
			while (start < 20)
			{
				start *= 1.1;
				days = days + 1;
			}
			Console.WriteLine(days);
			#endregion
			#region lvl3_task1

            Console.WriteLine("НОМЕР 3.1:");

            double sq = 1.0;
            for (double xq = 0.1; xq <= 1; xq += 0.1)
            {
                xq = Math.Round(xq, 1);
                int iq = 0;
                double qweq;
                double znam = 1.0;
                do
                {
                    qweq = Math.Pow(-1, iq) * Math.Pow(xq, 2 * iq) / znam;
                    iq++;
                    sq += qweq;
                    znam *= (2 * iq) * (2 * iq - 1);
                }

                while (qweq >= 0.0001);

                double yq = Math.Cos(xq);

                Console.WriteLine($"x = {xq:f1};\ts = {sq:f5};\ty = {yq:f5}");
            }

            #endregion
			#region lvl3_task1
			Console.WriteLine("\nНОМЕР 3.6:");

            double sh = 1.0;

            for (double xh = 0.1; xh <= 1; xh += 0.1)
            {
                int ih = 1;
                double qweh;

                do
                {
                    qweh = Math.Pow(-1, ih + 1) * (Math.Pow(x, 2 * ih + 1) / (4 * Math.Pow(ih, 2) - 1));
                    sh += qweh;
                    ih++;
                }

                while (qweh >= 0.0001);

                double yh = (((1 + Math.Pow(xh, 2)) * Math.Atan(xh)) / 2) - (xh / 2);

                Console.WriteLine($"x = {xh:f1};\ts = {sh:f5};\ty = {yh:f5}");

            }

            #endregion
			

            
            

			
				
			
			

			
			

			Console.ReadLine();

		   




		}
	}
}