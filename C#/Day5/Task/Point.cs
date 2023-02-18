using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D5SD43_Task
{
    internal class Point
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Point(int _x, int _y)
        {
            this.X = _x;
            this.Y = _y;
        }

        public override bool Equals(object? obj)
        {
            if (obj == null) return false;
            Point p = (Point)obj;
            if (this.X == p.X && this.Y == p.Y) return true;
            else return false;
        }




        public override string ToString()
        {
            return $"({X},{Y})";
        }
    }
}
