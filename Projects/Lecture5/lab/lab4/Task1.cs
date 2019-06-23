using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace pp2.lab4
{
    [XmlRoot("complex")]
    public class ComplexNumber
    {
        public int a { get; set; }
        public int b { get; set; }
    }

    public class Task1
    {
        public ComplexNumber deserializeNumber(string filePath)
        {
            //TODO: 
            //read xml file from filePath parameter and return deserialized object
            return null;
        }

        public void serializeNumber(ComplexNumber num, string filePath)
        {
            //TODO: 
            //serialize num parameter into xml and write it into a file under filePath location
        }

    }
}
