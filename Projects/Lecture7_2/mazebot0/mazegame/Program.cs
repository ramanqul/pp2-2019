using System;

namespace pp2.lecture8.mazegame
{

    public enum GameState
    {
        START, PLAYING, WIN, LOST, PAUSE
    }

    public enum GameAction
    {
        START, MOVE_UP, MOVE_DOWN, MOVE_RIGHT, MOVE_LEFT, PAUSE, UNKNOWN
    }

    public class Program
    {
        static GameAction KeyToGameAction(ConsoleKeyInfo keyInfo)
        {

            ConsoleKey key = keyInfo.Key;
            switch (key)
            {
                case ConsoleKey.UpArrow: return GameAction.MOVE_UP;
                case ConsoleKey.DownArrow: return GameAction.MOVE_DOWN;
                case ConsoleKey.LeftArrow: return GameAction.MOVE_LEFT;
                case ConsoleKey.RightArrow: return GameAction.MOVE_RIGHT;
                case ConsoleKey.Escape: return GameAction.PAUSE;
                case ConsoleKey.Enter: return GameAction.START;
                default: return GameAction.UNKNOWN;
            }

        }
        static void Main(string[] args)
        {

            //1.To Load the map by level
            //2.To move person by this map
            //3.When person finds exit new map must be loaded

            GameState state = GameState.START;
            GameSession session = new GameSession();
            GameAction action = GameAction.UNKNOWN;

            //game loop
            while (state != GameState.LOST)
            {
                state = session.play(action);
                action = KeyToGameAction(Console.ReadKey());
            }

        }
    }
}
