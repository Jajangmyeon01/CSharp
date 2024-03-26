using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Ep22
{
    internal class Cat : Animal
    {
        public Cat(string name, string Description, int qty, float price) : base(name, Description, qty, price)
        {

        }

        public override void makeSound()
        {
            Console.WriteLine("Meow Meow!");
        }
        public override void eat()
        {
            Console.WriteLine("The Cat is eating!");
        }
    }
}
