using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex4
{

    class Student
    {

        private string name;
        private string surname;

        public Student(string name, string surname)
        {
            this.name = name;
            this.surname = surname;
        }

        public void PrintInfo()
        {
            Console.WriteLine("Student {0} {1}", name, surname);
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student("Almat", "Kudaibergenov");
            s.PrintInfo();

            Console.ReadKey();
        }
    }
}
