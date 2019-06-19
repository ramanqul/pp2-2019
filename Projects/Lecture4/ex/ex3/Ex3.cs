using System;
using System.Collections.Generic;
using System.IO;


namespace pp2.lecture4
{

    public enum FileType
    {
        FILE, DIRECTORY
    }

    public class Ex3
    {

        private string currentFilePath;

        public Ex3(string filePath)
        {
            if (!Directory.Exists(filePath))
            {
                throw new Exception("Directory doesn't exist!");
            }

            currentFilePath = filePath;
            Console.WriteLine("Executing constructor: passed value is {0}", filePath);
        }

        public List<MyFile> Explore()
        {
            List<MyFile> result = new List<MyFile>();

            DirectoryInfo dirInfo = new DirectoryInfo(currentFilePath);

            foreach (var fsi in dirInfo.GetFileSystemInfos())
            {
                if (fsi.GetType() == typeof(DirectoryInfo))
                {
                    //we have a directory
                    result.Add(new MyFile(fsi.Name, FileType.DIRECTORY));
                }
                else
                {
                    //we have a file
                    result.Add(new MyFile(fsi.Name, FileType.FILE));
                }
            }

            return result;
        }

        public void Draw()
        {
            List<MyFile> filesAndFolders = Explore();

            bool firstColored = false;

            foreach (var f in filesAndFolders)
            {

                if (!firstColored)
                {
                    firstColored = true;
                    Console.BackgroundColor = ConsoleColor.Blue;
                } else
                {
                    Console.BackgroundColor = ConsoleColor.Black;
                }

                if (f.getFileType() == FileType.DIRECTORY)
                {
                    Console.ForegroundColor = ConsoleColor.White;
                } else
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                }

                Console.WriteLine("{1} - {0}", f.getFileName(), f.getFileType());
            }

        }

        static void Main(string[] args)
        {
            Ex3 ex = new Ex3(@"C:\");
            ex.Draw();

        }
    }
}
