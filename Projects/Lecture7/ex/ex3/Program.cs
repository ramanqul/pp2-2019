using System;
using System.Threading;

namespace ex3
{
    class Program
    {
        private static int hours = 10;
        private static int minutes = 50;
        private static int seconds = 0;

        public static void tick()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Current time is {0}:{1}:{2}", hours, minutes, seconds);
                if (seconds >= 60)
                {
                    seconds = 0;
                    minutes++;
                } else
                {
                    seconds++;
                }

                Thread.Sleep(500);
            }
        }

        static void Main(string[] args)
        {
            Thread t = new Thread(tick);
            t.Start();
        }
    }
}
