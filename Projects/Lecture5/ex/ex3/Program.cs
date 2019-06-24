using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using ex2;

namespace ex3
{

    

    class Program
    {


        static void serializeTest(string filePath, Student s)
        {
            FileStream fs = new FileStream(filePath, FileMode.OpenOrCreate, FileAccess.Write);

            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(fs, s);
            fs.Close();

            Console.WriteLine("Serializing Student object in binary format");

        }


        static Student deserializeTest(string filePath)
        {
            FileStream fs = new FileStream(filePath, FileMode.OpenOrCreate, FileAccess.Read);

            BinaryFormatter bf = new BinaryFormatter();
            Student s = bf.Deserialize(fs) as Student;

            fs.Close();

            Console.WriteLine("Serializing Student object in binary format");

            return s;
        }

        static void Main(string[] args)
        {
            Student s = new Student();
            s.name = "Almat";
            s.surname = "Kudaibergen";
            s.age = 20;

            Console.WriteLine("Creating student object");

            string filePath = @"C:\Users\Ramanqul\Desktop\student.bin";

            serializeTest(filePath, s);

            Student s2 = deserializeTest(filePath);

            Console.WriteLine("Student name {0} {1} and age {2}", s2.name, s2.surname, s2.age);
        }
    }
}
