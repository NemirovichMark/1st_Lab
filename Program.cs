using System;
using System.Diagnostics.CodeAnalysis;
using System.Threading.Tasks;
using Utility;

namespace _1st_Lab
{
    class Program
    {
        static string format = "Sum = {0}";
        static void Main(string[] args)
        {
            //Task1(30);
            //Task2();
            //Task3();
            //Task4();
            //Task5();
            //Task6();
            //Task7();
            //Task8();
            //Task9();
            Task10();
        }
        #region Task1
        public static void Task1()
        {
            double.TryParse(Console.ReadLine(), out double x);
            double element;
            double sum = 0;
            if (x != 0)
            {
                for (int i = 1; i < 10; i++)
                {
                    element = Math.Cos(i * x / 180 * Math.PI) / Math.Pow(x, i - 1);
                    sum += element;
                }
                Console.WriteLine($"Sum = {sum}");
            }
            else
            {
                Console.WriteLine("Wrong input, try again");
            }
        }
        #endregion
        #region Task2
        public static void Task2()
        {
            const int param = 5;
            double element;
            double sum = 0;

            for(int i = 1; i <= 6; i++)
            {
                element = Math.Pow(-1, i) * Math.Pow(param, i) / HelperFunctions.Factorial(i);
                sum += element;
            }
            Console.WriteLine(format, sum);
        }
        #endregion
        #region Task3
        public static void Task3()
        {
            Fraction previousElement = new Fraction(1, 1);
            Fraction currentElement = new Fraction(2, 1);
            Fraction nextElement = new Fraction(1, 0);

            Console.Write("Input: ");
            int nIndex;
            while(!int.TryParse(Console.ReadLine(), out nIndex))
            {

            }

            for(int i = 3; i <= nIndex; i++)
            {
                nextElement = Fraction.CustomAdd(previousElement, currentElement);
                previousElement = currentElement;
                currentElement = nextElement;
            }

            Console.WriteLine($"fraction[{nIndex}] = {nextElement}");
        }
        #endregion
        #region Task4
        public static void Task4()
        {
            UInt64 numberGrains = UInt64.MaxValue;
            UInt64 gramGrains = numberGrains / (UInt64)15;
            Console.WriteLine($"grains = {gramGrains} grams, error rate {numberGrains / 15.0 - gramGrains}");
        }
        #endregion
        #region Task5
        public static void Task5()
        {
            uint cells = 10;
            Console.WriteLine($"cells in a closed volume {cells}");

            Console.Write("how many hours have passed: ");
            uint hours;
            while (!uint.TryParse(Console.ReadLine(), out hours)) ;

            cells = cells * (uint)Math.Pow(2, hours / 3);
            Console.WriteLine($"after {hours} hours cells in a closed volume {cells}");
        }
        #endregion
        #region Task6
        public static void Task6()
        {
            int firstElement = 1;
            int difference = 3;
            int currentElement = 1;
            int product = 1;

            for (int i = 2; ; i++)
            {
                currentElement = firstElement + difference * (i - 1);
                product *= currentElement;
                if(product >= 30_000)
                {
                    currentElement = firstElement + difference * (i - 2);
                    break;
                }
            }
            Console.WriteLine($"CurrentElement = {currentElement}");
        }
        #endregion
        #region Task7
        public static void Task7()
        {
            double epsilon = 0.00001;
            double sum = 0;
            int lowerBound = -1;
            int upperBound = 1;
            Console.Write("Input argument x (-1; 1) = ");
            double.TryParse(Console.ReadLine(), out double x);
            if (HelperFunctions.CheckInput(ref x, lowerBound, upperBound, "Wrong input"))
            {
                double currentElement = Math.Pow(x, 0);
                for (int i = 0; currentElement > epsilon; i++)
                {
                    currentElement = Math.Pow(x, i);
                    sum += currentElement;
                }
                Console.WriteLine($"Sum = {sum}");
            }
        }
        #endregion
        #region Task8
        public static void Task8()
        {
            double initialDistance = 10;
            double difference = 1.1;
            double previousDay = initialDistance;
            double currentDay;
            double finalDisntance = initialDistance;
            for(int i = 2; i <= 7; i++)
            {
                currentDay = previousDay * difference;
                finalDisntance += currentDay;
                previousDay = currentDay;
            }
            Console.WriteLine($"After 7 days the final distance = {Math.Round(finalDisntance, 4)}km");

            finalDisntance = 100;
            previousDay = initialDistance;
            int days = 2;
            double currentDistance = initialDistance;

            for(; currentDistance <= finalDisntance; days++)
            {
                currentDay = previousDay * difference;
                currentDistance += currentDay;
                previousDay = currentDay;
            }
            Console.WriteLine($"after {days} days distance = {Math.Round(currentDistance, 4)}km");

            previousDay = initialDistance;
            currentDay = 0;
            days = 2;
            for( ; currentDay <= 20; days++)
            {
                currentDay = previousDay * difference;
                previousDay = currentDay;
            }
            Console.WriteLine($"After {days} days the athlete ran {Math.Round(currentDay, 4)}km");
        }
        #endregion
        #region Task9
        public static void Task9()
        {
            Row row = new Row();

            Console.Write("set the lower bound = ");
            double.TryParse(Console.ReadLine(), out double lowBound);
            Console.Write("set the upper bound = ");
            double.TryParse(Console.ReadLine(), out double upBound);
            Console.Write("set the step = ");
            double.TryParse(Console.ReadLine(), out double step);

            bool checkData = (lowBound <= upBound)
                && (step - 0.0 >= 0.0000001);
            if (checkData)
            {
                for (double x = lowBound; x <= upBound; x += step)
                {
                    Console.WriteLine($"at the point x = {Math.Round(x, 2)} Math.Cos - row.GetCos = " +
                        $"{Math.Round(Math.Round(Math.Cos(x) - row.GetCos(x), 4), 4)}");
                }
            }
            else
            {
                Console.WriteLine("one or more variables have been assigned an incorrect value, try again");
            }
        }
        #endregion
        #region Task10
        public static void Task10()
        {
            Row row = new Row();

            Console.Write("set the lower bound = ");
            double.TryParse(Console.ReadLine(), out double lowBound);
            Console.Write("set the upper bound = ");
            double.TryParse(Console.ReadLine(), out double upBound);
            Console.Write("set the step = ");
            double.TryParse(Console.ReadLine(), out double step);

            bool checkData = (lowBound <= upBound)
                && (step - 0.0 >= 0.0000001);

            if (checkData)
            {
                for (double x = lowBound; x <= upBound; x += step)
                {
                    Console.WriteLine($"at the point x = {Math.Round(x, 2)} Math.Atan - row.GetAtan = " +
                        $"{Math.Atan(x) - row.GetAtan(x)}");
                }
            }
            else
            {
                Console.WriteLine("one or more variables have been assigned an incorrect value, try again");
            }
        }
        #endregion
    }
}
