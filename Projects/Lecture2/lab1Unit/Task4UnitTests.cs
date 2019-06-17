using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using pp2.lab1;

namespace pp2.lab1.unit
{
    [TestClass]
    public class Task4UnitTests
    {
        [TestMethod]
        public void TestSample1()
        {
			Task4 p = new Task4();	//creating an object instance
			string output = p.DrawStarTriangle(3);
			string expectedOutput =
				"[*]\n"+
				"[*][*]\n" + 
				"[*][*][*]\n";
			
			Assert.AreEqual(expectedOutput, output);
        }
		
        [TestMethod]
        public void TestSample2()
        {
			Task4 p = new Task4();	//creating an object instance
			string output = p.DrawStarTriangle(1);
			string expectedOutput = "[*]\n";
			
			Assert.AreEqual(expectedOutput, output);
        }
		
		[TestMethod]
        public void TestSample3()
        {
			Task4 p = new Task4();	//creating an object instance
			string output = p.DrawStarTriangle(0);
			string expectedOutput = "";
			Assert.AreEqual(expectedOutput, output);
        }
    }
}
