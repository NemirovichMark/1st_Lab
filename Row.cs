using System;
using System.Collections.Generic;
using System.Text;

namespace Utility
{
    internal class Row
    {
        static double epsilon = 0.0001;
        public static double Epsilon
        {
            get
            {
                return epsilon;
            }

            set
            {
                epsilon = Math.Abs(value);
            }
        }

        public Row()
        {

        }

        private double GetSumTermCos(int index, double argument)
        {
            return Math.Pow(-1, index) * Math.Pow(argument, 2 * index) / HelperFunctions.Factorial(2 * index);
        }

        public double GetCos(double argument)
        {
            double result = 0;
            double sumMember = GetSumTermCos(0, argument);
            for(int index = 1; Math.Abs(sumMember) > 0.0001; index++)
            {
                result += sumMember;
                sumMember = GetSumTermCos(index, argument);
            }
            return result;
        }

        private double GetSumTermAtan(int index, double argument)
        {
            return Math.Pow(-1, index) * (Math.Pow(argument, 2 * index + 1) / (2 * index + 1));
        }

        public double GetAtan(double argument)
        {
            double result = 0;
            double sumMember = GetSumTermAtan(0, argument);
            for (int index = 1; Math.Abs(sumMember) > 0.0001; index++)
            {
                result += sumMember;
                sumMember = GetSumTermAtan(index, argument);
            }
            return result;
        }
    }
}
