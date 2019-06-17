using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using task4;

namespace task4Unit
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestSample1()
        {
			Program p = new Program();	//creating an object instance
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
			Program p = new Program();	//creating an object instance
			string output = p.DrawStarTriangle(1);
			string expectedOutput = "[*]\n";
			
			Assert.AreEqual(expectedOutput, output);
        }
		
		[TestMethod]
        public void TestSample3()
        {
			Program p = new Program();	//creating an object instance
			string output = p.DrawStarTriangle(0);
			string expectedOutput = "";
			Assert.AreEqual(expectedOutput, output);
        }
    }
}
