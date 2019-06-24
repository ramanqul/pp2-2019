using System;

namespace pp2.lecture6.snakeobjects
{
    public class Food: GameObject
    {
        public Food(char name): base(name)
        {

        }

        public void AddPoint(Point p)
        {
            points.Add(p);
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
            points.Clear();
        }
    }
}
