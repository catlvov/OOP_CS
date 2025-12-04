using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Fraction
{
    internal class Fraction
    {
        public int Integer { get; set; }
        public int Numerator { get; set; }
        private int denomenator;
        public int Denomenator
        {
            get => denomenator;
            set
            {
                if (value == 0)
                    value = 1;
                denomenator = value;
            }
        }

        public Fraction()
        {
            Integer = 0;
            Numerator = 0;
            Denomenator = 1;
        }

        public Fraction(int integer, int numerator, int denomenator)
        {
            Integer = integer;
            Numerator = numerator;
            Denomenator = denomenator;
            Reduce();
        }

        public Fraction(int numerator, int denomenator)
        {
            Integer = 0;
            Numerator = numerator;
            Denomenator = denomenator;
            Reduce();
        }

        public Fraction(int integer)
        {
            Integer = integer;
            Numerator = 0;
            Denomenator = 1;
        }

        private void Reduce()
        {
            int gcd = GCD(Numerator, Denomenator);
            if (gcd != 0)
            {
                Numerator /= gcd;
                Denomenator /= gcd;
            }
            if (Numerator >= Denomenator)
            {
                Integer += Numerator / Denomenator;
                Numerator = Numerator % Denomenator;
            }
        }

        private int GCD(int a, int b)
        {
            if (b == 0)
                return a;
            return GCD(b, a % b);
        }

        public double ToDouble()
        {
            return Integer + (double)Numerator / Denomenator;
        }

        public static Fraction operator +(Fraction a, Fraction b)
        {
            int numA = a.Integer * a.Denomenator + a.Numerator;
            int numB = b.Integer * b.Denomenator + b.Numerator;
            int commonDen = a.Denomenator * b.Denomenator;
            int resultNum = numA * b.Denomenator + numB * a.Denomenator;
            return new Fraction(0, resultNum, commonDen);
        }

        public static Fraction operator -(Fraction a, Fraction b)
        {
            int numA = a.Integer * a.Denomenator + a.Numerator;
            int numB = b.Integer * b.Denomenator + b.Numerator;
            int commonDen = a.Denomenator * b.Denomenator;
            int resultNum = numA * b.Denomenator - numB * a.Denomenator;
            return new Fraction(0, resultNum, commonDen);
        }

        public static Fraction operator *(Fraction a, Fraction b)
        {
            int numA = a.Integer * a.Denomenator + a.Numerator;
            int numB = b.Integer * b.Denomenator + b.Numerator;
            int resultNum = numA * numB;
            int resultDen = a.Denomenator * b.Denomenator;
            return new Fraction(0, resultNum, resultDen);
        }

        public static Fraction operator /(Fraction a, Fraction b)
        {
            int numA = a.Integer * a.Denomenator + a.Numerator;
            int numB = b.Integer * b.Denomenator + b.Numerator;
            if (numB == 0)
                throw new DivideByZeroException();
            int resultNum = numA * b.Denomenator;
            int resultDen = a.Denomenator * numB;
            return new Fraction(0, resultNum, resultDen);
        }

        public override string ToString()
        {
            if (Numerator == 0)
                return Integer.ToString();
            else if (Integer == 0)
                return $"{Numerator}/{Denomenator}";
            else
                return $"{Integer} {Numerator}/{Denomenator}";
        }
    }
}
