using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle c1 = new Circle();
            Console.WriteLine("the circle has radius of " + c1.getradius() + " and area of " + c1.getArea());
            Circle c2 = new Circle(2.0);
            Console.WriteLine("the circle has radius of " + c2.getradius() + " and area of " + c2.getArea());
            Circle c3 = new Circle(3.0, "Orange");
            Console.WriteLine("the circle has radius of {0} and color {1}", c3.getradius(), c3.getcolor());
            Circle c4 = new Circle();
            c4.setradius(5.0);
            Console.WriteLine("radius is: " + c4.getradius());
            c4.setcolor("Orange");
            Console.WriteLine("color is: " + c4.getcolor());
        }
    }
}