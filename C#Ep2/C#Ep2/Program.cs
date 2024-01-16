using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace C_Ep2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name1 = "Gen \nExus \nVergara",
                   name2 = "Alexander \nGraham \nCruz",
                   name3 = "Maria \nSeraphine \nYla",
                   name4 = "Philip \nLouie \nWedgener",
                   name5 = "Bobby \nVextar \nJoy";

            //Before Printing //
            char gender = 'F';
            int age = 20;
            bool istall = false;
            float average = 88.23f;
            double grade = 98.26;

            //After Printing, Reassigning Variables and Identifier // 
            name1 = "gen gen";
            gender = 'M';
            age = 21;
            istall = true;
            average = 90.88f;
            grade = 95.55;

            Console.WriteLine("My name is : " + name1);
            Console.WriteLine("My age is : " + age);
            Console.WriteLine("My gender is : " + gender);
            Console.WriteLine("Is " + name1 + " is tall? " + istall);
            Console.WriteLine("My average is : " + average);
            Console.WriteLine("My grade is : " + grade);

            Console.WriteLine();
            Console.WriteLine("Challenge Practice:");
            //Challenge Practice //
            string myName;
            int myAge;
            double myGPA;
            char myGender;

            myName = "Gen Exus Vergara";
            myAge = 21;
            myGPA = 98.56;
            myGender = 'M';

            Console.WriteLine("Normal Print");
            //Normal Print //
            Console.WriteLine("Hi! My name is : " + myName);
            Console.WriteLine("I'am : " + myAge + " Years Old.");
            Console.WriteLine("My GPA is : " + myGPA);
            Console.WriteLine("My Gender is : " + myGender);

            Console.WriteLine();
            Console.WriteLine("Print using Backslash(/n)");
            //Print including Backslash(/n) //
            Console.WriteLine($"Hi! My name is " + (myName) + ",\n" + "I'am " + (myAge) + " Years Old" + ",\n" + "My GPA is " + (myGPA) + ",\n" + "My Gender is " + (myGender) + ",\n" );

            Console.WriteLine("One line Print only");
            //Only One line Print only //
            Console.WriteLine($"Hi! My name is " + (myName) + "," + " I'am " + (myAge) + " Years Old" + "," + " My GPA is " + (myGPA) + "," + " My Gender is " + (myGender) + ".");





            Console.ReadLine();
        }
    }
}
