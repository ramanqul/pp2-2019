using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;
using pp2.lecture6.snakeobjects;

namespace pp2.lecture6.snake.game1
{

    public enum GameState
    {
        PLAYING, PAUSED, LOST, WIN
    }

    public class GameSession
    {

        private string playerName;
        private int points = 0;
        private int level = 1;
        private GameState gameState;
        private List<GameObject> gameObjectList;

        private Wall wall;
        private Snake snake;
        private Food food;


        public GameSession(string playerName)
        {
            this.playerName = playerName;
            gameState = GameState.PAUSED;
            gameObjectList = new List<GameObject>();

            wall = new Wall('#');
            snake = new Snake('S');
            food = new Food('$');

            LoadMapByLevel();

            InitWindow();
        }

        public string GetPlayerName()
        {
            return playerName;
        }

        public int getPoints()
        {
            return points;
        }

        private void InitWindow()
        {
            Console.SetBufferSize(40, 40);
            Console.SetWindowSize(40, 40);
            Console.CursorVisible = false;
        }
        public void LoadMapByLevel()
        {
            string filePath = string.Format(@"Levels/Level{0}.txt", level);
            FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);

            int y = 0;

            while (!sr.EndOfStream)
            {
                string line = sr.ReadLine();

                for (int x = 0; x < line.Length; x++)
                {
                    if (line[x] == wall.GetObjectName())
                    {
                        wall.AddPoint(new Point(x, y));
                    }
                }

                y++;
            }
        }

        private Point GetFreeRandomPoint()
        {
            Random random = new Random(DateTime.Now.Second);

            int randomX = random.Next(0, 39);
            int randomY = random.Next(0, 39);

            while (wall.Collides(randomX, randomY))
            {
                randomX = random.Next(0, 39);
                randomY = random.Next(0, 39);
            }

            return new Point(randomX, randomY);
        }

        public GameState play(GameAction action)
        {
            switch (action)
            {
                case GameAction.STOP: stop(); break;
                case GameAction.PAUSE: pause(); break;
                default: Console.WriteLine("Unknown action {0}", action); break;
            }

            render();

            return GameState.PLAYING;
        }

        private void render()
        {
            Console.Clear();
            wall.Draw();
            food.Clear();

            food.AddPoint(GetFreeRandomPoint());

            food.Draw();
            snake.Draw();
        }


        public void pause()
        {
            Console.Clear();
            Console.WriteLine("Game Paused");
        }

        public void stop()
        {
            Console.Clear();
            Console.WriteLine("Game Stoped");

        }

    }
}
