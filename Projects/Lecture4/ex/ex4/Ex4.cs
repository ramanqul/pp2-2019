using System;
using System.Collections.Generic;
using System.IO;


namespace pp2.lecture4
{

    public enum FileType
    {
        FILE, DIRECTORY
    }

    public class Ex4
    {

        private string currentFilePath;
        private int selectedFileIndex = 0;

        public Ex4(string filePath)
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

            for (int i = 0;i<filesAndFolders.Count;i++)
            {
                var f = filesAndFolders[i];


                if (selectedFileIndex == i)
                {
                    Console.BackgroundColor = ConsoleColor.Blue;
                }
                else
                {
                    Console.BackgroundColor = ConsoleColor.Black;
                }

                if (f.getFileType() == FileType.DIRECTORY)
                {
                    Console.ForegroundColor = ConsoleColor.White;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                }

                Console.WriteLine("{1} - {0}", f.getFileName(), f.getFileType());
            }

        }

        public void UserInput()
        {
            while (true)
            {
                Draw();

                ConsoleKeyInfo keyInfo = Console.ReadKey();

                Console.Clear();

                if (keyInfo.Key == ConsoleKey.DownArrow)
                {
                    //change selected file name
                    selectedFileIndex++;
                }


                

            }
        }


        static void Main(string[] args)
        {
            Ex4 ex = new Ex4(@"C:\");
            ex.UserInput();

        }
    }
}
