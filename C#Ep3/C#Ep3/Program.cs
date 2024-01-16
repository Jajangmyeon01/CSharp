using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace C_Ep3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            #region -- Sample User input ReadLine --
            string name;
            
            Console.Write("Enter your name : ");
            name = Console.ReadLine();
            Console.WriteLine("Your name is : " + name);
            #endregion

            #region -- Sample User input Read only --
            char letter;

            Console.Write("Enter a Letter : ");
            letter = (char)Console.Read();
            Console.WriteLine(letter);
            #endregion

            #region -- Sample User input ReadKey --
            char inputLetter;

            Console.Write("Please again a Letter : ");
            inputLetter = Console.ReadKey().KeyChar;
            Console.WriteLine("\nYou Pressed : " + inputLetter);
            #endregion

            #region -- Sample Dialogue using Readkey --
            Console.WriteLine("You got a Most high Score!");
            Console.ReadKey();
            Console.WriteLine("You got a High Score!");
            Console.ReadKey();
            Console.WriteLine("You got a Average Score!");
            Console.ReadKey();
            Console.WriteLine("You got a Failure Score!");
            Console.ReadKey();
            #endregion
            */

            #region -- Sentence Builder Challenge of User Input --
            string myName, myProvince, myHobby;

            #region -- Enter all Sentence Input then Print it all -- 
            Console.WriteLine("-- Enter all Sentence Input then Print it all -- ");
            Console.WriteLine("Enter your Name, Province and Hobby : ");
            myName = Console.ReadLine();
            myProvince = Console.ReadLine();
            myHobby = Console.ReadLine();
            Console.WriteLine("Your all Information : " + myName + " " + myProvince + " " + myHobby);
            #endregion
            Console.WriteLine();

            #region -- Sentence User Input One By One --
            Console.WriteLine("-- Sentence User Input One By One -- ");
            Console.Write("Enter your name : ");
            myName = Console.ReadLine();
            Console.WriteLine("Your name is : " + myName);

            Console.Write("Enter your Province : ");
            myProvince = Console.ReadLine();
            Console.WriteLine("Your Province is : " + myProvince);

            Console.Write("Enter your Hobby : ");
            myHobby = Console.ReadLine();
            Console.WriteLine("Your Hobby is " + myHobby);
            #endregion
            Console.WriteLine() ;

            #region -- Print all information at once -- 
            Console.WriteLine("-- Print all information at once -- ");
            Console.Write("Enter your name : ");
            myName= Console.ReadLine();

            Console.Write("Enter your Province : ");
            myProvince = Console.ReadLine();

            Console.Write("Enter your Hobby : ");
            myHobby = Console.ReadLine();

            Console.WriteLine("\nYour name is : " + myName);
            Console.WriteLine("Your Province is : " + myProvince);
            Console.WriteLine("Your Hobby is : " + myHobby);
            #endregion
            Console.WriteLine();

            #region -- Print all information at once using ReadKey -- 
            Console.WriteLine("-- Print all information at once using ReadKey -- ");
            Console.Write("Enter your name : ");
            myName = Console.ReadLine();

            Console.Write("Enter your Province : ");
            myProvince = Console.ReadLine();

            Console.Write("Enter your Hobby : ");
            myHobby = Console.ReadLine();

            Console.WriteLine("\nYour name is : " + myName);
            Console.WriteLine("Please Enter...");
            Console.ReadKey(); 
            Console.WriteLine("Your Province is : " + myProvince);
            Console.ReadKey();
            Console.WriteLine("Your Hobby is : " + myHobby);
            Console.ReadKey();
            #endregion
            Console.WriteLine();

            #region -- Pressing Enter to print all Information by using ReadKey --
            Console.WriteLine("Pressing Enter to print all Information by using ReadKey -- ");
            Console.WriteLine(myName);
            Console.ReadKey();
            Console.WriteLine(myProvince);
            Console.ReadKey();
            Console.WriteLine(myHobby);
            Console.ReadKey();


            #endregion
            Console.WriteLine();
            #endregion

            Console.ReadLine();
            Console.Read();
            Console.ReadKey();
        }
    }
}
