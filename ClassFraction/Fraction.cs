using System;

namespace ClassFraction
{
    class Fraction
    {
        public int Integer { get; set; }    // Целая часть
        public int Numerator { get; set; }  // Числитель
        private int denominator;    // Знаменатель
        public int Denominator
        {
            get => denominator;
            set
            {
                if (value == 0) value = 1;
                denominator = value;
            }
        }

        public void ToProper()
        {
            Integer += Numerator / Denominator;
            Numerator %= Denominator;
        }

        public void ToImproper()
        {
            Numerator += Integer * Denominator;
            Integer = 0;
        }

        // Конструкторы
        public Fraction()
        {
            Integer = 0;
            Numerator = 0;
            Denominator = 1;
            Console.WriteLine($"Constructor:\t{GetHashCode()}");
        }

        public Fraction(int integer = 0, int numerator = 0, int denominator = 1)
        {
            Integer = integer;
            Numerator = numerator;
            Denominator = denominator;
            Console.WriteLine($"Constructor:\t{GetHashCode()}");
        }

        public Fraction(int ineger)
        {
            Integer = ineger;
            Numerator = 0;
            Denominator = 1;
            Console.WriteLine($"Constructor:\t{GetHashCode()}");
        }

        public Fraction(int numerator, int denominator)
        {
            Integer = 0;
            Numerator = numerator;
            Denominator = denominator;
            Console.WriteLine($"Constructor:\t{GetHashCode()}");
        }

        public Fraction(Fraction other)
        {
            this.Integer = other.Integer;
            this.Numerator = other.Numerator;
            this.Denominator = other.Denominator;
            Console.WriteLine($"CopyConstructor:\t{GetHashCode()}");
        }

        ~Fraction()
        {
            Console.WriteLine($"Deconstructor:\t{GetHashCode()}");
        }

        // Перегрузка операторов ++ и --
        public static Fraction operator ++(Fraction frac)
        {
            // Увеличиваем целую часть на 1
            frac.Integer++;
            return frac;
        }

        public static Fraction operator --(Fraction frac)
        {
            // Уменьшаем целую часть на 1
            frac.Integer--;
            return frac;
        }

        // Перегрузка операторов сравнения
        public static bool operator ==(Fraction left, Fraction right)
        {
            return left.ToDouble() == right.ToDouble();
        }

        public static bool operator !=(Fraction left, Fraction right)
        {
            return !(left == right);
        }

        public static bool operator >(Fraction left, Fraction right)
        {
            return left.ToDouble() > right.ToDouble();
        }

        public static bool operator <(Fraction left, Fraction right)
        {
            return left.ToDouble() < right.ToDouble();
        }

        public static bool operator >=(Fraction left, Fraction right)
        {
            return left.ToDouble() >= right.ToDouble();
        }

        public static bool operator <=(Fraction left, Fraction right)
        {
            return left.ToDouble() <= right.ToDouble();
        }

        // Вспомогательный метод для преобразования в double для сравнения
        public double ToDouble()
        {
            return Integer + (double)Numerator / Denominator;
        }

        // Перегрузка оператора умножения
        public static Fraction operator *(Fraction left, Fraction right)
        {
            Fraction leftCopy = new Fraction(left);
            Fraction rightCopy = new Fraction(right);
            leftCopy.ToImproper();
            rightCopy.ToImproper();
            int resultNumerator = leftCopy.Numerator * rightCopy.Numerator;
            int resultDenominator = leftCopy.Denominator * rightCopy.Denominator;
            return new Fraction(0, resultNumerator, resultDenominator);
        }

        public void Print()
        {
            if (Integer != 0)
            {
                Console.Write($"{Integer}");
                if (Numerator != 0)
                {
                    Console.Write($"({Numerator}/{Denominator})");
                }
                Console.WriteLine();
            }
            else if (Numerator != 0)
            {
                if (Integer != 0) Console.Write("(");
                Console.WriteLine($"{Numerator}/{Denominator}");
                if (Integer != 0) Console.Write(")");
            }
            else
            {
                Console.WriteLine(0);
            }
        }
    }
}