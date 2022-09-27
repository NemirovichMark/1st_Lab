using System;


class Program
{

	static void Main(string[] args)
	{


		// level 1
		#region Task 4
		Console.WriteLine(" Level 1 task 4: \n\n");
		double x_4;
		Console.Write($"Enter x for task 4: ");
		double.TryParse(Console.ReadLine(), out x_4);
		double s_4 = 0;
		if (x_4 != 0)
		{
			for (int i = 1; i <= 9; i = i + 1)
			{
				s_4 += Math.Cos(i * x_4) / (Math.Pow(x_4, i - 1));
			}
			Console.WriteLine($"Task 4: S = {s_4}\n");
		}
		#endregion


		// level 1
		#region Task 9
		double s_9 = 0;
		for (int i = 1; i <= 6; i = i + 1)
		{
			double fact = 0;
			for (; fact < i; fact++)
			{
				fact *= i;
			}
			s_9 += (Math.Pow(-1, i) * Math.Pow(5, i)) / fact;
		}
		Console.WriteLine($"Task 9: S = {s_9}\n");
		#endregion


		// level 1
		#region Task 15
		int n15, i15 = 3;
		double chisltek = 2, chislprosh = 1, znamtek = 1, znamprosh = 1, buff = 0;
		Console.Write($"What is the term of the sequence to find: ");
		Int32.TryParse(Console.ReadLine(), out n15);
		if (n15 >= 3)
		{
			Console.WriteLine($"Task 15:");
			for (double s15 = 0; i15 <= n15; i15 += 1)
			{
				buff = chisltek + chislprosh;

				chislprosh = chisltek;
				chisltek = buff;
				buff = znamtek + znamprosh;
				znamprosh = znamtek;
				znamtek = buff;
				s15 = chisltek / znamtek;
				Console.WriteLine($"{i15} member of the sequence is {s15}\n");
			}
		}
		#endregion


		// level 1
		#region Task 16
		double a_16;
		double s_16 = 0;
		for (int i = 0; i <= 64; i = i + 1)
		{
			a_16 = Math.Pow(2, i);
			s_16 = s_16 + a_16;
		}
		double count16 = s_16 / 15;
		Console.WriteLine($"Task 16: Will be {count16} grams\n");
		#endregion


		// level 1
		#region Task 18
		int count_18 = 10;
		int a_18;
		Console.WriteLine($"Task 18:");
		for (int i = 3; i <= 24; i = i + 3)
		{
			a_18 = count_18 * 2;
			count_18 = a_18;

			Console.WriteLine($"In {i} hours will be {a_18} cells\n\n");
		}
		#endregion


		//level 2
		#region Task 2
		Console.WriteLine("Level 2 task 2\n");
		int p2 = 1;
		int n2 = 1;
		while (p2 < 30000)
		{
			n2 = n2 + 3;
			p2 = p2 * n2;
		}
		n2 = n2 - 3;
		Console.WriteLine($"Task 2: answer is {n2}\n");
		#endregion


		//level 2
		#region Task 4 
		double x_2_4;
		Console.Write($"Enter x for task 4: ");
		double.TryParse(Console.ReadLine(), out x_2_4);
		double s_2_4 = 1;
		if ((x_2_4 < 1) && (x_2_4 > -1) && (x_2_4 != 0))
		{
			double powx4 = x_2_4 * x_2_4;
			x_2_4 = powx4;

			while (x_2_4 >= 0.0001)
			{
				s_2_4 += x_2_4;
				x_2_4 *= powx4;
			}
			Console.WriteLine($"Task 4: answer is {s_2_4}\n");
		}
		#endregion


		//level 2
		#region Task 7, 8
		double day1distanced = 10;
		double s_2_7;
		double distancefor7days = 0;
		int nday = 1;
		for (; nday <= 6; nday += 1)
		{
			s_2_7 = day1distanced + (day1distanced * 0.1);
			day1distanced = s_2_7;
			distancefor7days += s_2_7;
		}
		distancefor7days = distancefor7days + 10;
		Console.WriteLine($"Tasks 7,8: а) {distancefor7days}");
		if (distancefor7days < 100)
		{
			nday = nday + 1;
			Console.WriteLine($"Tasks 7,8: б) {nday}");
		}
		day1distanced = 10;
		nday = 1;
		while (day1distanced < 20)
		{
			day1distanced += day1distanced * 0.1;
			nday = nday + 1;
		}
		Console.WriteLine($"Tasks 7,8: в) {nday}\n\n");
		#endregion


		//level 3
		#region Task 1
		Console.WriteLine("Level 3 task 1\n");
		double s_3_1, a_3_1, x_3_1, y_3_1;
		double symbol;
		Console.WriteLine($"Task 1 (lvl_3):");
		for (x_3_1 = 0.1; x_3_1 <= 1; x_3_1 += 0.1)
		{
			s_3_1 = 1;
			a_3_1 = 1;
			symbol = -1;
			for (int i = 1; Math.Abs(a_3_1) > 0.0001; i++)
			{
				symbol = -symbol;
				double fact = 0;
				for (; fact < i; fact++)
				{
					fact *= i;
				}
				a_3_1 = symbol * Math.Pow(x_3_1, 2 * i) / fact;
				s_3_1 = s_3_1 + a_3_1;
			}
			y_3_1 = Math.Cos(x_3_1);
			Console.WriteLine($"x={x_3_1} \t y={Math.Round(y_3_1, 3)} \t s={Math.Round(s_3_1, 3)}\n");
		}
		#endregion


		//level 3
		#region Task 8
		double x_3_8, s_3_8, a_3_8, y_3_8;
		Console.WriteLine("Task 8 (lvl_3):");
		for (x_3_8 = 0.1; x_3_8 <= 1; x_3_8 += 0.1)
		{
			s_3_8 = 1;
			a_3_8 = 1;
			for (int i = 1; Math.Abs(a_3_8) > 0.0001; i += 1)
			{
				double fact = 0;
				for (; fact < i; fact++)
				{
					fact *= i;
				}
				a_3_8 = Math.Pow(2 * x_3_8, i) / fact;
				s_3_8 += a_3_8;
			}
			y_3_8 = Math.Pow(Math.E, 2 * x_3_8);
			Console.WriteLine($"x={x_3_8} \t y={Math.Round(y_3_8, 3)} \t s={Math.Round(s_3_8, 3)}\n");
		}
		#endregion
	}

}