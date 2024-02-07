using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace C_Ep10
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region -- While Loop --

            /*
            Console.WriteLine("(While Loop)");
            var number = 0;
            while (number <= 5)
            {
                Console.WriteLine(number);
                number++;
            }

            Console.WriteLine(); 

            Console.WriteLine("(While Loop with User Input)");
            Console.Write("Count numbers to (Limit (5)): ");
            bool Correct = false;
            var userNum = Convert.ToInt32(Console.ReadLine());

            while (userNum <= 5)
            {
                Console.WriteLine(userNum);
                userNum++;
                Correct = true;
            }
            if (!Correct)
            {
                Console.WriteLine("Your input number was exceeded to 5");
            }

            Console.WriteLine();
            Console.WriteLine("(Reversed While Loop)");
            var number2 = 5;
            while (number2 >= 0) 
            {
                Console.WriteLine(number2);
                number2--;
            }

            Console.WriteLine();

            Console.WriteLine("(While Loop Reversed with User Input)");
            Console.Write("Count numbers from reversed (It will stop at (0)): ");
            bool reversedCorrect = false;    
            var userNumReversed = Convert.ToInt32(Console.ReadLine());  

            while (userNumReversed >= 0)
            {
                Console.WriteLine(userNumReversed);
                userNumReversed--;
                reversedCorrect = true;
            }
            if (!reversedCorrect)
            {
                Console.WriteLine("Invalid number");
            }
            Console.WriteLine();
            */


            #endregion

            #region -- For Loop --
            Console.WriteLine("(For Loop)");

            string[] names = { "Gen", "Philip", "David", "Anna", "Justin", "Sussy", "Levi" };

            for (int i = 0; i < names.Length; i++)
            {
                if (names[i].Equals("Anna"))
                {
                    Console.WriteLine($"I found {names[i]}");
                    break;
                }
                else
                {
                    Console.WriteLine(names[i]);
                }

            }
            Console.WriteLine();
            #endregion

            #region -- Reverse For Loop -- 
            Console.WriteLine();

            Console.WriteLine("(Reversed For Loop)");
            for (int x = names.Length - 1; x >= 0; x--)
            {
                if (names[x].Equals("Sussy"))
                {
                    Console.WriteLine($"I Found {names[x]}");
                    break;
                }
                else
                {
                    Console.WriteLine(names[x]);
                }

            }
            Console.WriteLine();
            #endregion

            #region -- Authentication Simulation --
            /*
            Console.WriteLine("(Authentication Simulation)");

            string[] usernames = { "admin", "Anna", "Sussy" };
            string[] passwords = { "admin123", "hana", "baka" };

            Console.Write("Enter Username: ");
            var inputUsername = Console.ReadLine();
            Console.Write("Enter Password: ");
            var inputPassword = Console.ReadLine();

            bool isSuccessful = false;

            for (var i = 0; i < usernames.Length; i++)
            {
                if (usernames[i].Equals(inputUsername) && passwords[i].Equals(inputPassword))
                {
                    isSuccessful = true;
                    break;
                }
            }

            if (isSuccessful)
            {
                Console.WriteLine($"Welcome, {inputUsername}!");
            }
            else
            {
                Console.WriteLine("Account Not Found!");
            }
            Console.WriteLine();

            */
            #endregion

            #region -- Authentication SimulationV2 --
            Console.WriteLine("(Authentication SimulationV2)");

            string[] userName = { "BankLogin", "Sterling", "ebay44"};
            string[] passWord = { "BankLogin13", "SterlingGmal2024", "ebay.44" };

            Console.Write("Enter Username : ");
            var inputUserIndex = Console.ReadLine();
            Console.Write("Enter Password : ");
            var inputPasswordIndex = Console.ReadLine();
            bool isLogin = false;

            for (int user = 0; user < userName.Length; user++)
            {
                if (inputUserIndex.Equals(userName[user]) && inputPasswordIndex.Equals(passWord[user]))
                //, StringComparison.InvariantCultureIgnoreCase 
                {
                    isLogin = true;
                    Console.WriteLine($"Welcome, {userName[user]}!");
                    break;
                }
            
            }
            if (!isLogin)
            {
                Console.WriteLine("Account Not Found!");
            }
        
 
            #endregion

            Console.ReadLine();
        }
    }
}
