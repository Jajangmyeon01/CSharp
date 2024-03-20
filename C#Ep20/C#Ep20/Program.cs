using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Ep20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region -- Inheritance --
            Console.WriteLine("(Inheritance)");

            #region -- Derived Class --

            // -- Instantiation of Derived Class -- //
            #region --  (Does not have  a Constructor on Derived Class) --
            /* Person person1 = new Person();
            person1.name = "Gen";
            person1.gender = "M";
            person1.age = 21;

            person1.introduceSelf();
            */
            #endregion

            #region -- With have a Constructor --
            Console.WriteLine("(Derived Class/Parent)");
            Person person1 = new Person("Gen", "M", 19);
            person1.introduceSelf();

            #endregion

            Console.WriteLine();

            #region -- Base Class --

            // -- Instantiation of Base Class -- //

            #region --  (Does not have  a Constructor on Base Class ) --
            /*
            Toddler toddler1 = new Toddler();
            toddler1.name = "Anna";
            toddler1.gender = "F";
            toddler1.age = 38;

            toddler1.introduceSelf();
            toddler1.actress();
            */

            #endregion

            #region -- With have a Constructor --
            Console.WriteLine("(Base Class/Childs)");

            Toddler toddler1 = new Toddler("Anna","Female", 38, 20000);
            toddler1.introduceSelf();
            Console.WriteLine($"Money : {toddler1.money}");
            toddler1.actress();

            Console.WriteLine();

            #endregion

            Child child1 = new Child("Justin", "M", 43, 250000, "Sleeping");
            child1.introduceSelf();
            Console.WriteLine($"Money : {child1.money}");
            Console.WriteLine($"Hobby : {child1.Hobby}");
            child1.actor();
            child1.Reading();

            Console.WriteLine();

            #region -- Enemy Class --

            BasicEnemy enemy1 = new BasicEnemy("BaldMan", 100, 10);
            enemy1.attack();
            enemy1.walking();
            enemy1.dead();

            FlyingEnemy enemy2 = new FlyingEnemy("MosquitoFly", 100, 15);
            enemy2.attack();
            enemy2.flying();
            enemy2.dead();

            #endregion


            #endregion

            #endregion

            #endregion
            Console.ReadLine();
        }
    }
}
