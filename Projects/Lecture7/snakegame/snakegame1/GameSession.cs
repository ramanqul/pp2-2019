using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using pp2.lecture6.snake1.gameobjects;
using static pp2.lecture6.snake1.game.Program;

namespace pp2.lecture6.snake1.game
{
    public class GameSession
    {

        private string playerName;
        private int points = 0;
        private int level = 1;

        private Snake snake;
        private Wall wall;
        private Food food;


        public GameSession(string playerName)
        {
            this.playerName = playerName;


            snake = new Snake('0');
            wall = new Wall('#');
            food = new Food('$');


            initPositions();
        }


        private void initPositions()
        {

            for (int i = 1; i < 5; i++)
            {
                snake.AddPoint(new Point(i, 20));
            }

            LoadMap(level);

            food.ClearLocations();
            food.AddPoint(GetRandomPoint());


        }

        public Point GetRandomPoint()
        {

            Random rnd = new Random(DateTime.Now.Second);
            int randomX = rnd.Next(0, 40);
            int randomY = rnd.Next(0, 40);

            while (true)
            {
                if (!wall.Overlaps(randomX, randomY) 
                    && !snake.Overlaps(randomX, randomY))
                {
                    return new Point(randomX, randomY);
                } else
                {
                    randomX = rnd.Next(0, 40);
                    randomY = rnd.Next(0, 40);
                }
            }

        }


        public void LoadMap(int level)
        {

            string filePath = string.Format("Levels/Level{0}.txt", level);

            FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);

            int x = 0;
            int y = 0;

            wall.ClearLocations();

            while (!sr.EndOfStream)
            {
                string line = sr.ReadLine();
                for (x = 0;x<line.Length;x++)
                {
                    if (line[x] == wall.GetLebel())
                    {
                        wall.AddPoint(new Point(x, y));
                    }
                }

                y++;
            }

            sr.Close();
            fs.Close();
        }


        public GameState play(GameAction action)
        {
            render();
            //Move right (1, 0)
            //Move left (-1, 0)
            //Move Up (0, -1)
            //Move Down (0, 1)


            if (action == GameAction.MOVE_UP)
            {
                snake.move(0, -1);
            } else if (action == GameAction.MOVE_RIGHT)
            {
                snake.move(1, 0);
            } else if (action == GameAction.MOVE_DOWN)
            {
                snake.move(0, 1);
            } else if (action == GameAction.MOVE_LEFT)
            {
                snake.move(-1, 0);
            }


            //check collision function
            if (snake.IsWallCollision(wall))
            {
                return GameState.LOST;
            }


            //check for food eaten
            if (snake.HasFoodEaten(food))
            {
                snake.Grow(food);
            }


            return GameState.START;
        }

        public void render()
        {
            wall.Clear();
            food.Clear();
            snake.Clear();

            wall.Draw();
            food.Draw();
            snake.Draw();

        }

    }
}
