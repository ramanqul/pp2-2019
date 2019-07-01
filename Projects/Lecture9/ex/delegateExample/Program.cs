using System;

namespace delegateExample
{
    class Program
    {


        delegate void SomeCallbackFunction(int result);


        private static void fn1(SomeCallbackFunction callback)
        {
            Console.WriteLine("Executing fn1");

            int result = 10;

            callback.Invoke(result);
        }



        private static void fn2(int result) {
            Console.WriteLine("Executing fn2. Result is {0}", result);
        }

        private static void fn3(int result)
        {
            Console.WriteLine("Executing fn3. Result is {0}", result);
        }

        private static void fn4(int result)
        {
            Console.WriteLine("Executing fn4. Result is {0}", result);
        }

        //Explain use case
        //What is delegate?
        //delegate is a pattern

        static void Main(string[] args)
        {
            
            Console.WriteLine("Hello World!");

            SomeCallbackFunction cb = new SomeCallbackFunction(fn4);

            Random rnd = new Random();
            int someNumber = rnd.Next(0, 3);

            SomeCallbackFunction[] callbacks = {
                new SomeCallbackFunction(fn2),
                new SomeCallbackFunction(fn3),
                new SomeCallbackFunction(fn4)
            };

            fn1(callbacks[someNumber]);
        }
    }
}
