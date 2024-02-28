using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace C_Ep13
{
    internal class Program
    {
        // Global Variables
        static string name = "Ely";
        static int age = 22;

        static void Main(string[] args)
        {
            // Main Program //

            #region -- Methods in Main --

            #region -- Local Variables & Global Variables in Main --
            Console.WriteLine("(Local Variables & Global Variables)");
            var name = "Gen";
            var age = 21;

            Console.WriteLine($"My name is {name}");
            Console.WriteLine($"Im {age} years old");
            Console.WriteLine();

            #endregion

            // Accessing Methods //
            Console.WriteLine("(Methods)");
            sayMethod();
            sayMain();
            Console.WriteLine();

            #region -- Parameters in Main --
            // Parameters //
            Console.WriteLine("(Parameters)");

            myNameandAge("Gen", 21);
            sum(7, 7);
            dif(7, 7);
            mul(7, 7);
            div(7, 7);
            #endregion

            #region -- Return Method in Main --
            // Return Method //
            Console.WriteLine("(Return Method)");
            float average = grade(86.64f, 91.52f, 93.23f, 81.16f);
            Console.WriteLine($"Average : " + average.ToString("F2"));
            Console.WriteLine();
            #endregion

            #region -- Overloading Methods in Main--
            // Overloading Method //
            Console.WriteLine("(Overloading Methods)");
            Console.WriteLine("Add Two Numbers : " + addNum(10, 20));
            Console.WriteLine("Add Three Numbers : " + addNum(50, 50, 50));
            Console.WriteLine("Add decimal Numbers : " + addNum(75.43f, 25.73f));
            Console.WriteLine("My Name is " + addNum("Gen, ", "Vergara"));
            Console.WriteLine();
            #endregion

            #region -- Summation of Numbers in Main --
            // Summation of Numbers //
            Console.WriteLine("(Summation of Numbers)");

       
            int[] addNumbers = { 10, 20, 30, 40, 50};

            int sumofall = 0;
            for (int i = 0; i < addNumbers.Length; i++)
            {
               sumofall += addNumbers[i];
            }
            Console.WriteLine($"Total Sum : {sumofall}");
            #endregion

            #endregion


            Console.ReadLine();
        }
        #region -- Methods --
        static void sayMethod()
        {
            Console.WriteLine("Method!");
        }
        static void sayMain()
        {
            Console.WriteLine("Main!");
        }
        #endregion

        #region -- Local Variables --
        static void introduce()
        {
            var name = "Anna";
            var age = 20;
            Console.WriteLine($"My name is {name}");
            Console.WriteLine($"Im {age} years old");

            if (age > 18)
            {
                bool Passed = true;
                Console.WriteLine($"Passed! {Passed}");
                if (name.Equals("Anna"))
                {
                    Console.WriteLine(Passed);
                }
            }
            else if (age < 17)
            {
                bool notPass = false;
                Console.WriteLine($"Not Passed! {notPass}");
            }
    
        }
        #endregion

        #region -- Parameters -- 
        // Parameters //
        static void myNameandAge(string myName, int myAge)
        {
            Console.WriteLine($"My Name is {myName}");
            Console.WriteLine($"My Age is {myAge}");
            Console.WriteLine();
        }
 

        static void sum(int num1, int num2)
        {
            Console.WriteLine($"Addition : {num1 + num2}");
        }
        static void dif(int num1, int num2)
        {
            Console.WriteLine($"Subtraction : {num1 - num2}");
        }
        static void mul(int num1, int num2)
        {
            Console.WriteLine($"Product : {num1 * num2}");
        }
        static void div(int num1, int num2)
        {
            Console.WriteLine($"Quotient : {num1 / num2}");
            Console.WriteLine();
        }
  
        #endregion

        #region -- Return --
        static float grade(float DiscreteGrade, float InfoGrade, float WebDevGrade, float MultimediaGrade)
        {
            return (DiscreteGrade + InfoGrade + WebDevGrade + MultimediaGrade) / 4;

          
        }
        #endregion

        #region -- Overloading Methods --
        static int addNum(int num1, int num2)
        {
            return num1 + num2;
        }
        static int addNum(int num1, int num2, int num3)
        {
            return num1 + num2 + num3;
        }
        static float addNum(float num1, float num2)
        {
            return num1 + num2;
        }
        static string addNum(string firstName, string lastName)
        {
            return firstName + lastName;
        }
        #endregion

        #region -- Comments -- 
        // Single Line Comments
        /* Multi Line Comments */

        #endregion

        #region -- Summation of Numbers --
        static int summation(int num1, int num2, int num3, int num4, int num5)
        {
          
                return num1 + num2 + num3 + num4 + num5;
        }


        #endregion
    }
}
