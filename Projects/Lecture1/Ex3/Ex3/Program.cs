using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex3
{
    //alternative is like a struct
    class Student
    {
        public string name;
        public string surname;

        public void PrintInfo()
        {
            Console.WriteLine("Student {0} {1}", name, surname);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {

            //struct student s1;

            Student s1 = new Student();

            s1.name = "Almat";
            s1.surname = "Kudaibergenov";

            s1.PrintInfo();

            Console.ReadKey();
        }
    }
}
