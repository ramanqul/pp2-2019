namespace pp2.lecture8.mazegame.gameobjects
{
    public class Exit: GameObject
    {
        public Exit(char label): base(label) { }

        public Point getPosition()
        {
            return locations[0];
        }

    }

}
