using System;
using System.Collections.Generic;
using System.IO;


namespace pp2.lab3
{

    public enum FileType
    {
        FILE, DIRECTORY
    }

    public class FarManager
    {

        private string currentFilePath;
        private int selectedFileIndex = 0;
        private List<MyFile> currentFilesAndFolders;

        public FarManager(string filePath)
        {
            if (!Directory.Exists(filePath))
            {
                throw new Exception("Directory doesn't exist!");
            }

            currentFilePath = filePath;
            Console.WriteLine("Executing constructor: passed value is {0}", filePath);
            currentFilesAndFolders = new List<MyFile>();
            
        }

        public void Explore(string filePath)
        {
            //empty before exploring
            currentFilesAndFolders.Clear();

            DirectoryInfo dirInfo = new DirectoryInfo(filePath);

            foreach (var fsi in dirInfo.GetFileSystemInfos())
            {
                if (fsi.GetType() == typeof(DirectoryInfo))
                {
                    //we have a directory
                    currentFilesAndFolders.Add(new MyFile(fsi.Name, FileType.DIRECTORY));
                }
                else
                {
                    //we have a file
                    currentFilesAndFolders.Add(new MyFile(fsi.Name, FileType.FILE));
                }
            }
        }

        public void Draw()
        {
            for (int i = 0; i < currentFilesAndFolders.Count; i++)
            {
                var f = currentFilesAndFolders[i];


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

        //Hint: use currentFilePath = currentFilePath + "/" + currentFilesAndFolders[selectedFileIndex];
        public void openFolder()
        {
            //TODO:write code here
        }


        //Hint: use currentFilePath = currentFilePath + "/" + currentFilesAndFolders[selectedFileIndex];
        public void openFile()
        {
            //TODO: write code here
            //use StreamReader to read a file
        }


        public void UserInput()
        {
            while (true)
            {
                Explore(currentFilePath);

                Draw();

                ConsoleKeyInfo keyInfo = Console.ReadKey();

                Console.Clear();

                if (keyInfo.Key == ConsoleKey.DownArrow)
                {
                    //change selected file name
                    selectedFileIndex++;
                }
                else if (keyInfo.Key == ConsoleKey.UpArrow)
                {
                    if (selectedFileIndex > 0)
                    {
                        selectedFileIndex--;
                    }
                }
                else if (keyInfo.Key == ConsoleKey.Enter)
                {
                    //TODO: open selected folder
                    //if it is folder then call openFolder method
                    // else call openFile method
                }
                else if (keyInfo.Key == ConsoleKey.Escape)
                {
                    //exit
                    break;
                }

            }
        }


        static void Main(string[] args)
        {
            FarManager far = new FarManager(@"C:\");
            far.UserInput();
        }
    }
}

