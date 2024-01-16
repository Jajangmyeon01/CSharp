using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Ep7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region -- If - Else If - Else Statement --
            /*
            Console.WriteLine("Legal Requirements (Driver License User Input) ");
            int age;
       
            Console.Write("Enter your age : ");
            age = Convert.ToInt32(Console.ReadLine()); 

            if (age <= 3)
            {
                Console.WriteLine("You are a baby please, Drink more Milk...");
            }

            else if (age <= 17 && age < 17)
            {
                Console.WriteLine("You are a kid, You are a " + age );
            }

            else if (age >= 18 && age < 26)
            {
                Console.WriteLine("You are valid to get Student Driver License! You are a " + age + " years old");
            }
            else if (age >= 27 && age < 60) 
            {
                Console.WriteLine("You are valid to get Driver License, You are a " + age + " years old");
            } 
            else if (age >= 60 && age < 100)
            {
                Console.WriteLine("You are old enough, You are a " + age + " years old");
            }
            else
            {
                Console.WriteLine("No person lived of that age...");
            }
            Console.WriteLine();

            */
            #endregion

            #region -- Input Grade using If - Else If - Else Statement and Average --
            /*
            // Input Grade using If - Else If - Else Statement and Average //
            Console.WriteLine("Input Grade using If - Else If - Else Statement and Average ");
            //Highest Honors, High Honors, Satisfactory, incomplete, fail;

            Console.Write(" English Grade : ");
            float English = Convert.ToSingle(Console.ReadLine());
            Console.Write(" Biology Grade : ");
            float Math = Convert.ToSingle(Console.ReadLine());
            Console.Write(" Arts Grade : ");
            float Arts = Convert.ToSingle(Console.ReadLine());
            Console.Write(" Computer Science Grade : ");
            float Comsci = Convert.ToSingle(Console.ReadLine());
            Console.Write(" Politics Grade : ");
            float Politics = Convert.ToSingle(Console.ReadLine());

            float average = (English + Math + Arts + Comsci + Politics) / 5;
            Console.Write("Your Average is : " + average.ToString("F2"));

            float grade = average;

            if (grade >= 90 && grade <= 100)
            {
                Console.WriteLine(" / With Highest Honors");
            }
            else if (grade >= 80 && grade < 90)
            {
                Console.WriteLine(" / With High Honors");
            }
            else if (grade >= 75 && grade < 80)
            {
                Console.WriteLine(" / Satisfactory");
            }
            else if (grade >= 70 && grade < 75)
            {
                Console.WriteLine(" / Incomplete");
            }
            else if (grade >= 60 && grade < 70)
            {
                Console.WriteLine(" / Fail");
            }
            else
            {
                Console.WriteLine(" You are Dropped!...");
            }

            */
            #endregion

            #region -- Nested For Loops --
            Console.WriteLine("(Alcohol Eligibility Checker)");
            Console.Write("What is your age? ");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.Write("Are you a student? Please Type Yes/No... ");
            bool student = Console.ReadLine().Equals("Yes", StringComparison.OrdinalIgnoreCase);

            if (age >= 18 && age < 29)
            {
                if (student)
                {
                    Console.WriteLine("You are a Student, Drink responsibly!");
                }
                else
                {
                    Console.WriteLine("You are not a Student, Drink many as you want!");

                }
            }
            else if (age >= 1 && age < 17)
            {
                Console.WriteLine("Kids don't allowed to Drink!");
            }
            else if (age >= 30 && age < 60)
            {
                Console.WriteLine("You can Drink!");
            }
            else if (age >= 60 && age < 100)
            {
                Console.WriteLine("You are old enough to Drink, but please do so responsibly!");
            }
            else
            {
                Console.WriteLine("Out of Range Age! Please enter an age between 1 and 99!");
            }
            #endregion

            #region -- Equals Method -- 

            Console.Write("Enter Password: ");
            string pass = Console.ReadLine();

            if(pass == "admin123")
            {
                Console.WriteLine("Welcome User!");
            }
            else
            {
                Console.WriteLine("Access Denied!");
            }

            #endregion



            Console.ReadLine();
        }
    }
}
