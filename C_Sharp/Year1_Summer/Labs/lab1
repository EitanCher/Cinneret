using System;

namespace Lab_1
{
    class Program
    {       
        static void Main(string[] args)
        {
            /*=====================================================================================
            עבור מערך דו מימדי נתון, יש לייצר מערך חדש שהוא ריבוע קסם של המערך הנתון
            כלומר
            השורה הראשונה כוללת סכום של כל טור
            הטור הראשון הוא סכום השורות
            תא 0,0 הוא סכום האלכסון 
            =====================================================================================*/
            
            int[,] myInput = { { 5, 6, 7 }, { 3, 2, 1 }, { 6, 0, 8 }, { 2, 2, 2 } };
            int[,] myOut = new int[myInput.GetLength(0) + 1, myInput.GetLength(1) + 1];
            int myOverAll = 0;

            for (int row = myInput.GetLength(0) - 1; row >= 0; row--)
            {
                int sum = 0;
                for (int col = myInput.GetLength(1) - 1; col >= 0; col--)
                {
                    int myVal = myInput[row, col];

                    // Put numbers from original array into target array,
                    // Keep first row empty
                    myOut[row+1, col+1] = myVal;

                    // Get sum for each row (first col values):
                    sum += myVal;
                }

                myOut[row+1, 0] = sum;
                myOverAll += sum;
            }

            for (int col = myInput.GetLength(1) - 1; col >= 0; col--)
            {
                // Get sum for each col (first row values):
                int sum = 0;
                for (int row = myInput.GetLength(0) - 1; row >= 0; row--)
                    sum += myInput[row, col];
                
                myOut[0, col+1] = sum;
                myOverAll += sum;
            }

            // Put a sum of all rows and all cols into 0;0 location
            myOut[0, 0] = myOverAll;

            printArray(myInput);
            printArray(myOut);

        }
                
        public static void printArray(int[,] myArr)
        {
            for (int row = 0; row < myArr.GetLength(0); row++)
            {
                for (int col = 0; col < myArr.GetLength(1); col++)
                {
                    Console.Write("--------");
                }
                Console.WriteLine("-");

                for (int col = 0; col < myArr.GetLength(1); col++)
                {
                    Console.Write($"|   {myArr[row, col]}\t");
                }
                Console.WriteLine("|");
            }

            for (int i = 0; i < myArr.GetLength(1); i++)  Console.Write("--------");

            Console.WriteLine("-");
            Console.WriteLine("\n");

        }
    }
}
