using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADV01
{
    internal class Point : IComparable<Point>
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Point(int _x, int _y)
        {
            X = _x; Y = _y;

        }
        public override string ToString()
        {
            return $"X = {X}, Y={Y}";

        }

        public int CompareTo(object? obj)
        {
            Point? other = (Point?)obj; 
            

            Point? other03 = obj as Point;
            if (other03 is null) return 1;
            if (this.X == other03.X)
                return this.Y.CompareTo(other03);
            else
            {
                return this.X.CompareTo(other03);
            }




        }

        public int CompareTo(Point? other)
        {
            if (other is null) return 1;
            if (other.GetType() == typeof(Point))
            {
                if (this.X == other.X)
                {

                    return this.Y.CompareTo(other);
                }
                else
                {
                    return this.CompareTo(other);
                }
            }
            return 1;


        }

    }
}
