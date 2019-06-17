using Microsoft.VisualStudio.TestTools.UnitTesting;
using task1;
using System;

namespace task1Unit
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void SampleTest1()
        {
			int[] input1 = new int[] {1, 2, 3, 4, 5};
			
			Program p = new Program();
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
			
			Program p = new Program();
			int[] output1 = p.filterPrimeNumbers(input1);
			
			int[] expectedOutput1 = new int[]{};
			
			Assert.AreEqual(0, output1.Length);
        }

		[TestMethod]
        public void SampleTest3()
        {
			int[] input1 = new int[] {111, 321, 557};
			
			Program p = new Program();
			int[] output1 = p.filterPrimeNumbers(input1);
			
			int[] expectedOutput1 = new int[]{557};
			
			Assert.AreEqual(1, output1.Length);

			for (int i=0;i<1;i++) {
				Assert.AreEqual(expectedOutput1[i], output1[i]);
			}

        }
		
    }
}







