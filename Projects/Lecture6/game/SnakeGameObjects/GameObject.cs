using System.Collections.Generic;

namespace pp2.lecture6.snakeobjects
{

    public abstract class GameObject
    {
        protected char name;
        protected List<Point> points;
        public GameObject(char name)
        {
            this.name = name;
            points = new List<Point>();
        }

        public char GetObjectName()
        {
            return name;
        }

        public abstract void Draw();
        public abstract void Clear();
    }
}
