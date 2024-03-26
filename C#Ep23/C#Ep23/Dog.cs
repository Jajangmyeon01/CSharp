using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Ep23
{
    internal class Dog : IAnimal, ILandAnimal
    {
        public void makeSound()
        {
            Console.WriteLine("Arf Arf!");
        }
        public void sleep()
        {
            Console.WriteLine("The Dog is sleeping!");
        }
        public void walk()
        {
            Console.WriteLine("The Dog is walking!");
        }
     
    }
}
