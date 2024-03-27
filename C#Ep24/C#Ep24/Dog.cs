using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Ep24
{
    internal class Dog : Animal
    {
        public override void makeSound()
        {
            Console.WriteLine("Arf Arf!");
        }
        public void dig()
        {
            Console.WriteLine("The dog is digging!");
        }
    }
}
