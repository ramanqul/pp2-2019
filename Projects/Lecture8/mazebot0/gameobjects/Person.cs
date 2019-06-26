namespace pp2.lecture8.mazegame.gameobjects
{
    public class Person: GameObject
    {

        //Move right (1, 0)
        //Move left (-1, 0)
        //Move Up (0, -1)
        //Move Down (0, 1)

        private int directionX = 1;
        private int directionY = 0;

        public Person(char label) : base(label) { }

        public void move(int dirX, int dirY)
        {
            directionX = dirX;
            directionY = dirY;
        }

        public override void Draw()
        {
            Point head = locations[0];

            int newX = head.X + directionX;
            int newY = head.Y + directionY;

            for (int i=locations.Count-1;i>0;i--)
            {
                locations[i] = locations[i - 1];
            }
            

            locations[0] = new Point(newX, newY);
            
            base.Draw();
        }

        public bool IsWallCollision(Wall wall)
        {
            Point head = locations[0];
            return wall.Overlaps(head.X, head.Y);
        }


    }

}
