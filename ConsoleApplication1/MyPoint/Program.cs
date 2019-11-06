using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPoint
{
    class Program
    {
        static void Main(string[] args)
        {
            //MyPoint m1 = new MyPoint(2, 4);
            //Console.WriteLine("X = " + m1.GetX() + " Y = " + m1.GetY());
            //MyPoint m2 = new MyPoint(2, 6);
            //Console.WriteLine(m2.GetXY()[0]);
            //Console.WriteLine(m2.GetXY()[1]);
            //Console.WriteLine(m2.Distance());
            //MyPoint m3 = new MyPoint();
            //Console.WriteLine(m3.Distance());
            //Console.WriteLine(m3.Distance(m1));
            //Console.WriteLine(m3.Distance(m2));

            MyCircle m4 = new MyCircle(2,5,3);
            Console.WriteLine(m4.getCenter() + " and " + m4.getRadius() + " and " + m4.getCenterX());
            MyCircle m5 = new MyCircle(2, 5, 4);
            Console.WriteLine(m5.getRadius());
        }
    }
}
