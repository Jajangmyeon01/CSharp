using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Ep18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region -- Encapsulation --
            /*
            Console.WriteLine("(Encapsulation)");

            User p = new User(999, "Gen", "Vergara", 21);

            Console.WriteLine(p.FullName);


         
            p.UserID = 1001;
            Console.WriteLine(p.UserID);
            */

            #endregion

            User student = new User("Gen", "genexus01", "genexusvergara01@gmail.com", 1940);
      
            Console.ReadLine();
        }
    }
}

