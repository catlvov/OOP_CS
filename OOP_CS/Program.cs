//#define PROPERTIES
//#define CONSTRUCTOR
//#define INCRIMENT
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_CS
{
    internal class Program
    {
        static void Main(string[] args)
        {
#if PROPERTIES
            Point A = new Point();
            //Console.WriteLine($"{A.GetX()} {A.GetY()}");
            //A.SetX(5);
            //A.SetY(10.3);
            A.X = 2;//свойства позволяют использовать инкопсуляцию как обычные переменые в классе
            A.Y = 3;
            A.Print();

            Point B = new Point();
            B.X = 7;
            B.Y = 8;
            B.Print();

            double dist = A.Distance(B);
#endif
#if CONSTRUCTOR
            Point A = new Point(2, 3);
            Point B = new Point(7, 8);

            Console.WriteLine($"Дистанция от A до B: {A.Distance(B)}");

            Point C = new Point(A); //CopyConstroctor
            Point D = A + B;
            D.Print();

            A += B;
            A.Print();
#endif
#if INCRIMENT
            Point i = new Point(2,3);
            Point j = null;
            for(; i.X < 10; i++)
            {
                Console.SetCursorPosition(Convert.ToInt32(i.X), Convert.ToInt32(i.Y));
                Console.Write("@");
            }
            i.Print();
#endif
            Point A = new Point(2, 3);
            Point B = new Point(7, 8);

            Console.WriteLine(A < B);
        }
    }
}
