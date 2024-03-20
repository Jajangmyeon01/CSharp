using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Ep20
{
    internal class Person
    {
        // -- Derived Class/Parent -- //
        public string name { get; set; }
        public string gender { get; set; } 
        public int age { get; set; }

        // -- Constructor -- // 
        public Person(string name, string gender, int age) 
        {
            this.name = name;
            this.gender = gender;   
            this.age = age;
        }


       public void introduceSelf ()
        {
            Console.WriteLine($"Name : {name}");
            Console.WriteLine($"Gender : {gender}");
            Console.WriteLine($"Age : {age}");
           
        }
    }
}
