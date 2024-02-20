using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace C_Ep11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region -- For Loop --
            Console.WriteLine("(For Loop)");
            string[] students = { "Gen", "Philip", "Anna", "Sussy", "Levi"};
            for (int i = 0; i< students.Length; i++)
            {
                Console.WriteLine(students[i]);
            }

            #endregion
        
            Console.WriteLine();

            #region -- For Each Loop -- 
            Console.WriteLine("(For Each Loop)");

            string[] names = { "10", "Philip", "Anna", "Sussy", "Levi" };
            Console.Write("Enter name : ");
            var user = Console.ReadLine();

            foreach (string name in names)
                if (user.Equals("Sussy"))
                {
                    Console.WriteLine($"I Found {user}");
                    break;
                }
                else
                {
                    Console.WriteLine($"We not Found! {user}");
                    break;
                }
            Console.WriteLine();
            #endregion

            Console.WriteLine();

            #region -- Array of Integers Summation --
            Console.WriteLine("(Array of Integers Summation)");

            int[] numbers = { 10, 20, 30, 40, 50, 60, 70, 80 };
            int total = 0;
            foreach (var num in numbers)
                {      
                     total += num;
                }
            Console.WriteLine($"Total Sum : {total}");

            #endregion

            Console.ReadLine();
        }
    }
}
