using Microsoft.VisualStudio.TestTools.UnitTesting;
using pp2.lab2;
using System;
using System.IO;

namespace pp2.lab2.unit
{
    [TestClass]
    public class Task1UnitTests
    {
        private void writeAndExpect(string input, bool expectedOutput)
        {
            string filePath = Path.GetTempPath() + Guid.NewGuid().ToString() + ".txt";

            File.WriteAllText(filePath, input);

            Task1 t = new Task1();
            bool output = t.isPalindrome(filePath);

            Assert.IsTrue(File.Exists(filePath));

            Assert.AreEqual(expectedOutput, output);

            File.Delete(filePath);
        }

        [TestMethod]
        public void TestAbaba()
        {
            writeAndExpect("ababa", true);
        }

        [TestMethod]
        public void TestAba()
        {
            writeAndExpect("aba", true);
        }

        [TestMethod]
        public void TestEmpty()
        {
            writeAndExpect("", true);
        }

        [TestMethod]
        public void TestSingle()
        {
            writeAndExpect("a", true);
        }

        [TestMethod]
        public void TestRepaper()
        {
            writeAndExpect("repaper", true);
        }

        [TestMethod]
        public void TestRatator()
        { 
            writeAndExpect("Ratator", false);
        }


    }
}







