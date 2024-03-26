using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Ep23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Abstraction (Interfaces)
            Console.WriteLine("(Abstraction (Interfaces))");

            IAnimal dog = new Dog();
            IAnimal cat = new Cat(); 

            // -- Dog/Cat Animals Instantiation -- //
            ILandAnimal dogLand = new Dog();
            ILandAnimal catLand = new Cat();

            // -- Bird Animal Instantiation -- //
            IAirAnimal birdAir = new Bird();
            ILandAnimal birdLand = new Bird();


            // -- This type can only print the output -- //
            #region -- Print For Dog --
            Dog dog1 = new Dog();
            dog1.makeSound();
            dog1.walk();
            dog1.sleep();

            Console.WriteLine();
            #endregion

            #region -- Print For Cat --
            Cat cat1 = new Cat();
            cat1.walk();
            cat1.sleep();
            cat1.makeSound();

            Console.WriteLine();
            #endregion

            #region -- Print For Bird --
            Bird bird1 = new Bird();
            // bird1.walk(); -- It's same results -- //
            // bird1.fly();  -- It's same results -- //

            birdAir.fly();   
            birdLand.walk();
            #endregion

            #endregion

            Console.ReadLine();
        }
    }
}
