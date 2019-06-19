using Microsoft.VisualStudio.TestTools.UnitTesting;
using pp2.lab2;
using System;
using System.IO;

namespace pp2.lab2.unit
{
    [TestClass]
    public class Task1UnitTests
    {
        [TestMethod]
        public void TestAbaba()
        {
            string filePath = Path.GetTempPath() + Guid.NewGuid().ToString() + ".txt";

            string input = "ababa";

            File.WriteAllText(filePath, input);

            Task1 t = new Task1();
            bool output = t.isPalindrome(filePath);

            Assert.IsTrue(File.Exists(filePath));

            bool expectedOutput = true;
            Assert.AreEqual(expectedOutput, output);

            

            File.Delete(filePath);
        }

        [TestMethod]
        public void TestAba()
        {
            string filePath = Path.GetTempPath() + Guid.NewGuid().ToString() + ".txt";

            string input = "aba";

            File.WriteAllText(filePath, input);

            Task1 t = new Task1();
            bool output = t.isPalindrome(filePath);

            Assert.IsTrue(File.Exists(filePath));

            bool expectedOutput = true;
            Assert.AreEqual(expectedOutput, output);


            File.Delete(filePath);
        }
        [TestMethod]
        public void TestEmpty()
        {
            string filePath = Path.GetTempPath() + Guid.NewGuid().ToString() + ".txt";

            string input = "";

            File.WriteAllText(filePath, input);

            Task1 t = new Task1();
            bool output = t.isPalindrome(filePath);

            Assert.IsTrue(File.Exists(filePath));

            bool expectedOutput = true;
            Assert.AreEqual(expectedOutput, output);


            File.Delete(filePath);
        }

        [TestMethod]
        public void TestSingle()
        {
            string filePath = Path.GetTempPath() + Guid.NewGuid().ToString() + ".txt";

            string input = "a";

            File.WriteAllText(filePath, input);

            Task1 t = new Task1();
            bool output = t.isPalindrome(filePath);

            Assert.IsTrue(File.Exists(filePath));

            bool expectedOutput = true;
            Assert.AreEqual(expectedOutput, output);


            File.Delete(filePath);
        }

        [TestMethod]
        public void TestRepaper()
        {
            string filePath = Path.GetTempPath() + Guid.NewGuid().ToString() + ".txt";

            string input = "repaper";

            File.WriteAllText(filePath, input);

            Task1 t = new Task1();
            bool output = t.isPalindrome(filePath);

            Assert.IsTrue(File.Exists(filePath));

            bool expectedOutput = true;
            Assert.AreEqual(expectedOutput, output);


            File.Delete(filePath);
        }

        [TestMethod]
        public void TestRatator()
        {
            string filePath = Path.GetTempPath() + Guid.NewGuid().ToString() + ".txt";

            string input = "Ratator";

            File.WriteAllText(filePath, input);

            Task1 t = new Task1();
            bool output = t.isPalindrome(filePath);

            Assert.IsTrue(File.Exists(filePath));

            bool expectedOutput = false;
            Assert.AreEqual(expectedOutput, output);


            File.Delete(filePath);
        }


    }
}







