using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Ep24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region -- Array of Objects --
            Console.WriteLine("(Array of Objects)");

            Employee[] employees = new Employee[4];
            employees[0] = new Employee("Gen", "Vergara", 21, 5000.00, "Student");
            employees[1] = new Employee("Anna", "Kendrick", 38, 100000.00, "Actress");

            employees[0].introduceSelf();
            employees[1].introduceSelf();

            #region -- Using foreach Loop --
            /*
            foreach (Employee employeeInfo in employees)
            {
                employeeInfo.introduceSelf();
            }
            */
            #endregion

            #endregion

            #region -- Polymorphism --

            Animal[] animals = new Animal[5];
            animals[0] = new Pig();
            animals[1] = new Dog();

            #region -- Using For Loop --
            /*
            for(int i = 0; i < animals.Length; i++)
            {
                animals[i].makeSound();
            }
            */
            #endregion

            #endregion

            Console.ReadLine();
        }

    }
}
