using System;
using System.Collections.Generic;
using System.Text;

namespace _15
{
    class Point
    {
        public double x { get; set; }
        public double y { get; set; }
        public double z { get; set; }

        public Point(double x, double y, double z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public double DistanceTo(Point p)
        {
            double x = 0;
            double y = 0;
            double z = 0;
            x = Math.Pow(this.x - p.x, 2);
            y = Math.Pow(this.y - p.y, 2);
            z = Math.Pow(this.z - p.z, 2);
            return Math.Pow(x + y + z, 0.5);
        }
    }
}
