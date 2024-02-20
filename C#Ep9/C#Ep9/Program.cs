using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Ep8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region -- While Loops --
            /*
            Console.WriteLine("(While Loops)");
            string[] names = { "Gen", "Philip", "John", "Anna", "Sussy", "Dave" };

            var i = 0;
            while (i < names.Length)
            {
                if (names[i].Equals("Anna"))
                {
                    Console.WriteLine($"We Found : {names[i]}");
                    break;
                }
                else
                    Console.WriteLine($"{names[i]} is not the name we're looking for. ");
                i++;
            }
            */
            Console.WriteLine();
            #endregion
       
            #region -- Do-While Loops --
            /*
            Console.WriteLine("(Do-While Loops)");
            var x = 0;
            do
            {
                Console.WriteLine(x++);
            }
            while (x < 5);
            Console.WriteLine();
            */
            #endregion

            #region -- While Loops using User Input --
            /*
            Console.WriteLine("While Loops using User Input");
            float[] grade = { 75.00f, 80.00f, 85.00f, 90.00f, 95.00f};
            Console.Write("Enter Grade : ");
            var searchGrade = Convert.ToSingle(Console.ReadLine());
            
            var y = 0;
            while (y < grade.Length)
            {
                if (grade[y].Equals(searchGrade))
                {
                    Console.Write($"We Found : {grade[y]}");
                    break;
                }
                else
              
                Console.WriteLine($"{grade[y]} is not grade we're looking for.");
                y++;

         
            }
            */

            #endregion

            Console.WriteLine();

            #region -- Quiz Game w/Lives --
            /*
            Console.WriteLine("(Quiz Game w/Lives)");

            var lives = 3;
            bool answer = false;

            while (lives > 0 && !answer)
            {
                Console.Write("Is Apple Color red (yes/no)? ");
                string userInput = Console.ReadLine();
                Console.WriteLine();

                if (userInput == "yes")
                {
                    Console.WriteLine("Correct!");
                    answer = true;
                }
                else
                {
                    lives--;
                    Console.WriteLine($"Incorrect!  You have {lives} reamaining ");
                }
         
            }
            if (answer)
            {
                Console.WriteLine("You Won!");
            }
            else
            {
                Console.WriteLine("You lost. You have no lives remaining ");
            }
            */
            #endregion

            #region -- Quiz Game w/Lives --
            var lives2 = 5;
            var answer2 = "Elon Musk";

            while (lives2 > 0)
            {
                Console.Write("Who's the richest person in the world? ");
                string userInput2 = (Console.ReadLine());
                Console.WriteLine();

                if  (String.Equals(userInput2, answer2, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("Correct!");
                    break;
                }
                else
                {
                    lives2--;
                    Console.WriteLine($"Incorrect! You have {lives2} remaining");
                }
            }
            if (lives2 > 0)
            {
                Console.WriteLine("You Won!");
            }
            else
            {
                Console.WriteLine($"You Lost! You have {lives2} remaining");
            }

            #endregion
            Console.ReadLine();
        }
    }
}
