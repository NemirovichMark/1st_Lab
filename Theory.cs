using System;
using System.Data.Common;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Security;
using System.Security.Cryptography.X509Certificates;
using System.Transactions;

namespace _1st_Lab
{
    class Program
    {

        static void Main(string[] args)
        {
            #region Level 1

            #region ex.4
            //initializing angle variable
            double angle = 0;
            //using try-catch as a foolproof for a wrong input and Parse to parse the value of a variable
            while (angle <= 0)
            {
                try
                {
                    Console.Write("Enter angle(degrees): ");
                    angle = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                }
                catch (Exception)
                {
                    Console.WriteLine("Error... Try again");
                }
            }
            //initializing sumOfCos as a variable for sum, converting degrees to radians and using for-loop to fill sumOfCos.
            double DegreeToRadConverstion = (angle * Math.PI) / 180;
            double sumOfCos = 0;
            for (int i = 1; i <= 9; i++)
            {
                sumOfCos += Math.Cos(DegreeToRadConverstion * i) / Math.Pow(DegreeToRadConverstion, i - 1);
            }
            Console.WriteLine($"Lvl1 ==> ex.4: {sumOfCos}");
            #endregion

            #region ex.9(redo)
            double sum = 0;
            int factorial = 1;
            int result = factorial;
            for (int i = 1; i <= 6; i++)
            {
                result *= i;
                sum += Math.Pow(-5, i) / result;
            }
            Console.WriteLine($"Lvl1 ==> ex.9: {sum}");
            #endregion

            #region ex.15
            int numerator = 2;
            int denominator = 1;
            int nextNumerator = 0;

            for(int i = 0; i <= 2; i++)
            {
                nextNumerator = numerator + denominator;
                denominator = numerator;
                numerator = nextNumerator;
            }
            Console.WriteLine($"Lvl1 ==> ex.15: {nextNumerator}/{denominator}");
            
            #endregion

            #region ex.16
            ulong quantityOfSeeds = 0;

            for (int i = 0; i <= 63; i++)
            {
                quantityOfSeeds += (ulong)Math.Pow(2, i);
            }
            ulong gramsOfSeeds = quantityOfSeeds / 15;
            Console.WriteLine($"Lvl1 ==> ex.16: {gramsOfSeeds} grams will cover the board");


            #endregion

            #region ex.18
            int quantityOfAmoebas = 10;

            for (int i = 3; i <= 24; i += 3)
            {
                quantityOfAmoebas *= 2;
                Console.WriteLine($"Lvl1 ==> ex.18: There will be {quantityOfAmoebas} amoebas after {i} hours!");
            }
            #endregion

            #endregion

            #region Level 2

            #region ex.20
            int firstNum = 1;
            int l = 1;
            while (l <= 30000)
            {

                firstNum += 3;
                l *= firstNum;

            }
            firstNum -= 3;
            Console.WriteLine($"Lvl2 ==> ex.2: {firstNum}");
            #endregion

            #region ex.4

            double s = 0;
            double x = 0;
            double e = 0.0001;
            Console.Write("Enter x from this interval (-1;1): ");
            if (double.TryParse(Console.ReadLine(), out x))
            {
                if ((x <= -1) || (x >= 1))
                {
                    Console.WriteLine("Error... Try again");
                }

                double currentX = Math.Pow(x, 0);
                for (int n = 0; currentX >= e; n++)
                {
                    currentX = Math.Pow(x, 2 * n);
                    s += currentX;
                }
                Console.WriteLine($"Lvl2 ==> ex.4: {s}");
            }
            else
            {
                Console.WriteLine("Wrong input... Try again");
            }



            #endregion

            #region ex.7

            double coef = 1.1;

            #region 8(a)
            double firstDayRunA = 10;
            int quantityOfDays = 7;
            double totalDistanceA = 0;

            for (int i = 0; i < quantityOfDays; i++)
            {
                totalDistanceA += firstDayRunA;
                firstDayRunA *= coef;
            }
            Console.WriteLine($"Lvl2 ==> ex.8(a): The total distance will be {Math.Round(totalDistanceA, 3)} km after 7 days of running");
            #endregion

            #region 8(b)
            double firstDayRunB = 10;
            double totalDistanceB = 0;
            int countOfDaysB = 0;
            while (totalDistanceB <= 100)
            {
                totalDistanceB += firstDayRunB;
                firstDayRunB *= coef;
                countOfDaysB += 1;
            }
            Console.WriteLine($"Lvl2 ==> ex.8(b): After {countOfDaysB} days runner's total distance will be 100 km");
            #endregion

            #region 8(c)
            double firstDayRunC = 10;
            int countOfDaysC = 1;
            while (firstDayRunC <= 20)
            {
                firstDayRunC *= coef;
                countOfDaysC += 1;
            }

            Console.WriteLine($"Lvl2 ==> ex.8(c): After {countOfDaysC} days the runner will run more than 20 km a day");
            #endregion

            #endregion

            #endregion

            #region Level 3

            #region ex.1

            double lowerBoundary = 0.1;
            double upperBoundary = 1;
            double step = 0.1;
            for (double argument = lowerBoundary; argument <= upperBoundary; argument += step)
            {
                int i = 0;
                double fact = 1;
                double elem;
                double sumOfRow = 0;
                do
                {

                    elem = Math.Pow(-1, i) * (Math.Pow(argument, 2 * i) / fact);
                    sumOfRow += elem;
                    i++;
                    fact *= 2 * i * (2 * i - 1);

                } while (Math.Abs(elem) >= 0.0001);

                Console.WriteLine($"Lvl3 ==> ex.1: x: {Math.Round(argument, 1)}  Sum of row: {Math.Round(sumOfRow, 6)} cos(x): {Math.Round(Math.Cos(argument), 5)}");
            }



#endregion

            #region ex.6
            double floor = 0.1;
            double ceiling = 1;
            double stepOfArgument = 0.1;
            for (double argument = floor; argument <= ceiling; argument += stepOfArgument)
            {
                double resultOfSum = 0;
                int i = 1;
                double elem;
                do
                {
                    elem = Math.Pow(-1, i + 1) * (Math.Pow(argument, 2 * i + 1) / (4 * (Math.Pow(i, 2)) - 1));
                    resultOfSum += elem;
                    i++;
                } while (Math.Abs(elem) >= 0.0001);
                double y = (Math.Atan(argument) * (1 + Math.Pow(argument, 2))) / 2 - argument / 2;
                Console.WriteLine($"Lvl3 ==> ex.6: x: {Math.Round(argument,1)}   Sum of row: {Math.Round(resultOfSum, 4)}   y: {Math.Round(y, 4)}");
}
            #endregion

            #endregion
        }
    }
}
