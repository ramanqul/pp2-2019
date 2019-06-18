using System;
using System.IO;


namespace ex5
{
    class Program
    {

        public static void PrintInfo(FileSystemInfo fsi, int deep)
        {
            if (fsi.GetType() == typeof(DirectoryInfo))
            {
                DirectoryInfo dirInfo = (DirectoryInfo) fsi; //downcast

                foreach(var f in dirInfo.GetFileSystemInfos())
                {
                    PrintInfo(f, deep+1);
                }

                Console.ForegroundColor = ConsoleColor.White;
            } else {
                Console.ForegroundColor = ConsoleColor.Red;
            }

            for (int i=0;i<deep;i++)
            {
                Console.Write(" ");
            }

            Console.WriteLine(fsi.Name);
            
        }

        static void Main(string[] args)
        {
            string filePath = @"D:\Code\kbtu\2019\pp1-2019";

            DirectoryInfo dirInfo = new DirectoryInfo(filePath);

            PrintInfo(dirInfo, 0);
        }
    }
}
