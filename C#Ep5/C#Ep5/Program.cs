using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Ep5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region -- Arithmetic Operators --
            int a = 20;
            int b = 30;

            int sum = a + b;
            int diff = a - b;
            int prod = a * b;
            int quo = a / b;
            int remainder = a % b;

            Console.WriteLine("Sum : " + sum);
            Console.WriteLine("Difference : " + diff);
            Console.WriteLine("Product : " + prod);
            Console.WriteLine("Quotient : " + quo);
            Console.WriteLine("Remainder : " + remainder);

            float c = 10.24f;
            float d = 20.52f;
            float add = c + d;

            Console.WriteLine("Sum of Float Value : " + add);

            int number = 6;

            number++;
            Console.WriteLine(number);

            float num1 = 20;
            float num2 = 40;

            float mid = (num1 + num2) / 2;
            Console.WriteLine(mid);

            int sample1 = 8;
            int sample2 = 5;
            
            //Long// 
            int sample5 = sample1 + sample2;
            //Short//
            sample2 *= sample1;

            Console.WriteLine(sample5);
            Console.WriteLine(sample2);
            Console.WriteLine();
            #endregion

            #region -- Challenge Average Calculator --

            Console.WriteLine("Instant Compute Grade");
            float English = 95.4f, Math = 92.8f, Science = 93.5f, Animation = 98.9f, Average;
            Console.WriteLine("English   : " + English);
            Console.WriteLine("Math      : " + Math);
            Console.WriteLine("Science   : " + Science);
            Console.WriteLine("Animation : " + Animation);

            Average = (English + Math + Science + Animation) / 4; 
            Console.WriteLine("Average   : " + Average);
            Console.WriteLine();

            Console.WriteLine("Compute using User Input");
            Console.Write("Enter English Grade, Please incluce a 2 Decimal on it   : ");
            English = Convert.ToSingle(Console.ReadLine());
            Console.Write("Enter Math Grade, Please include a 2 Decimal on it      : ");
            Math = Convert.ToSingle(Console.ReadLine());
            Console.Write("Enter Science Grade, Please include a 2 Decimal on it   : ");
            Science = Convert.ToSingle(Console.ReadLine());
            Console.Write("Enter Animation Grade, Please include a 2 Decimal on it : ");
            Animation = Convert.ToSingle(Console.ReadLine());

           float average = (English + Math + Science + Animation) / 4;
            Console.WriteLine("Average : " + average.ToString("F2")); 

            #endregion


            Console.ReadLine();
        }
    }
}
