using System;
using pp2.lecture6.snakeobjects;

namespace pp2.lecture6.snake.game1
{
    class Program
    {

        static GameAction KeyToAction(ConsoleKey key) 
        {
            switch (key)
            {
                case ConsoleKey.UpArrow: return GameAction.MOVE_UP;
                case ConsoleKey.DownArrow: return GameAction.MOVE_DOWN;
                case ConsoleKey.LeftArrow: return GameAction.MOVE_LEFT;
                case ConsoleKey.RightArrow: return GameAction.MOVE_RIGHT;
                case ConsoleKey.Escape: return GameAction.PAUSE;
                case ConsoleKey.Delete: return GameAction.STOP;
                default: return GameAction.UNKNOWN;
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your name: ");
            string playerName = Console.ReadLine();
            GameSession gameSession = new GameSession(playerName);

            GameState state = GameState.PLAYING;
            GameAction action = GameAction.UNKNOWN;

            while (state != GameState.LOST)
            {
                state = gameSession.play(action);
                ConsoleKeyInfo keyInfo = Console.ReadKey();
                action = KeyToAction(keyInfo.Key);
            } 
        }
    }
}
