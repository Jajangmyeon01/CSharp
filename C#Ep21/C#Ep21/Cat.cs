using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Ep21
{
    internal class Cat : Animal
    {
        // -- Override Modifier -- //
       override public void makeSound()
        {
            Console.WriteLine("Meow Meow!");
        }
    }
}
