using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using System.Text.RegularExpressions;

namespace pp2.lab4.test
{
    [TestClass]
    public class Task1Tests
    {

        private bool areEq(string a, string b)
        {
            return Regex.Replace(a, @"\s+", "") == Regex.Replace(b, @"\s+", "");
        }

        [TestMethod]
        public void TestSerialize()
        {
            ComplexNumber n = new ComplexNumber();
            n.a = 1;
            n.b = 2;

            string filePath = Path.GetTempPath() + Guid.NewGuid().ToString() + ".xml";

            Task1 t = new Task1();
            t.serializeNumber(n, filePath);

            Assert.IsTrue(File.Exists(filePath), "File {0} was not created. Probably stream was not closed!", filePath);

            string outputXML = File.ReadAllText(filePath);

            string expectedXML =
               "<?xml version=\"1.0\" encoding=\"utf-8\"?>" + 
               "<complex xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">" +
               "<a>1</a>" +
               "<b>2</b>" +
               "</complex>";

            Assert.IsTrue(areEq(expectedXML, outputXML), "Xml files are not equal!");

            File.Delete(filePath);
        }

        [TestMethod]
        public void TestDeserialize()
        {
            string someXML =
               " <? xml version =\"1.0\" encoding=\"utf-8\"?>" +
                  "<complex xmlns:xsi = \"http://www.w3.org/2001/XMLSchema-instance\" xmlns: xsd = \"http://www.w3.org/2001/XMLSchema\" >" +
                  "<a>1</a>" +
                  "<b>2</b>" +
                  "</complex>";

            string filePath = Path.GetTempPath() + Guid.NewGuid().ToString() + ".xml";

            File.WriteAllText(filePath, someXML);

            Task1 t = new Task1();
            ComplexNumber outputNumber = t.deserializeNumber(filePath);

            Assert.IsNotNull(outputNumber, "deserialized number is null!");
            Assert.AreEqual(outputNumber.a, 5);
            Assert.AreEqual(outputNumber.b, 8);

            File.Delete(filePath);
        }


    }
}
