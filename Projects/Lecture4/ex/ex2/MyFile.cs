using System;
using System.Collections.Generic;
using System.Text;
using pp2.lecture4;

namespace pp2.lecture4
{
    public class MyFile
    {
        private string fileName;
        private FileType fileType;

        public MyFile(string fileName, FileType fileType)
        {
            this.fileName = fileName;
            this.fileType = fileType;
        }

        public string getFileName()
        {
            return fileName;
        }

        public FileType getFileType()
        {
            return fileType;
        }

    }
}
