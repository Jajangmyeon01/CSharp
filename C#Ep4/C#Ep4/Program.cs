using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Ep4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region -- Implicit Casting (char -> int -> long -> float -> double) --

            #region -- Char to all dataTypes 
            /*
            Console.WriteLine("(Char to Int)");
            char myChar1 = 'A';
            int asciiCode1 = myChar1;
            Console.WriteLine("Char : " + myChar1);
            Console.WriteLine("Int : " + asciiCode1);
            Console.WriteLine();

            Console.WriteLine("(Char to Long)");
            char myChar2 = 'B';
            long asciicode2 = myChar2;
            Console.WriteLine("Char : " + myChar2);
            Console.WriteLine("Long : " + asciicode2);
            Console.WriteLine();

            Console.WriteLine("(Char to Float)");
            char myChar3 = 'C';
            float asciiCode3 = myChar3;
            Console.WriteLine("Char : " + myChar3);
            Console.WriteLine("Float : " + asciiCode3);
            Console.WriteLine();

            Console.WriteLine("(Char to Double)");
            char myChar4 = 'D';
            float asciiCode4 = myChar4;
            Console.WriteLine("Char : " + myChar4);
            Console.WriteLine("Double : " + asciiCode4);
            Console.WriteLine();
            */
            #endregion

            #region -- Int to all dataTypes -- 
            /*
            Console.WriteLine("Int to Char");
            int myInt1 = 10;
            char myChar12 = 'A';
            Console.WriteLine("Int : " + myInt1);
            Console.WriteLine("Char : " + myChar12);
            Console.WriteLine();

            Console.WriteLine("Int to Long");
            int myInt2 = 20;
            long myLong2 = myInt2;
            Console.WriteLine("Int : " + myInt2);
            Console.WriteLine("Long : " + myLong2);
            Console.WriteLine();
          
            Console.WriteLine("Int to Float");
            int myInt3 = 40;
            float myFloat3 = myInt3;
            Console.WriteLine("Int : " + myInt3);
            Console.WriteLine("Float : " + myFloat3);
            Console.WriteLine();

            Console.WriteLine("(Int to Double)");
            int myInt4 = 50;
            double myDouble4 = myInt4;
            Console.WriteLine("Int : " + myInt4);
            Console.WriteLine("Double : " + myDouble4);
            Console.WriteLine();
            */
            #endregion

            #region -- Long to all dataTypes --
            /*
            Console.WriteLine("Int to Char");
            int myInt1 = 30;
            char myChar12 = 'E';
            Console.WriteLine("Int : " + myInt1);
            Console.WriteLine("Char : " + myChar12);
            Console.WriteLine();

            Console.WriteLine("Int to Long");
            int myInt2 = 60;
            long myLong1 = 'F';
            Console.WriteLine("Int : " + myInt2);
            Console.WriteLine("Long : " + myLong1);
            Console.WriteLine();

            Console.WriteLine("Int to Float");
            int myInt3 = 60;
            float myFloat1 = 'G';
            Console.WriteLine("Int : " + myInt3);
            Console.WriteLine("Float : " + myFloat1);
            Console.WriteLine();

            Console.WriteLine("Int to Double");
            int myInt4 = 60;
            double myDouble1 = 'G';
            Console.WriteLine("Int : " + myInt4);
            Console.WriteLine("Float : " + myDouble1);
            Console.WriteLine();
            */
            #endregion

            #region -- Float to all dataTypes --
            /*
            Console.WriteLine("(Float to Char)");
            float myFloat2 = 30.41f;
            char myChar13 = 'H';
            Console.WriteLine("Float : " + myFloat2);
            Console.WriteLine("Char : " + myChar13);
            Console.WriteLine();

            Console.WriteLine("(Float to Int)");
            float myFloat3 = 30.21f;
            int myInt4 = 100;
            Console.WriteLine("Float : " + myFloat3);
            Console.WriteLine("Int : " + myInt4);
            Console.WriteLine();

            Console.WriteLine("(Float to Long)");
            float myFloat4 = 50.55f;
            long myLong2 = 200;
            Console.WriteLine("Float : " + myFloat4);
            Console.WriteLine("Long : " + myLong2);
            Console.WriteLine();

            Console.WriteLine("(Float to Double)");
            float myFloat12 = 44.55f;
            double myDouble21 = myFloat12;
            Console.WriteLine("Float : " + myFloat12);
            Console.WriteLine("Double : " + myDouble21);
            Console.WriteLine();
             */
            #endregion

            #region -- Double to all dataTypes --
            /*
            Console.WriteLine("(Double to Char)");
            double myDouble22 = 50.1;
            char myChar14 = 'I';
            Console.WriteLine("Double : " + myDouble22);
            Console.WriteLine("Char : " + myChar14);
            Console.WriteLine();

            Console.WriteLine("(Double to Int)");
            double myDouble23 = 30.2;
            int myInt4 = 100;
            Console.WriteLine("Float : " + myDouble23);
            Console.WriteLine("Int : " + myInt4);
            Console.WriteLine();

            Console.WriteLine("(Double to Float)");
            double myDouble24 = 88.9;
            float myLong2 = 20.99f;
            Console.WriteLine("Float : " + myDouble24);
            Console.WriteLine("Long : " + myLong2);
            Console.WriteLine();
            */
            #endregion

            #endregion

            #region -- Explicit Casting (double -> float -> long -> int -> char) --
            /*
            double myDouble6 = 28.55;
            int myInt6 = (int) myDouble6;

            int asciiCode1 = 21;
            char myChar2 = (char) asciiCode1;

            Console.WriteLine(myChar2);

            double myDouble2 = 250.12;
            int x = (int) myDouble2;

            Console.WriteLine(x);
            */
            #endregion

            #region -- Conversion Methods -- 

            Console.WriteLine("(Convert string to Int)");
            string a = "5";
            string b = "10";

            int num1 = Convert.ToInt32(a);
            int num2 = Convert.ToInt32(a);
            Console.WriteLine("String Value : " + a + b);
            Console.WriteLine("Int Value : " + num1 + num2);
            Console.WriteLine();

            Console.WriteLine("(Convert Int to String)");
            int num3 = 77;
            int num4 = 88;

            string sample1 = Convert.ToString(num3);
            string sample2 = Convert.ToString(num4);
            Console.WriteLine("String Value : " + sample1 + sample2);
            Console.WriteLine("Int Value : " + (num3 + num4));
            Console.WriteLine();

            Console.WriteLine("(Convert string to Float)");
            string c = "15.55";
            string d = "20.20";

            float num5 = Convert.ToSingle(c);
            float num6 = Convert.ToSingle(d);
            Console.WriteLine("String Value : " + c + d);
            Console.WriteLine("Float Value : " + (num5 + num6));
            Console.WriteLine();

            Console.WriteLine("(Convert Float to String)");
            float e = 25.50f;
            float f = 30.88f; 
            string num7 = Convert.ToString(e);
            string num8 = Convert.ToString(f);
            Console.WriteLine("Float Value : " + (e + f));
            Console.WriteLine("String Value : " + num7 + num8);
            Console.WriteLine();

            Console.WriteLine("(Convert String to Double)");
            string g = "35.1";
            string h = "40.1";
            double num9 = Convert.ToDouble(g);
            double num10 = Convert.ToDouble(h);
            Console.WriteLine("String Value : " + g + h);
            Console.WriteLine("Double Value : " + (num9 + num10));
            Console.WriteLine();

            Console.WriteLine("(Convert Double to String)");
            double myDouble1 = 45.6;
            double myDouble2 = 50.9;
            string num11 = Convert.ToString(myDouble1);
            string num12 = Convert.ToString(myDouble2);
            Console.WriteLine("Double Value : " + (myDouble1 + myDouble2));
            Console.WriteLine("String Value : " + num11 + num12);
            Console.WriteLine();

            Console.WriteLine("(Convert string to Double using User Input)");
            Console.Write("Enter first number : ");
            string k = Console.ReadLine();
            Console.Write("Enter second number : ");
            string l = Console.ReadLine();

            double num13 = Convert.ToDouble(g);
            double num14 = Convert.ToDouble(h);
            Console.WriteLine("String Value : " + k + l);
            Console.WriteLine("Double Value : " + (num13 + num14));
            Console.WriteLine();

            int x = Convert.ToInt32(Console.ReadLine());
            #endregion


            Console.ReadLine();
        }
    }
}
