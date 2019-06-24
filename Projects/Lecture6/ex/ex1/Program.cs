using System;
using pp2.lecture6.ex1;

namespace pp2.lecture6.ex
{


    class Car
    {

        protected int manufactureYear;

        //Inaccessible to other objects except itself
        protected void startEngine()
        {
            Console.WriteLine("Starting engine!");
            Console.WriteLine("Manufacture year is {0}", manufactureYear);
        }

        public void startEngine2()
        {
            startEngine();
        }

    }

    class ElectricCar: Car
    {
        public void testElecticCar()
        {
            manufactureYear = 2000;

            Console.WriteLine("Year of manufacture {0}", manufactureYear);
            startEngine();
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            //CarTester test = new CarTester();
            //test.testCar();

            ElectricCar ecar = new ElectricCar();
            ecar.testElecticCar();
        }
    }
}
