using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Ep16
{
    internal class Student
    {
        public string firstName;
        public string lastName;
        public int grade;
        public char section;

        public Student(string firstName, string lastName, int grade, char section)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.grade = grade;
            this.section = section;

            Console.WriteLine();
            Console.WriteLine("Student Created!\n");
            Console.WriteLine($"Full Name: {firstName + " " + lastName + "\nGrade : " + grade +  "\nSection : " + section}");
           
        }
    }
}
