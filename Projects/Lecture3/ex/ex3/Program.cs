using System;
using System.IO;

namespace ex3
{
    class Program
    {

        //Goal: copy one file into another file
        public static void copyToOtherFile(string sourceFilePath, 
            string targetFilePath)
        {
            if (!File.Exists(sourceFilePath))
            {
                Console.WriteLine("File {0} doesn't exist!", sourceFilePath);
                return;
            }

            FileStream fs1 = new FileStream(sourceFilePath, FileMode.Open, FileAccess.Read);
            FileStream fs2 = new FileStream(targetFilePath, FileMode.OpenOrCreate, FileAccess.Write);

            StreamReader st = new StreamReader(fs1);
            StreamWriter output = new StreamWriter(fs2);

            string line = null;

            do
            {
                line = st.ReadLine();
                output.WriteLine(line);
            } while (line != null);

            st.Close();
            output.Close();
            fs1.Close();
            fs2.Close();

        }


        static void Main(string[] args)
        { 
            string sourcePath = @"C:\Users\Ramanqul\Desktop\readme2.txt";
            string targetPath = @"C:\Users\Ramanqul\Desktop\readme3.txt";

            copyToOtherFile(sourcePath, targetPath);

        }
    }
}
