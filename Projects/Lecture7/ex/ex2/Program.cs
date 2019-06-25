using System;
using System.Threading;

namespace ex2
{
    class Program
    {

        public static void DoIntensiveCalculation()
        {

            /*
            int counter = 0;
            for (int i=0;i<1000000000;i++)
            {
                counter++;
            }*/

            Thread.Sleep(1000);

            Console.WriteLine("Finished calculation for thread " + Thread.CurrentThread.Name);
        }


        static void Main(string[] args)
        {
            Thread t1 = new Thread(DoIntensiveCalculation);
            t1.Name = "Thread 1";

            t1.Start();

            
            Thread t2 = new Thread(DoIntensiveCalculation);
            t2.Name = "Thread 2";

            t2.Start();

            t1.Join();
            t2.Join();

            Console.WriteLine("Hello World!");

        }
    }
}
