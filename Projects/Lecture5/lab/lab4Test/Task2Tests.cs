using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using pp2.lab4;

namespace pp2.lab4.test
{


    [TestClass]
    public class Task2Tests
    {

        private bool areEq(string a, string b)
        {
            return Regex.Replace(a, @"\s+", "") == Regex.Replace(b, @"\s+", "");
        }

        [TestMethod]
        public void TestSerializeList()
        {
            string filePath = Path.GetTempPath() + Guid.NewGuid().ToString() + ".xml";

            Task2 t = new Task2();

            List<Mark> marksList = new List<Mark>();
            marksList.Add(new Mark(50));
            marksList.Add(new Mark(63));
            marksList.Add(new Mark(70));
            marksList.Add(new Mark(85));

            t.serializeList(marksList, filePath);


            Assert.IsTrue(File.Exists(filePath), "Please close the streams before!");

            string outputXML = File.ReadAllText(filePath);

            string expectedXML =
            "<?xml version=\"1.0\" encoding=\"utf-8\"?>" +
            "<marks xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">" +
            "<mark>" +
            "<point>50</point>" +
            "</mark>" +
            "<mark>" +
            "<point>63</point>" +
            "</mark>" +
            "<mark>" +
            "<point>70</point>" +
            "</mark>" +
            "<mark>" +
            "<point>85</point>" +
            "</mark>" +
            "</marks>";

            Assert.IsTrue(areEq(expectedXML, outputXML), "Xml files are not equal!");

            File.Delete(filePath);
        }

        [TestMethod]
        public void TestDeserializeList()
        {
            string filePath = Path.GetTempPath() + Guid.NewGuid().ToString() + ".xml";

            Task2 t = new Task2();

            string someXML =
                "<?xml version=\"1.0\" encoding=\"utf-8\"?>" +
                "<marks xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">" +
                "<mark>" +
                "<point>30</point>" +
                "</mark>" +
                "<mark>" +
                "<point>43</point>" +
                "</mark>" +
                "<mark>" +
                "<point>40</point>" +
                "</mark>" +
                "<mark>" +
                "<point>100</point>" +
                "</mark>" +
                "</marks>";

            File.WriteAllText(filePath, someXML);

            List<Mark> expectedMarksList = new List<Mark>();
            expectedMarksList.Add(new Mark(30));
            expectedMarksList.Add(new Mark(43));
            expectedMarksList.Add(new Mark(40));
            expectedMarksList.Add(new Mark(100));

            List<Mark> outputMarkList = t.deserializeList(filePath);

            Assert.IsNotNull(outputMarkList);
            Assert.AreEqual(outputMarkList.Count, 4);
            for (int i=0;i<outputMarkList.Count;i++)
            {
                Assert.AreEqual(expectedMarksList[i].point, outputMarkList[i].point);
            }

            File.Delete(filePath);
        }

    }
}
