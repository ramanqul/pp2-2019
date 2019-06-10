using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex7
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "123";

            int x;

            bool success = int.TryParse(str, out x);

            if (success)
            {
                Console.WriteLine("Success x={0}", x);
            } else
            {
                Console.WriteLine("Failed to parse {0}", str);
            }

            Console.ReadKey();

        }
    }
}
