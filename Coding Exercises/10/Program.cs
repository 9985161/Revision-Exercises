using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10
{
    class Program
    {
        static void Main(string[] args)
        {
            Teacher one = new Teacher("", 0, "");
            one.Name = "Teacher 1";
            one.Age = 30;
            one.StaffLoginName = "Teacherone1";
            Console.WriteLine($"{one.GetFullName()} {one.StaffLoginName}");
            Teacher two = new Teacher("", 0, "");
            two.Name = "Teacher two";
            two.Age = 35;
            two.StaffLoginName = "Teacher2two";
            Console.WriteLine($"{two.GetFullName()} {two.StaffLoginName}");
            Teacher three = new Teacher("", 0, "");
            three.Name = "Teacher three";
            three.Age = 90;
            three.StaffLoginName = "Teacher3three";
            Console.WriteLine($"{three.GetFullName()} {three.StaffLoginName}");
            Student stu1 = new Student("", 0, 0);
            stu1.Name = "Student one";
            stu1.Age = 20;
            stu1.StudentsID = 9985161;
            Console.WriteLine($"{stu1.GetFullName()} {stu1.StudentsID}");
            Console.ReadLine();

        }
    }
    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public Person(string _name, int _age)
        {
            Name = _name;
            Age = 0;
        }
        public string GetFullName()
        {
            return $"{Name} {Age}";
        }
    }
    class Teacher : Person
    {
        public string StaffLoginName { get; set; }

        public Teacher(string _name, int _age, string _staffLoginName) : base (_name, _age)
        {
            StaffLoginName = _staffLoginName;
        }
    }
    class Student : Person
    {
        public int StudentsID { get; set; }
        public Student(string _name, int _age, int _stuID) : base(_name, _age)
        {
            StudentsID = _stuID;
        }
    }
}
