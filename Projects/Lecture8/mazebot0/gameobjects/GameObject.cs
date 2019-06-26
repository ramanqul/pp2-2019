using System;
using System.Collections.Generic;



namespace pp2.lecture8.mazegame.gameobjects
{
    public abstract class GameObject
    {
        protected char label;
        protected List<Point> locations;

        public GameObject(char label)
        {
            this.label = label;
            locations = new List<Point>();
        }

        public char GetLebel()
        {
            return label;
        }

        public void AddPoint(Point p)
        {
            locations.Add(p);
        }

        public void PrependPoint(Point p)
        {
            locations.Add(p);
            Point t = locations[0];

            locations[0] = locations[locations.Count - 1];
            locations[locations.Count - 1] = t;
        }

        public bool Overlaps(int x, int y)
        {
            foreach(var p in locations)
            {
                if (p.X == x && p.Y == y)
                {
                    return true;
                }
            }

            return false;
        }

        public void ClearLocations()
        {
            locations.Clear();
        }

        public virtual void Draw()
        {
            foreach(var p in locations)
            {
                Console.SetCursorPosition(p.X, p.Y);
                Console.Write(label);
            }
        }

        public void Clear()
        {
            foreach (var p in locations)
            {
                Console.SetCursorPosition(p.X, p.Y);
                Console.Write(' ');
            }
        }

    }



}
