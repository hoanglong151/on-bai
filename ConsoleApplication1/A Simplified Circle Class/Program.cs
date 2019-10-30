using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_Simplified_Circle_Class
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle c1 = new Circle();
            Console.WriteLine("the circle has radius of " + c1.getRadius() + " and area of " + c1.getArea());
            Circle c2 = new Circle(2.0);
            Console.WriteLine("the circle has radius of " + c2.getRadius() + " and area of " + c2.getCircumference());
            
        }
    }
}
