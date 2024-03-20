using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Ep20
{
    internal class Toddler : Person
    {
        // -- Base Class/Child -- //

        public int money { get; set; }

        // -- Constructor with Base keyword -- // 
        public Toddler(string name, string gender, int age, int money) : base(name, gender, age)
        {
            this.money = money; 
        }
 
        public void actress()
        {
            Console.WriteLine("I'm Actress!");
        }
        public void actor()
        {
            Console.WriteLine("I'm Actor!");
        }
        // -- Overloading Constructors -- //
        public void introduceSelf()
        {
            base.introduceSelf();
            Console.WriteLine($"Net Worth : {money}");
        }
     
    }
}
