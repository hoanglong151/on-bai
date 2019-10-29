using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_Simplified_Circle_Class
{
    class Circle
    {
        private double radius;
        private double π = 3.14159265359;
        public Circle()
        {
            radius = 1.0;
        }
        public Circle(double r)
        {
            radius = r;
        }
        public double getRadius()
        {
            return radius;
        }
        public void setRadius(double r)
        {
            radius = r;
        }
        public double getArea()
        {
            return radius * radius * Math.PI;
        }
        public override string ToString()
        {
            return String.Format("Circle[radius={0}", radius);
            //return base.ToString();
        }
        public double getCircumference()
        {
            return radius * radius * π;
        }
    }
}
