using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using pp2.lab1;


namespace pp2.lab1.unit
{
    [TestClass]
    public class Task3UnitTests
    {
		
		public void testInternal(int[] input, int[] expectedOutput) {
			Task3 p = new Task3();
			
			int[] output = p.duplicateElements(input);
			
			Assert.AreEqual(expectedOutput.Length, output.Length);
			
			for (int i=0;i<expectedOutput.Length;i++)
			{
				Assert.AreEqual(expectedOutput[i], output[i]);
			}
		}
		
        [TestMethod]
        public void TestSample1()
        {
			int[] input = new int[] {1,2,3};
			int[] expectedOutput = new int[] {1,1,2,2,3,3};
	
			testInternal(input, expectedOutput);
		}

        [TestMethod]
        public void TestSample2()
        {
			int[] input = new int[] {};
			int[] expectedOutput = new int[] {};
	
			testInternal(input, expectedOutput);
		}
    }
}
