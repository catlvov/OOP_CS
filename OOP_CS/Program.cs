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
            A.X = 212.125; //свойства позволяют использовать инкопсуляцию как обычные переменые в классе
            A.Y = 321.11;
            A.Print();

            Point B = new Point();
            B.X = 100;
            B.Y = 200;
            B.Print();

            double dist = A.Distance(B);
            Console.WriteLine($"Дистанция от A до B: {dist}");
        }
    }
}
