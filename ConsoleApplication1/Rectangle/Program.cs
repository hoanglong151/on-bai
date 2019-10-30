using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rectangle
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle r1 = new Rectangle();
            Console.WriteLine("The Rectangle has Length of " + r1.getLength() + " Width of " + r1.getWidth() + " and Perimeter of " + r1.getPerimeter() + " and Area of " + r1.getArea());
            Rectangle r2 = new Rectangle(2,1);
            Console.WriteLine("The Rectangle has Length of " + r2.getLength() + " Width of " + r2.getWidth() + " and Perimeter of " + r2.getPerimeter() + " and Area of " + r2.getArea());
        }
    }
}
