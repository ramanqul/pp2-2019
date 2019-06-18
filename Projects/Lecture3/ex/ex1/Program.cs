using System;
using System.IO;

namespace ex1
{
    class Program
    {
        static void Main(string[] args)
        {

            string filePath = @"C:\Users\Ramanqul\Desktop\readme2.txt";

            FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read);
            StreamReader st = new StreamReader(fs);

            string allContent = st.ReadToEnd();

            fs.Close();

            Console.Write(allContent);
            Console.ReadKey();
        }
    }
}
