using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Ep17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region -- Object Methods --
            Console.WriteLine("(Object Methods)");

            #region -- Instantiation --
            // -- Instantiaon --
            Character c1 = new Character("Gen", "Always be Happy!", 100, 50, 20, "Happy!");
            c1.introduce();
            c1.sayDialog();
            c1.health();
            c1.manaPower();
            c1.level();
            Character c2 = new Character("Anna", "Always be Sad!", 50, 80, 100, "Sad");
            #endregion

            /* -- Calling return type in Main --
            Console.WriteLine(c1.checkStats());
            */
            #endregion
            Console.ReadLine();
        }
    }
}
