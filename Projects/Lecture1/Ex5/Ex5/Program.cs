using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex5
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

    class MasterStudent : Student
    {

        public MasterStudent(string name, string surname): base(name, surname)
        {

        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Student bachelor = new Student("Almat", "Kudaibergenov");
            Student master = new MasterStudent("Bolat", "Turebekov");

            bachelor.PrintInfo();
            master.PrintInfo();


            Console.ReadKey();
        }
    }
}
