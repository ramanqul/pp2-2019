using System;
using System.IO;

namespace ex4
{
    class Program
    {

        public static void dirs(DirectoryInfo dirInfo, int deep) 
        {
            foreach( DirectoryInfo d in dirInfo.GetDirectories())
            {
                for(int i=0;i<deep;i++)
                {
                    Console.Write("\t");
                }

                Console.WriteLine("{0}", d.Name);
                dirs(d, deep+1);
            }

            FileInfo[] files = dirInfo.GetFiles();
            foreach(var f in files)
            {
                for (int i = 0; i < deep; i++)
                {
                    Console.Write("\t");
                }

                Console.WriteLine("{0}", f.Name);
            }

        }


        static void Main(string[] args)
        {

            string filePath = @"D:\Code\kbtu\2019\pp1-2019";
            DirectoryInfo dirInfo = new DirectoryInfo(filePath);
            dirs(dirInfo, 0);

        }
    }
}
