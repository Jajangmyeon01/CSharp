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
            #region Switch Statements {Char/String} --
            /*
            Console.WriteLine("Switch Statements {Char/String}");
            // Switch Statements using Char or String //

            Console.Write("Enter Grade or Name : ");
            var input = Console.ReadLine();

            if (input.Length == 1)
            {
                char grade = char.ToUpper(input[0]); 
                switch (grade)
                {
                    case 'A':
                        Console.WriteLine($"Outstanding! Grade of {grade}");
                        break;
                    case 'B':
                        Console.WriteLine($"Very Good! Grade of {grade}");
                        break;
                    case 'C':
                        Console.WriteLine($"Good! Grade of {grade} ");
                        break;
                    default:
                        Console.WriteLine("Please Type Grades {A}, {B}, {C}");
                        break;
                }
            }
            else
            {
                switch (input.ToLower()) 
                {
                    case "gen":
                        Console.WriteLine($"You are {input}");
                        break;
                    case "philip":
                        Console.WriteLine($"You are {input}");
                        break;
                    case "anna":
                        Console.WriteLine($"You are {input}");
                        break;
                    default:
                        Console.WriteLine("Please Type Names {Gen}, {Philip}, {Anna}");
                        break;
                }
            }
         
            Console.WriteLine();
   
            #endregion
          
            #region -- Switch Statements {String} --
            /
            Console.WriteLine("Switch Statements {String}");
            // Switch Statements using String //

            Console.Write("Enter Name : ");
            var names = (Console.ReadLine());
            switch (names.ToLower())
            {
                case "gen":
                    Console.WriteLine($"You are {names}");
                    break;
                case "philip":
                    Console.WriteLine($"You are {names}");
                    break;
                case "anna":
                    Console.WriteLine($"You are {names}");
                    break;
                default:
                    Console.WriteLine("Please Type Names {Gen}, {Philip}, {Anna}");
                    break;
            }
            Console.WriteLine();
            */
            #endregion

            #region -- Switch Statements {int} --
            /*
            Console.WriteLine("Switch Statements {int}");
            // Switch Statements using Int //

            Console.Write("Enter Number : ");
            var numbers = Convert.ToInt32(Console.ReadLine());
            switch (numbers)
            {
                case 1:
                    Console.WriteLine($"This is case {numbers}");
                    break;
                case 2:
                    Console.WriteLine($"This is case {numbers}");
                    break; 
                case 3:
                    Console.WriteLine($"This is case {numbers}");
                    break;
                default:
                    Console.WriteLine("Please Type Numbers {1}, {2}, {3}");
                    break;
            }
            Console.WriteLine();
            */
            #endregion

            #region -- Date Formatter --
            Console.WriteLine("Date Formatter");
            // Date Formatter //

            Console.Write("Enter number of a Month : ");
            var month = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Date : ");
            var date = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Year : ");
            var year = Convert.ToInt32(Console.ReadLine());

            string dateString = $"{month}/{date}/{year}";

            string format = "M/d/yyyy";

            DateTime parsedDate;

            bool isValidDate = DateTime.TryParseExact(dateString, format, CultureInfo.InvariantCulture, DateTimeStyles.None, out parsedDate);

            if (isValidDate)
            {
       
                switch (month)
                {
                    case 1:
                        Console.WriteLine($"January {date}, {year}");
                        break;
                    case 2:
                        Console.WriteLine($"February {date}, {year}");
                        break;
                    case 3:
                        Console.WriteLine($"March {date}, {year}");
                        break;
                    case 4:
                        Console.WriteLine($"April {date}, {year}");
                        break;
                    case 5:
                        Console.WriteLine($"May {date}, {year}");
                        break;
                    case 6:
                        Console.WriteLine($"June {date}, {year}");
                        break;
                    case 7:
                        Console.WriteLine($"July {date}, {year}");
                        break;
                    case 8:
                        Console.WriteLine($"August {date}, {year}");
                        break;
                    case 9:
                        Console.WriteLine($"September {date}, {year}");
                        break;
                    case 10:
                        Console.WriteLine($"October {date}, {year}");
                        break;
                    case 11:
                        Console.WriteLine($"November {date}, {year}");
                        break;
                    case 12:
                        Console.WriteLine($"December {date}, {year}");
                        break;
                    default:
                        Console.WriteLine($"Invalid Month");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Invalid Month/Date, Month must not exceed 12 and the Date must not exceed 31");
            }

            #endregion

            Console.ReadLine();

        }
    }
}
