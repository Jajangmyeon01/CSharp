using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace C_Ep22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region -- Abstraction --
            Console.WriteLine("(Abstraction)");

            Animal dog1 = new Dog("Siberian Husky", "Siberian Husky is a medium-sized working sled dog breed", 1, 800.00f);
            Animal cat1 = new Cat("Siamese Cat", "The Siamese cat is one of the first distinctly recognised breeds of Asian cat", 2, 250.00f);

            dog1.makeSound();
            dog1.eat();
            

            Console.WriteLine();

            cat1.makeSound();
            cat1.eat(); 

            #endregion

            Console.ReadLine();
        }
    }
}
