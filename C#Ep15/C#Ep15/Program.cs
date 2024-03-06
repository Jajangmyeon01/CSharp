using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Ep15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region -- Object Oriented Programming --

            Console.WriteLine("(OOP_Class1)");

            #region -- Person 1 Class --
            // Class Instantiation //
            Person person1 = new Person();

            // Writing Attributes //
            person1.firstName = "Gen Exus";
            person1.lastName = "Vergara";
            person1.gender = 'M';
            person1.age = 21;

            // Reading Attributes //
            Console.WriteLine($"FullName : {person1.firstName + " " + person1.lastName}");
            Console.WriteLine($"Gender : {person1.gender}");
            Console.WriteLine($"Age {person1.age}");
            Console.WriteLine();
            #endregion

            #region -- Person 2 Class --
            Person person2 = new Person();
            person2.firstName = "Anna";
            person2.lastName = "Kendrick";
            person2.gender = 'F';
            person2.age = 38;

            Console.WriteLine($"FullName : {person2.firstName + " " + person2.lastName}");
            Console.WriteLine($"Gender : {person2.gender}");
            Console.WriteLine($"Age : {person2.age}");
            Console.WriteLine();
            #endregion

            #region -- Person 3 Class -- 
            Person person3 = new Person();
            person3.firstName = "Justin";
            person3.lastName = "Timberlake";
            person3.gender = 'M';
            person3.age = 43;

            Console.WriteLine($"FullName : {person3.firstName + " " + person3.lastName}");
            Console.WriteLine($"Gender : {person3.gender}");
            Console.WriteLine($"Age : {person3.age}");
            Console.WriteLine();
            #endregion

            Console.WriteLine("(OOP_Class2)");
            #region -- Product 1 --
            Product product1 = new Product();
            product1.productName = "Chevrolet Camaro";
            product1.Description = "Chevrolet Camaro is a mid-size American automobile manufactured by Chevrolet, classified as a pony car.";
            product1.price = 4266.888f;
            product1.qty = 1;

            Console.WriteLine($"ProductName : {product1.productName}");
            Console.WriteLine($"Description : {product1.Description}");
            Console.WriteLine($"Price : {product1.price}");
            Console.WriteLine($"Quantity : {product1.qty}");
            Console.WriteLine();
            #endregion

            #region -- Product 2 --
            Product product2 = new Product();
            product2.productName = "Honda Civic Type R";
            product2.Description = "Honda Civic Type R is a series of hot hatchback and sports sedan models, developed and produced by Honda.";
            product2.price = 3870.000f;
            product2.qty = 3;

            Console.WriteLine($"ProductName : {product2.productName}");
            Console.WriteLine($"Description : {product2.Description}");
            Console.WriteLine($"Price : {product2.price}");
            Console.WriteLine($"Quantity : {product2.qty}");
            Console.WriteLine();
            #endregion

            #region -- Product 3 --
            Product product3 = new Product();
            product3.productName = "Ford Mustang";
            product3.Description = "Ford Mustang is a series of American automobiles manufactured by Ford.";
            product3.price = 3499.000f;
            product3.qty = 3;

            Console.WriteLine($"ProductName : {product3.productName}");
            Console.WriteLine($"Description : {product3.Description}");
            Console.WriteLine($"Price : {product3.price}");
            Console.WriteLine($"Quantity : {product3.qty}");
            #endregion







            #endregion

            Console.ReadLine();
        }
    }
}
