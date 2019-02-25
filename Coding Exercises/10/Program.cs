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
        }
    }
    class Person
    {
        public int Name { get; set; }
        public int Age { get; set; }
        public Person(string _name, string _age)
        {
            Name = _name;
            Age = _age;
        }
        public string GetFullName()
        {
            return $"{Name} {Age}";
        }
    }
    class Teacher : Person
    {
        public int StaffLoginName { get; set; }

        public Teacher(string _staffLoginName)
        {
            StaffLoginName = _staffLoginName;
        }
    }
    class Student : Person
    {
        public int StudentID { get; set; }
    }
}
