using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Circle
    {
        private double radius;
        private string color;

        public Circle()
        {
            radius = 1.0;
            color = "red";
        }
        public Circle(double r)
        {
            radius = r;
            color = "red";
        }
        public double getradius()
        {
            return radius;
        }
        public double getArea()
        {
            return radius * radius * Math.PI;
        }
        public Circle(double r, string c)
        {
            radius = r;
            color = c;
        }
        public string getcolor()
        {
            return color;
        }
        public void setradius(double newradius)
        {
            radius = newradius;
        }
        public void setcolor(string newcolor)
        {
            color = newcolor;
        }
        public override string ToString()
        {
            return String.Format("Circle[radius={0},color={1} ", radius, color);
            //return base.ToString();
        }
    }
}
