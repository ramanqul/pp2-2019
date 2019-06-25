using System;
using System.Threading;

namespace ex1
{
    class Program
    {
        static int counter = 0;

        static void Main(string[] args)
        {
            Thread t1 = new Thread(doSomething);
            Thread t2 = new Thread(doSomething2);
            Thread t3 = new Thread(() => {
                Console.WriteLine("Other thing to do!");
            });

            t2.Start();
            t1.Start();
            t3.Start();
        }

        public static void doSomething2()
        {
            Console.WriteLine("Doing something 2");
        }

        public static void doSomething()
        {
            Console.WriteLine("Doing something ");
        }
    }
}
