using System;

namespace Chapter_10_Exercise_12
{
    internal class Point
    {
        private int v1;
        private int v2;

        public Point(int v1, int v2)
        {
            this.v1 = v1;
            this.v2 = v2;
        }

        public static implicit operator int(Point v)
        {
            throw new NotImplementedException();
        }
    }
}