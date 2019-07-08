using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace MyPaint
{
    public enum ShapeType
    {
        Pencil, Rectangle, Circle, Line, Fill
    }

    public abstract class Shape
    {
        public Point Location;
    }

    public class MyPencil: Shape
    {
        public List<Point> Points;

        public MyPencil()
        {
            Points = new List<Point>();
        }
    }

    public class MyRectangle : Shape
    {
        public int Width;
        public int Height;
    }

    public class MyCircle : Shape
    {
        public int Width;
        public int Height;
    }

    public class MyLine : Shape
    {
        public Point EndLocation;
    }

}
