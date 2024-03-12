using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Ep16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region -- Constructors --
            Console.WriteLine("(Constructors)");

            /*
            Product p1 = new Product("Cherry",189.4f);
            Product p2 = new Product("Avocado",124.6f);
            Product p3 = new Product("Orange",80.0f);
            */

            Student s1 = new Student("Gen Exus","Vergara", 3, 'B');

            Student s2 = new Student("Anna", "Kendrick", 4, 'A');

            Student s3 = new Student("Justine", "Timberlake", 2 , 'C');
            #endregion

            Console.ReadLine();
        }
    }
}
