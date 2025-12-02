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
            Console.WriteLine($"Дистанция от A до B: {dist}");
        }
    }
}
