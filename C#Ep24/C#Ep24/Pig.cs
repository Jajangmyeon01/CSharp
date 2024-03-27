using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Ep24
{
    internal class Pig : Animal
    {
        public override void makeSound()
        {
            Console.WriteLine("Oink Oink!");
        }
    }
}
