using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Ep14
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region -- Classes --

            Console.WriteLine("(Arithmetic)");

            #region -- If you are using only Public Int/String/etc..
            /*
            Arithmetic arith = new Arithmetic();

            arith.add(10, 10);
            arith.sub(30, 10);
            arith.mul(7, 7);
            arith.div(10, 40);
            Console.WriteLine(arith.add(10,10));
            Console.WriteLine(arith.sub(30,10));
            Console.WriteLine(arith.mul(7,7));
            Console.WriteLine(arith.div(10,40));
            */
            #endregion

            #region -- If you are using Public static Int/String/etc..
            Arithmetic.add(10,10);
            Arithmetic.sub(30, 20);
            Arithmetic.mul(7, 7);
            Arithmetic.div(50,30);
            Console.WriteLine(Arithmetic.add(10,10));
            Console.WriteLine(Arithmetic.add(30, 20));
            Console.WriteLine(Arithmetic.add(7, 7));
            Console.WriteLine(Arithmetic.add(50, 30));
            #endregion

            Console.WriteLine();

            Console.WriteLine("(Constants)");
            #region -- If you are using only Public Int/String/etc..
            /*
            Constants cons = new Constants();
            Console.WriteLine(cons.PI);
            Console.WriteLine(cons.GRAVITY);
            */
            #endregion

            #region -- If you are using Public static Int/ String / etc..

            Console.WriteLine(Constants.PI);
            Console.WriteLine(Constants.GRAVITY);
            Console.WriteLine();

            #endregion

            Console.WriteLine("(ReadOnly)");
            #region -- ReadOnly --  
            // Constants = 5;  (Changing variable)
            // Constants = 10; (Changing variable)
            Console.WriteLine(Constants.PI);
            Console.WriteLine(Constants.GRAVITY);

            #endregion 

            Console.ReadLine();
            #endregion
        }
    } 
}
