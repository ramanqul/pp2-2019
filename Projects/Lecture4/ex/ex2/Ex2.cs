using System;
using System.Collections.Generic;
using System.IO;

namespace pp2.lecture4
{

    public enum FileType
    {
        FILE, DIRECTORY
    }

    public class Ex2
    {

        private string currentFilePath;

        public Ex2(string filePath)
        {
            if (!Directory.Exists(filePath))
            {
                throw new Exception("Directory doesn't exist!");
            }
            
            currentFilePath = filePath;
            Console.WriteLine("Executing constructor: passed value is {0}", filePath);
        }

        public List<MyFile> explore()
        {
            List<MyFile> result = new List<MyFile>();

            DirectoryInfo dirInfo = new DirectoryInfo(currentFilePath);

            foreach (var fsi in dirInfo.GetFileSystemInfos())
            {
                if (fsi.GetType() == typeof(DirectoryInfo))
                {
                    //we have a directory
                    result.Add(new MyFile(fsi.Name, FileType.DIRECTORY));
                } else
                {
                    //we have a file
                    result.Add(new MyFile(fsi.Name, FileType.FILE));
                }
            }

            return result;
        }

        static void Main(string[] args)
        {
            Ex2 ex = new Ex2(@"C:\");
            List<MyFile> filesAndFolders = ex.explore();

            foreach (var f in filesAndFolders)
            {
                Console.WriteLine("{1} - {0}", f.getFileName(), f.getFileType());
            }

        }
    }
}
