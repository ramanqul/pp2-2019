using System;

namespace ex3
{
    class Car
    {
        private string model;
        private int yearOfManufactoring;
        private int numberOfDoors;
        private string color;
        //many many properties
        private bool engineStarted;
        
        public void startEngine()
        {
            if (engineStarted)
            {
                Console.WriteLine("Engine already started!");
            }
            else
            {
                Console.WriteLine("Starting the engine!");

                engineStarted = true;
            }
        }

        public void stopEngine()
        {
            if (engineStarted)
            {
                Console.WriteLine("Stopping the engine!");
                engineStarted = false;
            } else
            {
                Console.WriteLine("Engine already stopped!");
            }
        }
        /*
        static void Main(string[] args)
        {
            Car car = new Car();
            car.startEngine();
            car.startEngine();
            car.stopEngine();
            car.stopEngine();
        }
        */
    }
}
