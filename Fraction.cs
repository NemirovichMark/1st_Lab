using System;
using System.Collections.Generic;
using System.Text;

namespace Utility
{
    class Fraction
    {
        int numerator;
        public int Numerator
        {
            get { return numerator; }
            set { numerator = value; }
        }
        int denominator;
        public int Denominator
        {
            get { return denominator; }
            set
            {
                try
                {
                    denominator = value != 0 ? value : throw new Exception();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.StackTrace);
                    Console.WriteLine("The default value will be set to 1. Do you want to change it? (y/n)");
                    string answer = Console.ReadLine().ToLower();

                    if (HelperFunctions.CheckInput(answer, "y", "n", "Wrong Input"))
                    {
                        if (answer.Equals("y"))
                        {
                            Console.Write("denomintor = ");
                            int.TryParse(Console.ReadLine(), out int newDenominator);
                            denominator = new Fraction(this.numerator, newDenominator).Denominator;
                        }
                        else
                        {
                            denominator = 1;
                        }
                    }
                }
            }
        }

        public Fraction(int numerator, int denominator)
        {
            this.Numerator = numerator;
            this.Denominator = denominator;
        }

        public static Fraction CustomAdd(Fraction a, Fraction b)
        {
            return new Fraction(a.Numerator + b.Numerator, a.Denominator + b.Denominator);
        }

        public static Fraction operator +(Fraction a)
            => a;
        public static Fraction operator -(Fraction a)
            => new Fraction(-a.Numerator, a.Denominator);
        public static Fraction operator +(Fraction a, Fraction b)
            => new Fraction(a.Numerator * b.Denominator, b.Numerator * a.Denominator);
        public static Fraction operator -(Fraction a, Fraction b)
            => a + (-b);
        public static Fraction operator *(Fraction a, Fraction b)
            => new Fraction(a.Numerator * b.Numerator, a.Denominator * b.Denominator);
        public static Fraction operator /(Fraction a, Fraction b)
        {
            if (b.Numerator == 0)
            {
                throw new DivideByZeroException();
            }
            return new Fraction(a.Numerator * b.Denominator, a.Denominator * b.Numerator);
        }

        public override string ToString()
        {
            return $"{this.Numerator} / {this.Denominator}";
        }
    }
}
