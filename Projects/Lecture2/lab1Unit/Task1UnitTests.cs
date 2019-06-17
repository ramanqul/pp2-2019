using Microsoft.VisualStudio.TestTools.UnitTesting;
using pp2.lab1;
using System;

namespace pp2.lab1.unit
{
    [TestClass]
    public class Task1UnitTests
    {
        [TestMethod]
        public void SampleTest1()
        {
			int[] input1 = new int[] {1, 2, 3, 4, 5};
			
			Task1 p = new Task1();
			int[] output1 = p.filterPrimeNumbers(input1);
			
			int[] expectedOutput1 = new int[]{2, 3, 5};
			
			Assert.AreEqual(3, output1.Length);
			
			for (int i=0;i<3;i++) {
				Assert.AreEqual(expectedOutput1[i], output1[i]);
			}
        }
		
		
		[TestMethod]
        public void SampleTest2()
        {
			int[] input1 = new int[] {0};
			
			Task1 p = new Task1();
			int[] output1 = p.filterPrimeNumbers(input1);
			
			int[] expectedOutput1 = new int[]{};
			
			Assert.AreEqual(0, output1.Length);
        }

		[TestMethod]
        public void SampleTest3()
        {
			int[] input1 = new int[] {111, 321, 557};
			
			Task1 p = new Task1();
			int[] output1 = p.filterPrimeNumbers(input1);
			
			int[] expectedOutput1 = new int[]{557};
			
			Assert.AreEqual(1, output1.Length);

			for (int i=0;i<1;i++) {
				Assert.AreEqual(expectedOutput1[i], output1[i]);
			}

        }
		
    }
}







