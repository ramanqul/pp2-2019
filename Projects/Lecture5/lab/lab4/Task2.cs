using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace pp2.lab4
{
    [XmlRoot("mark")]
    public class Mark
    {

        public Mark() { }
        public Mark(int point)
        {
            this.point = point;
        }

        public int point { get; set; }

        //TODO:
        //1) add GetLetter method which will return grade letter from point
        //2) add ToString method which will return Mark as string

        public string GetLetter()
        {
            return null;
        }

        public override string ToString()
        {
            return null;
        }

    }

    [XmlRoot("marks")]
    public class MarkList
    {
        public List<Mark> marks { get; set; }
    }

    public class Task2
    {
        public List<Mark> deserializeList(string filePath)
        {
            //TODO:
            //read xml file under filePath and return a new list of Mark collection
            return null;
        }

        public void serializeList(List<Mark> marksList, string filePath)
        {
            //TODO:
            //serialize marksList variable into xml file under filePath location
        }
    }
}
