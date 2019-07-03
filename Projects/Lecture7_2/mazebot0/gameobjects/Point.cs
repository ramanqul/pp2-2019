using System;

namespace pp2.lecture8.mazegame.gameobjects
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
