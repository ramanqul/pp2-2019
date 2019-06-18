using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ex2
{
    class Program
    {

        private static string filePath = @"C:\Users\Ramanqul\Desktop\readme2.txt";

        static FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read);
        static StreamReader st = new StreamReader(fs);


        //Read a line and convert it to int
        public int ReadInt()
        {
            string s = st.ReadLine();
            return int.Parse(s);
        }        


        //List == vector
        public List<int> ReadNumbers()
        {
            string s = st.ReadLine(); //1 2 3 4 5
            string[] vals = s.Split(' '); //{1,2,3,4,5}

            List<int> result = new List<int>();

            foreach(string v in vals)
            {
                int k = int.Parse(v);
                result.Add(k);
            }

            return result;
        }


        public void closeIt()
        {
            fs.Close();
            st.Close();
        }

        static void Main(string[] args)
        {
            Program p = new Program();

            int n = p.ReadInt();
            List<int> numbers = p.ReadNumbers();
            p.closeIt();

            Console.WriteLine("N={0}", n);

            foreach (int i in numbers)
            {
                Console.WriteLine("{0}", i);
            }

            Console.ReadKey();
        }
    }
}
