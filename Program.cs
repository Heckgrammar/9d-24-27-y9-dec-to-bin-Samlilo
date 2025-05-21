using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Y9_DEC_TO_BIN_SKELETON
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //MAIN CHALLENGE: WRITE A PROGRAM TO CONVERT ANY INTEGER TO ITS EQUIVALENT BINARY NUMBER
            //WRITE A CALL TO YOUR NUMBER CONVERSION FUNCTION HERE
            Conversion();
        }
        static void Conversion()
        {
            int Num = 0;
            string Binary = "";
            Console.WriteLine("What number do you want to convert?");
            Num = Convert.ToInt32(Console.ReadLine());
            while (Num >= 1)
            {
                if (Num % 2 == 1)
                {
                    Binary = "1" + Binary;
                }
                else
                {
                    Binary = "0" + Binary;
                }
                Num = Num / 2;
            }
            Console.WriteLine(Binary);
        }


        // LET'S USE THE 'STRUCTURED APPROACH' TO PROGRAMMING...A QUICK INTRODUCTION TO SUBBROUTINES(functions and procedures)...a.k.a. 'methods' in C#
        //static void means the function will not return a value so it does not need a data type 
        //...this function DOES return a value so the method must have a data type
        //static string numberConversion(int number, int numberbase)
        //{
        //    //CODE GOES HERE

        //    return result; //REMOVE THE RED LINE!
    }
}

