using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_CS
{
    internal class Point
    {
        double x;
        double y;
        public double GetX()
        {
            return x;
        }
        public double GetY()
        {
            return y;
        }
        public void SetX(double x)
        {
            this.x = x;
        }
        public void SetY(double y)
        {
            this.y = y;
        }
        public double X
        {
            get { return x; }
            set { x = value; }
        }
        public double Y
        {
            get { return y; }
            set { y = value; }
        }

        //constructors:
        public Point()
        {
            Console.WriteLine($"DefuaultConstructor:\t{this.GetHashCode()}");

        }
        public Point(double x=0, double y=0)
        {
            this.X = x;
            this.Y = y;
            Console.WriteLine($"Constructor:\t\t{this.GetHashCode()}");
        }

        public Point(Point other)
        {
            this.X = other.X;
            this.Y = other.Y;
            Console.WriteLine($"CopyConstructor:{this.GetHashCode()}");
        }

        ~Point()
        {
            Console.WriteLine($"Destructor:\t\t{this.GetHashCode()}");
        }
        //              operator :

        public static Point operator+(Point left,Point right)
        {
            //Point result = new Point(
            //    left.X + right.X,
            //    left.Y + right.Y
            //    );
            return new Point (left.X+right.X, left.Y+right.Y);
        }

        public static Point operator++(Point obj)
        {
            obj.X++;   
            obj.Y++;
            return new Point(obj);
        }

        public static bool operator==(Point left,Point right)
        {
            return left.X == right.X && left.y == right.y;
        }
        public static bool operator !=(Point left, Point right)
        {
            return left.X != right.X || left.y != right.y;
        }

        public static bool operator <(Point left, Point right)
        {
            return left.X + left.y < right.x + right.y;
        }
        public static bool operator >(Point left, Point right)
        {
            return left.X + left.y > right.x + right.y;
        }

        //              metods:
        public void Print()
        {
            Console.WriteLine($"x = {x} , y = {y}");
        }
        public double Distance(Point other)
        {
            double dx = other.X - this.X;
            double dy = other.Y - this.Y;
            return Math.Sqrt(dx * dx + dy * dy);
        }
    }
}
