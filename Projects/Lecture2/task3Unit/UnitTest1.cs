using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using task3;


namespace task3Unit
{
    [TestClass]
    public class UnitTest1
    {
		
		public void testInternal(int[] input, int[] expectedOutput) {
			Program p = new Program();
			
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
