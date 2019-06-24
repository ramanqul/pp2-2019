using System;
using System.Collections.Generic;
using System.Text;

namespace pp2.lecture6.snakeobjects
{
    public class Point
    {
        public const int MIN_WIDTH = 0;
        public const int MIN_HEIGHT = 0;
        public const int MAX_WIDTH = 40;
        public const int MAX_HEIGHT = 40;

        private int x;
        private int y;

        public Point() { }
        public Point(int x, int y)
        {
            if (!IsValidXPoint(x))
            {
                throw new ArgumentOutOfRangeException("Invalid x point");
            }

            this.x = x;

            if (!IsValidYPoint(y))
            {
                throw new ArgumentOutOfRangeException("Invalid y point");
            }

            this.y = y;
        }

        private bool IsValidXPoint(int x)
        {
            return x >= MIN_WIDTH && x <= MAX_WIDTH; 
        }

        private bool IsValidYPoint(int y)
        {
            return y >= MIN_HEIGHT && y <= MAX_HEIGHT;
        }


        public int X
        {
            get
            {
                return x;
            }
        }

        public int Y
        {
            get
            {
                return y;
            }
        }
    }
}
