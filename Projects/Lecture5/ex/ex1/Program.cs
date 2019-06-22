using System;
using System.IO;

namespace ex1
{

    class ComplexNumber
    {
        //real part
        public int a { get; set; }
        //imaginary part
        public int b { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            ComplexNumber n1 = new ComplexNumber();
            
            string filePath = @"C:\Users\Ramanqul\Desktop\ex1.complex";

            FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            string line = sr.ReadLine();
            string[] vals = line.Split(' ');
            
            n1.a = int.Parse(vals[0]);
            n1.b = int.Parse(vals[1]);

            Console.WriteLine("real part {0} and imaginary part {1}", n1.a, n1.b);

        }
    }
}
