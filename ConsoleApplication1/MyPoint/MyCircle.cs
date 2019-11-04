using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPoint
{
    class MyCircle
    {
        private MyPoint center;
        private int radius;

        public MyCircle()
        {
            center.GetX();
            center.GetY();
            radius = 1;
        }
        public MyCircle(int x , int y , int radius)
        {
            this.radius = radius;
            center = new MyPoint(x, y);
        }
        public MyCircle(MyPoint center , int radius)
        {
            this.center = center;
            this.radius = radius;
        }
        public int getRadius()
        {
            return radius;
        }
        public void setRadius(int radius)
        {
            this.radius = radius;
        }
        public MyPoint getCenter()
        {
            return center;
        }
        public void setCenter(MyPoint center)
        {
            this.center = center;
        }
        public int getCenterX()
        {
            return center.GetX();
        }
        public void setCenterX(int x)
        {
            
        }
    }
}
