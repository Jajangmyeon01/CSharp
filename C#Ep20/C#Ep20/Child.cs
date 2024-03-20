using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Ep20
{
    internal class Child : Toddler
    {
        public string Hobby {get; set;}
        public Child(string name, string gender, int age, int money, string Hobby) : base(name, gender, age, money)
        {
            this.Hobby = Hobby;
        }
        public void Reading()
        {
            Console.WriteLine("I'm Reading!");
        }


    }
}
