using System;
using System.Xml.Serialization;
using System.IO;
using System.Collections.Generic;

namespace ex2
{

    [Serializable]
    [XmlRoot("student")]
    public class Student
    {
        public Student() { }
        public Student(string name, string surname, int age)
        {
            this.name = name;
            this.surname = surname;
            this.age = age;
        }

        public string name { get; set; }
        public string surname { get; set; }
        public int age { get; set; }

    }

    [Serializable]
    [XmlRootAttribute("students")]
    public class StudentList
    {

        [XmlElement("student")]
        public List<Student> students { get; set; }


    }


    class Program
    {

        public static Student readXml(string filePath)
        {
            XmlSerializer xs = new XmlSerializer(typeof(Student));
            FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);

            Student std = xs.Deserialize(sr) as Student;

            return std;
        }


        public static List<Student> readXmlList(string filePath)
        {
            XmlSerializer xs = new XmlSerializer(typeof(StudentList));
            FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);

            StudentList stdList = xs.Deserialize(sr) as StudentList;

            return stdList.students;
        }


        public static void writeStudentAsXml(string filePath, Student s)
        {
            XmlSerializer xs = new XmlSerializer(typeof(Student));
            FileStream fs = new FileStream(filePath, FileMode.Create, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);

            xs.Serialize(sw, s);
        }

        public static void writeStudentListAsXml(string filePath, List<Student> studentList)
        { 
            StudentList lst = new StudentList();
            lst.students = studentList;

            XmlSerializer xs = new XmlSerializer(typeof(StudentList));
            FileStream fs = new FileStream(filePath, FileMode.Create, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);

            xs.Serialize(sw, lst);
        }



        static void Main(string[] args)
        {

            //read xml file = deserialization
            //writing into xml file = serialization

            /*
            string filePath = @"C:\Users\Ramanqul\Desktop\student.xml";
            Student s = readXml(filePath);


            Console.WriteLine("Student with name {0} and surname {1} and age {2}",
                s.name, s.surname, s.age);


            string filePath2 = @"C:\Users\Ramanqul\Desktop\student2.xml";
            Student std = new Student();
            std.name = "Almas";
            std.surname = "Kuat";   
            std.age = 30;

            writeStudentAsXml(filePath2, std);
            */

            string filePathToList = @"C:\Users\Ramanqul\Desktop\student_list.xml";
            string filePathToList2 = @"C:\Users\Ramanqul\Desktop\student_list2.xml";

            List<Student> students = readXmlList(filePathToList);


            for (int i=0;i<students.Count;i++)
            {
                Student s = students[i];
            }


            foreach(var s in students)
            {
                Console.WriteLine("Student {0} {1} age {2}", s.name, s.surname, s.age);
            }


            List<Student> someStudents = new List<Student>();
            someStudents.Add(new Student("Nikita", "Bondarenko", 18));
            someStudents.Add(new Student("Nurtileu", "Amanzhol", 18));
            someStudents.Add(new Student("Makpal", "N", 18));

            writeStudentListAsXml(filePathToList2, someStudents);
        }
    }
}

