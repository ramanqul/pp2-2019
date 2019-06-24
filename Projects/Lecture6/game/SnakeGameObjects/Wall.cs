using System;

namespace pp2.lecture6.snakeobjects
{
    public class Wall: GameObject
    {
        public Wall(char name) : base(name)
        {
        }

        public void AddPoint(Point p)
        {
            points.Add(p);
        }

        public void ClearPoints()
        {
            points.Clear();
        }

        public bool Collides(int x, int y)
        {
            foreach(var p in points)
            {
                if (p.X == x && p.Y == y)
                {
                    return true;
                }
            }

            return false;
        }

        public override void Draw()
        {
            foreach(var p in points)
            {
                Console.SetCursorPosition(p.X, p.Y);
                Console.Write(GetObjectName());
            }
        }

        public override void Clear()
        {
            throw new NotImplementedException();
        }
    }
}
