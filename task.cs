using System;

namespace _123488
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Lvl1
            Console.WriteLine("1st lvl:\n\n");

            #region 4
            Console.WriteLine("№4:\n");
            try
            {
                double ss1 = 0;
            Console.WriteLine("Enter the X:");
                double xx1 = double.Parse(Console.ReadLine());
                if (xx1 == 0)
                {
                    Console.WriteLine("Error: wrong input");
                }
                else
                {
                    for (int i = 1; i < 10; i++)
                    {
                        ss1 += Math.Cos(xx1 * i) / Math.Pow(xx1, i - 1);
                    }
                    Console.WriteLine($"S = {ss1}");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error: Wrong input \n {e}");
            }
            #endregion

            #region 9
            Console.WriteLine("\n\n№9:\n");
            try
            {
                double ss2 = 0;
                double nn2 = 1;
                for (int i = 1; i < 7; i++)
                {
                    nn2 *= i;
                    ss2 += Math.Pow(-1, i) * Math.Pow(5, i) / nn2;
                }
                Console.WriteLine($"S = {ss2}");
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error \n {e}");
            }
            #endregion

            #region 15
            Console.WriteLine("\n\n№15:\n");
            try
            {
                double nn3 = 1;
                double mm3 = 1;
                double aa3 = 2;
                double bb3 = 1;
                double ss31 = 0;
                double ss32 = 0;
                for (int i = 1; i < 4; i++)
                {
                    ss32 = nn3 + mm3;
                    mm3 = nn3;
                    nn3 = ss32;
                    ss31 = aa3 + bb3;
                    bb3 = aa3;
                    aa3 = ss31;
                }
                Console.WriteLine($"S = {ss31/ss32} ");
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error \n {e}");
            }
            #endregion

            #region 16
            Console.WriteLine("\n\n№16:\n");
            try
            {
                double ss4 = 0;
                for (int i = 0; i < 64; i++)
                {
                    ss4 += Math.Pow(2, i);
                }
                Console.WriteLine($"S = {(ss4 / 15) / 1000}  kg ");
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error \n {e}");
            }
            #endregion

            #region 18
            Console.WriteLine("\n\n№18:\n");
            try
            {
                double ss5 = 10;
                for (int i = 3; i < 25; i += 3)
                {
                    ss5 *= 2;
                    Console.WriteLine($"After {i} hours there would be {ss5} Amoeba cells");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error \n {e}");
            }
            #endregion
            #endregion

            #region  Lvl2
            Console.WriteLine("\n\n\n2nd lvl:");

            #region 2
            Console.WriteLine("\n\n№2:\n");
            try
            {
                double ss6 = 1;
                double pp6 = 1;
                while (ss6 < 30000)
                {
                    pp6 += 3;
                    ss6 *= pp6;
                }
                Console.WriteLine($"The last numb is {pp6 - 3}");
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error \n {e}");
            }
            #endregion

            #region 4
            Console.WriteLine("\n\n№4:\n");
            try
            {
                double ss7 = 1;
                double ee7 = 0;
                double xx7 = double.Parse(Console.ReadLine());
                if (xx7 <= -1 || xx7 >= 1)
                {
                    Console.WriteLine("Error: wrong input");
                }
                else
                {
                    while (Math.Pow(xx7, ee7) >= 0.0001)
                    {
                        ee7 += 2;
                        ss7 += Math.Pow(xx7, ee7);
                    }
                    Console.WriteLine($"S = {ss7}");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error \n {e}");
            }
            #endregion

            #region 7,8
            Console.WriteLine("\n\n№7,8:\n");
            try
            {
                double dd8 = 10;
                double day8 = 1;
                double kk8 = 0;
                double ss8 = 10;
                while (dd8 <= 20)
                {
                    day8 += 1;
                    dd8 *= 1.10;
                    ss8 += dd8;
                    if (day8 == 7)
                    {
                        Console.WriteLine($"а) S = {ss8} ");
                    }
                    if (ss8 >= 100 && kk8 == 0)
                    {
                        Console.WriteLine($"б) At the {day8} day");
                        kk8 = 1;
                    }
                }
                Console.WriteLine($"в) At the {day8 } day");
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error \n {e}");
            }
            #endregion
            #endregion

            #region Lvl3
            Console.WriteLine("\n\n\n3rd lvl:");
            #region 1

            Console.WriteLine("\n\n№1:\n");
            try
            {
                double yy9;
                for (int i = 1; i <= 10; i += 1)
                {
                    double ff9 = 2;
                    double ee9 = 1;
                    double ss9 = 1;
                    double xx9 = Convert.ToDouble(i) / 10;
                    while (Math.Abs(Math.Pow(-1, ee9) * Math.Pow(xx9, 2 * ee9) / ff9) >= 0.0001)
                    {
                        ss9 += Math.Pow(-1, ee9) * Math.Pow(xx9, 2 * ee9) / ff9;
                        ee9 += 1;
                        ff9 *= 2 * ee9 * (2 * ee9 - 1);
                    }
                    Console.WriteLine($"S {i} = {ss9}");
                    yy9 = Math.Cos(xx9);
                    Console.WriteLine($"y = {yy9}\n");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error \n {e}");
            }
            #endregion

            #region 5
            Console.WriteLine("\n\n№5:\n");
            try
            {
                double jj10;
                double aa10 = 0;
                for (jj10 = Math.PI / 5; jj10 <= Math.PI; jj10 += Math.PI / 25)
                {
                    double ee10 = 1;
                    double ss10 = 0;
                    double xx10 = jj10;
                    while (Math.Abs(Math.Pow(-1, ee10) * Math.Cos(ee10 * xx10) / Math.Pow(ee10, 2)) >= 0.0001)
                    {
                        ss10 += Math.Pow(-1, ee10) * Math.Cos(ee10 * xx10) / Math.Pow(ee10, 2);
                        ee10 += 1;
                    }
                    aa10 += 1;
                    Console.WriteLine($"S {aa10} = {ss10}");
                    double yy10 = (Math.Pow(xx10, 2) - (Math.Pow(Math.PI, 2) / 3)) / 4;
                    Console.WriteLine($"y = {yy10}\n");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error \n {e}");
            }
            #endregion

            #endregion
        }
    }
}
