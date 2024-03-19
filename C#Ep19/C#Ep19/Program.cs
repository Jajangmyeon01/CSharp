using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Ep19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region -- Overloading Constructors --
            Console.WriteLine("(Overloading Constructors)");

            Product Prod1 = new Product(1, "Banana", "Banana is a tropical fruit that has a thick yellow or red skin and a soft edible flesh.", 10, 62.62f);
            Product Prod2 = new Product(2, "Mango", 20, 87.40f);
            Product Prod3 = new Product("Apple", "An apple is a fruit of the domesticated tree Malus domestica, which belongs to the rose family.", 15, 50.12f);

            Console.WriteLine(Prod1);
            Console.WriteLine();
            Console.WriteLine(Prod2);
            Console.WriteLine();
            Console.WriteLine(Prod3);
            #endregion

            Console.ReadLine();
        }
    }
}
