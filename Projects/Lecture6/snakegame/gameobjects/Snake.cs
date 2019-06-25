namespace pp2.lecture6.snake1.gameobjects
{
    public class Snake: GameObject
    {

        //Move right (1, 0)
        //Move left (-1, 0)
        //Move Up (0, -1)
        //Move Down (0, 1)

        private int directionX = 1;
        private int directionY = 0;

        public Snake(char label) : base(label) { }

        public void move(int dirX, int dirY)
        {
            directionX = dirX;
            directionY = dirY;
        }

        public override void Draw()
        {

            int newX = locations[0].X + directionX;
            int newY = locations[0].Y + directionY;

            for (int i=1;i<locations.Count;i++)
            {
                locations[i] = locations[i - 1];
            }

            locations[0] = new Point(newX, newY);

            base.Draw();
        }

        public bool isWallCollision(Wall wall)
        {
            return wall.Overlaps(locations[0].X, locations[0].Y);
        }

    }

}
