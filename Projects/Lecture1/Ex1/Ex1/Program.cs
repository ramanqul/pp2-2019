using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            for (int i=0;i<10;i++)
            {
                Console.WriteLine("Index {0} {1} {2}", i, "1", 2);
            }
            */
            /*
            int x = 10;

            if (x % 2 == 0)
            {
                Console.WriteLine("{0} is divisible by 2", x);
            } else
            {
                Console.WriteLine("{0} is not divisible by 2", x);
            }
            */

            string a = Console.ReadLine(); //getline
            string b = Console.ReadLine();
            Console.WriteLine(a + b);


            int x = int.Parse(a);
            int y = int.Parse(b);
            Console.WriteLine(x + y);

            Console.ReadKey();

        }
    }
}
