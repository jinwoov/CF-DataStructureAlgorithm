using System;

namespace ArrayShift
{
    public class Program
    {

        static void Main(string[] args)
        {

            int[] testArray = new[] { 4, 8, 15, 23, 4 };
            int[] resultArray = InsertShiftArray(testArray, 16);
           foreach (int value in resultArray)
           {
               Console.WriteLine(value);
           }
        }

        public static int[] InsertShiftArray(int[] array, int numberArg)
        {
            // Declaring variables 
            int[] newArray = new int[array.Length+1];
            int ind = 0;
            // Declaring variable that is half of argument array length and converting it to int data type
            decimal halfOfDec = array.Length / 2m;
            halfOfDec = Math.Ceiling(halfOfDec);
            int halfOfArrayLength = Convert.ToInt32(halfOfDec);
            
            // for loop to iterate and instantiate into newArray
            for (int i = 0; i < newArray.Length; i++)
            {
                if (i == halfOfArrayLength)
                {
                    newArray[i] = numberArg;
                    ind--;
                }
                else
                {
                    newArray[i] = array[ind];
                }

                ind++;
            }

            return newArray;
        }

        public static int[] StretchGoal(int[] array)
        {

        }
    }
}
