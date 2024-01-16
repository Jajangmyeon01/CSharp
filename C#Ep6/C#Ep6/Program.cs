
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Ep6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region -- Array of all DataType's --
            //Array of all DataType's 
            /*
            string[] names = { "Gen", "Philip", "Anna" };

            int[] numbers = { 10, 20, 30, 40, 50 };

            long[] longNum = { 100, 200, 300, 400, 500 };

            char[] letters = { 'A', 'B', 'C', 'D', 'E' };

            float[] floatNum = { 70.34f, 80.56f, 90.67f, 95.32f };

            double[] doubleNum = { 49.3, 53.6, 73.2, 93.2 };

            bool[] boolIsTrueOrFalse = { false, true };
            */
            Console.WriteLine();
            #endregion

            #region -- Instantion --
            //Instantiation//
            /*
            Console.WriteLine("Instatiation");
            string[] names2 = { "Gen", "Philip", "Anna", "Kevin" };

            int[] numbers2 = { 1, 2, 3, 4, 5 };

            long[] longNum2 = { 10, 20, 30, 40, 50 };

            char[] letters2 = { 'A', 'B', 'C', 'D' };

            float[] floatNum2 = { 99.34f, 84.45f, 83.56f, 91.77f };

            double[] doubleNum2 = { 14.2, 24.8, 26.8, 81.3 };

            bool[] boolIsTrueOrFalse2 = { true, false };

            Console.WriteLine(names2[0]);
            Console.WriteLine(numbers2[1]);
            Console.WriteLine(longNum2[3]);
            Console.WriteLine(letters2[3]);
            Console.WriteLine(floatNum2[2]);
            Console.WriteLine(doubleNum2[1]);
            Console.WriteLine(boolIsTrueOrFalse2[0]);
            Console.WriteLine();
            */
            #endregion

            #region -- Changing in a Index --
            //Changing Value in a Index//
            /*
            Console.WriteLine("Changing Value in a Index");
            names2[0] = "Exus";
            numbers2[1] = 3;
            longNum2[2] = 40;
            letters2[3] = 'C';
            floatNum2[3] = 88.52f;
            doubleNum2[2] = 42.4;
            boolIsTrueOrFalse2[1] = true && false;

            Console.WriteLine(names2[0]);
            Console.WriteLine(numbers2[1]);
            Console.WriteLine(longNum2[2]);
            Console.WriteLine(letters[3]);
            Console.WriteLine(floatNum2[3]);
            Console.WriteLine(doubleNum2[2]);
            Console.WriteLine(boolIsTrueOrFalse2[1]);
            Console.WriteLine();
            */
            #endregion

            #region -- Array using a User Input -- 
            //Array using a User Input//
            /*
            Console.WriteLine("Array using a User Input");
            Console.Write("Enter your Name: ");
            names2[0] = Console.ReadLine();
            Console.WriteLine("Welcome, " + names2[0]);

            Console.Write("Enter your Favorite Number : ");
            numbers[1] = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Your Favorite Number is, " + numbers[1]);

            Console.Write("Enter any Number : ");
            longNum2[2] = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("You Entered Number, " + longNum2[2]);

            Console.Write("Enter a any Letter : ");
            char letters3 = Console.ReadKey().KeyChar;
            Console.WriteLine("\nYou Entered Letter : " + letters3);

            Console.Write("Enter your Grade: ");
            floatNum2[3] = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Your Grade is, " + floatNum2[3]);

            Console.Write("Enter a  number with a 1 Digit Decimal :");
            doubleNum2[2] = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("You Entered Number, " + doubleNum2[2]);


            bool isValidInput = false;

            do
            {
                Console.Write("Does Earth Round?, (Type True or False) : ");
                string question1 = Console.ReadLine();

                if (bool.TryParse(question1, out bool isTrueOrFalse))
                {

                    Console.WriteLine($"You entered: {isTrueOrFalse}");
                    isValidInput = true;
                }
                else
                {

                    Console.WriteLine("Invalid input. Please enter 'true' or 'false'.");
                }
            } while (!isValidInput);

            */
            #endregion

            #region -- Paired Arrays By Index Challenge --
            // Paired Arrays By Index Challenge //
            Console.WriteLine("Paired Arrays By Index Challenge");
            string[] email = { "genexusvergara09@gmail.com", 
                              "genexusvergara81@gmail.com",
                              "genexusvergara01@gmail.com",
                              "yvennesantos954@gmail.com",
                              "gengenexusvergara@gmail.com" };

            string[] Username = { "Jajangmyeon",
                                  "genexus01",
                                  "genexus81",
                                  "yvenne954",
                                  "gengen"};

            string[] Password = { "azkil456789",
                                  "12345",
                                  "genexus",
                                  "yvenne",
                                  "gengen01" };

            Console.Write("Enter a Number 0-4 : ");
            int index = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Email : " + email[0]);
            Console.WriteLine("Username : " + Username[index]);
            Console.WriteLine("Password : " + Password[index]);
            Console.WriteLine();

            Console.Write("Enter Number 0-4 : ");
            index = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Email : " + email[1]);
            Console.WriteLine("Username : " + Username[index]);
            Console.WriteLine("Password : " + Password[index]);
            Console.WriteLine();

            Console.Write("Enter Number 0-4 : ");
            index = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Email : " + email[index]);
            Console.WriteLine("Username : " + Username[index]);
            Console.WriteLine("Password : " + Password[index]);
            Console.WriteLine();

            Console.Write("Enter Number 0-4 : ");
            index = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Email : " + email[index]);
            Console.WriteLine("Username : " + Username[index]);
            Console.WriteLine("Password : " + Password[index]);
            Console.WriteLine();

            Console.Write("Enter Number 0-4 : ");
            index = Convert.ToInt32( Console.ReadLine());
            Console.WriteLine("Email : " + email[index]);
            Console.WriteLine("Username : " + Username[index]);
            Console.WriteLine("Password : " + Password[index]);
            Console.WriteLine();

            #endregion

            #region -- Bank account --

            Console.WriteLine("**** Welcome to the Simple Bank Login! ****");
            // Welcome to the Simple Bank Login //
            Console.Write("Enter Email : ");
            string enterEmail = Console.ReadLine();

            Console.Write("Enter Password : ");
            string enterPassword = Console.ReadLine();

            bool isLogin = false;

            for (int i = 0; i < email.Length; i++)
            {
                if (enterEmail == email[i] && enterPassword == Password[i])
                {
                    Console.WriteLine("Welcome Back! " + Username[i]);
                    isLogin = true;
                    break;
                }
            }
            if (!isLogin)
            { Console.WriteLine("Invalid email or password, Try Again! ");
            
            }
            

            #endregion

            Console.ReadLine();

        }
    }
}
