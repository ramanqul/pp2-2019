using System;
using System.Collections.Generic;
using System.IO;

namespace pp2.lecture4
{
    class Ex1
    {

        private string currentFilePath;

        public Ex1(string filePath)
        {
            if (!Directory.Exists(filePath))
            {
                throw new Exception("Directory doesn't exist!");
            }

            currentFilePath = filePath;
            Console.WriteLine("Executing constructor: passed value is {0}", filePath);
        }

        public List<string> explore()
        {
            List<string> result = new List<string>();

            DirectoryInfo dirInfo = new DirectoryInfo(currentFilePath);

            foreach (var fsi in dirInfo.GetFileSystemInfos())
            {
                result.Add(fsi.Name);
            }


            return result;
        }

        static void Main(string[] args)
        {
            Ex1 ex = new Ex1(@"C:\");
            List<string> filesAndFolders = ex.explore();

            foreach(var f in filesAndFolders)
            {
                Console.WriteLine("{0}", f);
            }

        }
    }
}
