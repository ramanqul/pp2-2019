using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using pp2.lab2;

namespace pp2.lab2.unit
{
    [TestClass]
    public class Task2UnitTests
    {
        [TestMethod]
        public void TestSimpleInput()
        {
            Task2 t = new Task2();
            const string inputText = "5 3 6 2 8 11 27";
            const string expectedOutput = "5 3 2 11";
            string inputPath = Path.GetTempPath() + Guid.NewGuid().ToString() + ".txt";
            string outputPath =Path.GetTempPath() + Guid.NewGuid().ToString() + ".txt";

            File.WriteAllText(inputPath, inputText);

            t.filterPrimes(inputPath, outputPath);

            Assert.IsTrue(File.Exists(outputPath));

            string output = File.ReadAllText(outputPath);
            Assert.AreEqual(expectedOutput, output);

            File.Delete(inputPath);
            File.Delete(outputPath);
        }

        [TestMethod]
        public void TestBiggerNumbers()
        {
            Task2 t = new Task2();
            const string inputText = "999 111 888 555 0 123";
            const string expectedOutput = "";
            string inputPath = Path.GetTempPath() + Guid.NewGuid().ToString() + ".txt";
            string outputPath = Path.GetTempPath() + Guid.NewGuid().ToString() + ".txt";

            File.WriteAllText(inputPath, inputText);

            t.filterPrimes(inputPath, outputPath);

            Assert.IsTrue(File.Exists(outputPath));

            string output = File.ReadAllText(outputPath);
            Assert.AreEqual(expectedOutput, output);

            File.Delete(inputPath);
            File.Delete(outputPath);
        }

        [TestMethod]
        public void TestAllPrimesExceptOne()
        {
            Task2 t = new Task2();
            const string inputText = "11 9 21 23 71 19";
            const string expectedOutput = "11 23 71 19";

            string inputPath = Path.GetTempPath() + Guid.NewGuid().ToString() + ".txt";
            string outputPath = Path.GetTempPath() + Guid.NewGuid().ToString() + ".txt";

            File.WriteAllText(inputPath, inputText);

            t.filterPrimes(inputPath, outputPath);

            Assert.IsTrue(File.Exists(outputPath));

            string output = File.ReadAllText(outputPath);
            Assert.AreEqual(expectedOutput, output);

            File.Delete(inputPath);
            File.Delete(outputPath);
        }
    }
}
