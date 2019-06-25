using System;
using System.Collections.Generic;
using System.Text;

namespace pp2.lecture6.snake1.gameobjects
{
    public class Point
    {

        public Point() { }
        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }
        public int X { get; set; }
        public int Y { get; set; }
    }
}
