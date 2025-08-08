using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADV01
{
    internal class Point2D
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Point2D(int _X, int _Y)
        {
            X = _X;
            Y = _Y;
        }
    }

    internal class Point3D : Point2D
    {
        public int Z { get; set; }

        public Point3D(int _X, int _Y, int _Z) : base(_X, _Y)
        {
            Z = _Z;
        }
    }
}
