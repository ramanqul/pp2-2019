using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using pp2.lab1;

namespace pp2.lab1.unit
{
    [TestClass]
    public class Task2UnitTests
    {
        [TestMethod]
        public void TestConsructor()
        {
			
			Student s = new Student("Almat", "123");
			
			Assert.AreEqual("Almat", s.getName());
			Assert.AreEqual("123", s.getId());			
        }

        [TestMethod]
        public void TestMethods()
        {
			
			Student s = new Student("Almat", "123");
			
			Assert.AreEqual("Almat", s.getName());
			Assert.AreEqual("123", s.getId());
			
			s.incrementYearOfStudy();
			s.incrementYearOfStudy();
			s.incrementYearOfStudy();
			Assert.AreEqual(3, s.getYearOfStudy());
        }
    }
}
