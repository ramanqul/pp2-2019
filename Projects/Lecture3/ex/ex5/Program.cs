using System;
using System.IO;


namespace ex5
{
    class Program
    {

        public static void PrintInfo(FileSystemInfo fsi, int deep)
        {

        }

        static void Main(string[] args)
        {
            string filePath = @"D:\Code\kbtu\2019\pp1-2019\week2";

            DirectoryInfo dirInfo = new DirectoryInfo(filePath);
            PrintInfo(dirInfo, 0);
        }
    }
}
