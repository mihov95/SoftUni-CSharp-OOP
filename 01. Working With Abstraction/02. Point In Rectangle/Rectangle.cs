using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace _02._Point_In_Rectangle
{
    public class Rectangle
    {
        public int TopLeftX { get; set; }
        public int TopLeftY { get; set; }
        public int BottomRightX { get; set; }
        public int BottomRightY { get; set; }

        public bool Contains(Point point)
        {
            return point.CoordinateX >= this.TopLeftX && point.CoordinateX <= this.BottomRightX
                && point.CoordinateY >= this.TopLeftY && point.CoordinateY <= this.BottomRightY;
        }
    }
}
