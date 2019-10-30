using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rectangle
{
    class Rectangle
    {
        private float length;
        private float width;

        public Rectangle()
        {
            length = 1.0f;
            width = 1.0f;
        }
        public Rectangle(float l , float w)
        {
            length = l;
            width = w;
        }
        public float getLength()
        {
            return length;
        }
        public void setLength(float newL)
        {
            length = newL;
        }
        public float getWidth()
        {
            return width;
        }
        public void setWidth(float newW)
        {
            length = newW;
        }
        public double getArea()
        {
            return length * width;
        }
        public double getPerimeter()
        {
            return (length + width) * 2;
        }
        public override string ToString()
        {
            return String.Format("Rectangle[length{0} , width{1}]", length, width);
            //return base.ToString();
        }
    }
}
