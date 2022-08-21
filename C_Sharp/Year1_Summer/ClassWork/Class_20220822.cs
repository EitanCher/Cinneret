using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*==========================================================
            // א. לכתוב פעולה המקבלת מספר ומחזירה את סכום הספרות שלו
            // ב. לכתוב פעולה המקבל מערך ובעזרת הפעולה מסעיף א מוצאת 
            // את סכום הספרות המקסימלי שיש במערך ומחזירה אותו כנתון
            // ג. לכתוב תכנית המגדירה מערך ובעזרת הפועלה מסעיף ב מדפיסה 
            // את כל איברי המערך כאשר ליד המספרים בעלי סכום הספרות המקסימלי יש גם *
            ===========================================================*/
            
            ex(1);
        }
        
        
        static void ex1()
        {
            int[] myArr = { 1, 2, 445, 9 };
            int maxVal = getMax(myArr);

            // C:
            for (int i = 0; i < myArr.Length; i++)
            {
                if (getSum(myArr[i]) == getMax(myArr))
                {
                    Console.WriteLine($"{myArr[i]} *");
                }
                else
                {
                    Console.WriteLine($"{myArr[i]} ");
                }
            }
        }

        // B: Get an array and find its max sum of digits, using #A 
        public static int getMax(int[] myInputArray)
        {
            int myMax = getSum(myInputArray[0]);
            for (int i = 1; i < myInputArray.Length; i++)
                if (getSum(myInputArray[i]) > myMax)
                    myMax = getSum(myInputArray[i]);
            
            return myMax;
        }

        // A: Get a number and calculate sum of its digits:
        public static int getSum(int myInput)
        {
            int myOutput = 0;
            while (myInput != 0)
            {
                myOutput += myInput % 10;
                myInput /= 10;
            }
            return myOutput;
        }
    }
}
