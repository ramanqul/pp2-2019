using System;
using System.Collections.Generic;
using System.Text;

namespace pp2.lab4
{

    public class Mark
    {
        public int point { get; set; }

        //TODO
        //1) add GetLetter method which will return grade letter from point
        //2) add ToString method which will return Mark as string
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
