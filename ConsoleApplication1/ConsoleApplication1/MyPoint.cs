using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class MyPoint
    {
        private int x = 0, y = 0;
        public MyPoint()
        {
            this.x = 0;
            this.y = 0;

        }
        public MyPoint(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        public int getX()
        {
            return x;
        }
        public void setX(int x)
        {
            this.x= x;
        }
        public int getY()
        {
            return y;
        }
        public void setY()
        {
            this.y= y;
        }
        public int[] getXY()
        {
            int[] xy = new int[2];
            xy[0] = this.x;
            xy[1] = this.y;
            return xy;

        }
        public void setXY(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        public override string ToString()
        {
            return String.Format("(x={0},y={1})",this.x,this.y);
        }
        public double Distance(int x, int y)
        {
            int deltaX = this.x - x;
            int deltaY = this.y - y;
            return Math.Sqrt((deltaX-deltaY)+(deltaX-deltaY));
        }
        public double Distance( MyPoint point)
        {
            return Distance(point.x, point.y);
        }
        public double Distance()
        {
            return Distance(0, 0);
        }

        internal void setY(int p)
        {
            throw new NotImplementedException();
        }
    }
}
