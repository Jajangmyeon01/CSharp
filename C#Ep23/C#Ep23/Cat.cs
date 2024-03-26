using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Ep23
{
    internal class Cat : IAnimal, ILandAnimal
    {
        public void makeSound()
        {
            Console.WriteLine("Meow Meow!");
        }
        public void sleep()
        {
            Console.WriteLine("The Cat is sleeping!");
        }
        public void walk()
        {
            Console.WriteLine("The Cat is walking!");
        }
    }
}
