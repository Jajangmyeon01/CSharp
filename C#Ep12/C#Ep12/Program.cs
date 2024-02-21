using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Ep12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region -- 2D Array --
            /*

            // -- 1D Arry --
            string[] users = { "Kate", "Chloe", "Hanz", "Loyd" };

            // -- Length of 1D Array
            Console.WriteLine($"Length of 1D Array :  {users.Length}");

            // -- 2D Arry --
            string[,] names = { { "Gen", "Philip", }, 
                                { "Anna", "Levi" }, 
                                { "Kevin", "John" }, 
                                { "King", "Rex"}
            };
            Console.WriteLine();
            Console.WriteLine($"Normal Printing of an 2D Array : {names[1, 0]}");

            // -- Changing Write Values --
            Console.WriteLine();
            names[3, 0] = "Queen";
            Console.WriteLine($"Array King Changing to Queen in 2D Array: { names[3, 0]}");

            Console.WriteLine();
            // -- GetLength of 2D Array --
            Console.WriteLine($"GetLength of 2D Array : {names.GetLength(0)}");

            #region -- Declaring w/o Values -- 
            string[,] size = new string[4, 2];

            Console.WriteLine();
            #endregion

            #region -- Nested For Loop --

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Loop {i}");

                for (int x = 0; x < 5; x++)
                {
                    Console.WriteLine(x);
               
                }
                Console.WriteLine();
            }
       
            #endregion

            */
            #endregion

            #region -- 2D Array with Nested For Loop --
            int[,] numbers = { { 10, 20,}, 
                               { 30, 40},
                               { 50, 60},
                               { 70, 80} 
            };

            for (int row = 0; row < numbers.GetLength(0); row++)
            {
                for(int col = 0; col < numbers.GetLength(1); col++)
                {
                    Console.WriteLine(numbers[row,col]);
                }
                Console.WriteLine();
            }
            #endregion

            #region -- 2D Array with Foreach Loop --

            var space = 1;

            float[,] grade = { { 95.34f, 90.43f}, 
                               { 85.11f, 80.25f},
                               { 75.88f, 70.73f}, 
                               { 65.66f, 60.48f } 
            }; 

            foreach (float info in grade)
            {
                Console.WriteLine(info);
                // -- Spacing for Foreach of 2D Array --
                if (space % grade.GetLength(1) == 0) Console.WriteLine();
                space++;
            }

         

            #endregion

            Console.ReadLine();
        }
    }
}
