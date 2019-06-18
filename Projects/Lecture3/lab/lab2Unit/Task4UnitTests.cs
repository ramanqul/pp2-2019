using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using pp2.lab2;

namespace pp2.lab2.unit
{
    [TestClass]
    public class Task4UnitTests
    {
        [TestMethod]
        public void TestSingleCase()
        {
            string inputFolder = System.IO.Path.GetTempPath() + System.IO.Path.PathSeparator
                + Guid.NewGuid().ToString() + System.IO.Path.PathSeparator + "MyInputFolder";

            string outputFolder = System.IO.Path.GetTempPath() + System.IO.Path.PathSeparator
                + Guid.NewGuid().ToString() + System.IO.Path.PathSeparator + "MyOutputFolder";

            string fileName = "demofile.txt";

            Task4 t = new Task4();
            t.createCopyDrop(inputFolder, outputFolder, fileName);
            Assert.IsFalse(File.Exists(inputFolder + Path.PathSeparator + fileName));
            Assert.IsTrue(File.Exists(outputFolder + Path.PathSeparator + fileName));

            File.Delete(outputFolder + Path.PathSeparator + fileName);
        }
    }
}
