using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D5SD43_Task
{
    internal class Point3D : Point
    {
        public int Z { get; set; }
        public Point3D(int _x, int _y,int _z) : base(_x, _y)
        {
            Z = _z;
        }

        static public explicit operator string (Point3D pt) { return pt.ToString ();}

        public override string ToString()
        {
            return $"({X},{Y},{Z})";
        }
    }
}
