using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Ep24
{
    internal class Employee
    {
        public string firstName {get; set;}
        public string lastName { get; set;}
        public int age { get; set;}
        public double salary { get; set; }
        public string position { get; set; }

        public Employee(string firstNaname, string lastName, int age, double salary, string position)
        {
            this.firstName = firstNaname;
            this.lastName = lastName;
            this.age = age; 
            this.salary = salary;
            this.position = position;
        }
        public void introduceSelf()
        {
            Console.WriteLine($"My name is : {firstName} {lastName}");
        }
    }

}
