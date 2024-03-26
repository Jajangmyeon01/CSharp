using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Ep23
{
    internal class Bird : ILandAnimal, IAirAnimal
    {
        public void walk()
        {
            Console.WriteLine("The Bird is walking!");
        }
        public void fly()
        {
            Console.WriteLine("The Bird is flying!");
        }
        public void makeSound()
        {
            Console.WriteLine("Tweet Tweet!");
        }
    }
}
