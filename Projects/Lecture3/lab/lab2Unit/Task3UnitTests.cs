using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using pp2.lab2;


namespace pp2.lab2.unit
{
    [TestClass]
    public class Task3UnitTests
    {

        private void clearFolder(string FolderName)
        {
            DirectoryInfo dir = new DirectoryInfo(FolderName);

            foreach (FileInfo fi in dir.GetFiles())
            {
                fi.Delete();
            }

            foreach (DirectoryInfo di in dir.GetDirectories())
            {
                clearFolder(di.FullName);
                di.Delete();
            }
        }

        [TestMethod]
        public void TestEmptyFolder()
        {
            string inputFolder = System.IO.Path.GetTempPath() + System.IO.Path.PathSeparator
                + Guid.NewGuid().ToString() + System.IO.Path.PathSeparator + "MyFolder";

            Directory.CreateDirectory(inputFolder);

            Task3 t = new Task3();
            string output = t.readDirectory(inputFolder);
            string expectedOutput = "";

            Assert.AreEqual(expectedOutput, output);

            clearFolder(inputFolder);
        }

        [TestMethod]
        public void TestSimpleCase()
        {
            string inputFolder = System.IO.Path.GetTempPath() + System.IO.Path.PathSeparator
                + Guid.NewGuid().ToString() + System.IO.Path.PathSeparator + "MyFolder";

            Directory.CreateDirectory(inputFolder);
            Directory.CreateDirectory(inputFolder + Path.PathSeparator + "a");
            Directory.CreateDirectory(inputFolder + Path.PathSeparator + "b");
            Directory.CreateDirectory(inputFolder + Path.PathSeparator + "c");

            Task3 t = new Task3();
            string output = t.readDirectory(inputFolder);
            string expectedOutput = "MyFolder" + 
                "\ta"+
                "\tb"+
                "\tc";

            Assert.AreEqual(expectedOutput, output);

            clearFolder(inputFolder);
        }

        [TestMethod]
        public void TestNested()
        {
            string inputFolder = System.IO.Path.GetTempPath() + System.IO.Path.PathSeparator
                + Guid.NewGuid().ToString() + System.IO.Path.PathSeparator + "MyFolder";

            Directory.CreateDirectory(inputFolder);
            Directory.CreateDirectory(inputFolder + Path.PathSeparator + "a");
            Directory.CreateDirectory(inputFolder + Path.PathSeparator + "a" + Path.PathSeparator + "b");
            Directory.CreateDirectory(inputFolder + Path.PathSeparator + "a" + Path.PathSeparator + "b" + Path.PathSeparator + "c");
            
            Task3 t = new Task3();
            string output = t.readDirectory(inputFolder);
            string expectedOutput = "MyFolder" +
                "\ta" +
                "\t\tb" +
                "\t\t\tc";

            Assert.AreEqual(expectedOutput, output);

            clearFolder(inputFolder);
        }

        [TestMethod]
        public void TestWithFiles()
        {
            string inputFolder = System.IO.Path.GetTempPath() + System.IO.Path.PathSeparator
                + Guid.NewGuid().ToString() + System.IO.Path.PathSeparator + "MyFolder";

            Directory.CreateDirectory(inputFolder);
            Directory.CreateDirectory(inputFolder + Path.PathSeparator + "a");
            File.Create(inputFolder + Path.PathSeparator + "a" + Path.PathSeparator + "a.txt");

            Directory.CreateDirectory(inputFolder + Path.PathSeparator + "a" + Path.PathSeparator + "b");
            File.Create(inputFolder + Path.PathSeparator + "a" + Path.PathSeparator + "b" + Path.PathSeparator + "b.txt");

            Directory.CreateDirectory(inputFolder + Path.PathSeparator + "a" + Path.PathSeparator + "b" + Path.PathSeparator + "c");
            Directory.CreateDirectory(inputFolder + Path.PathSeparator + "a" + Path.PathSeparator + "b" + Path.PathSeparator + "c" + Path.PathSeparator + "c.txt");

            Task3 t = new Task3();
            string output = t.readDirectory(inputFolder);
            string expectedOutput = "MyFolder" +
                "\ta" +
                "\t\ta.txt" +
                "\t\tb" +
                "\t\t\tb.txt" +
                "\t\t\tc" +
                "\t\t\t\tc.txt";

            Assert.AreEqual(expectedOutput, output);

            clearFolder(inputFolder);
        }

    }
}
