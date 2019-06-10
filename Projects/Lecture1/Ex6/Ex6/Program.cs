using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex6
{
    class Program
    {
        static void Main(string[] args)
        {

            string line = Console.ReadLine();

            int n = int.Parse(line);

            int[] a = new int[n];

            string[] vals = Console.ReadLine().Split(new char[] {',', ' ', ';', '#'});

            int Sum = 0;

            for (int i=0;i<vals.Length;i++)
            {
                a[i] = int.Parse(vals[i]);
                Sum += a[i];
            }

            Console.WriteLine("Sum of values are {0}", Sum);

            Console.ReadKey();

        }
    }
}
