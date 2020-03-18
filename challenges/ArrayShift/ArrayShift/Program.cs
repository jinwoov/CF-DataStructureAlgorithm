using System;

namespace ArrayShift
{
    public class Program
    {

        static void Main(string[] args)
        {
            // invoking insertshiftarray method
            int[] testArray = new[] { 4, 8, 15, 23, 42 };
            Console.WriteLine($"Your original input is {String.Join(", ", testArray)}");
            int[] resultArray = InsertShiftArray(testArray, 16);
            // showing what is in the new array
            Console.WriteLine("This is the output after inserting a value to middle {0}", String.Join(", ", resultArray));
            // Invoking deleting element from array method
            int[] resultArrayAfterDelete = StretchGoal(testArray);
            // Showing what is in the out array after deleting middle index
            Console.WriteLine("This is the output after deleting a value in the middle {0}", String.Join(", ", resultArrayAfterDelete));


            Console.ReadLine();
        }

        /// <summary>
        /// This method will insert the element to the middle of the array
        /// </summary>
        /// <param name="array">input array</param>
        /// <param name="numberArg">value to insert</param>
        /// <returns>Returns array with value inserted in middle of array.</returns>
        public static int[] InsertShiftArray(int[] array, int numberArg)
        {
            // Declaring variables 
            int[] newArray = new int[array.Length+1];
            int ind = 0;
            // Declaring variable that is half of argument array length and converting it to int data type
            decimal halfOfDec = array.Length / 2m;
            halfOfDec = Math.Ceiling(halfOfDec);
            // Converting the decimal type to int type
            int halfOfArrayLength = Convert.ToInt32(halfOfDec);
            
            // for loop to iterate and instantiate into newArray
            for (int i = 0; i < newArray.Length; i++)
            {
                // Only happens when index is half of array length
                if (i == halfOfArrayLength)
                {
                    // Inserting new value in
                    newArray[i] = numberArg;
                    // decrementing to stay in same spot for old array element instead of skipping over
                    ind--;
                }
                else
                {
                    newArray[i] = array[ind];
                }
                // Counter for old array index
                ind++;
            }

            return newArray;
        }

        /// <summary>
        /// This method deletes element from middle index of array
        /// </summary>
        /// <param name="array">Given array that will lose middle value</param>
        /// <returns>Array with missing middle element</returns>
        public static int[] StretchGoal(int[] array)
        {
            // Declare a variables
            int[] newArray = new int[array.Length-1];
            int ind = 0;
            // create a half point mark
            int halfOfArrayLength = array.Length/2;

            // run a for loop
            for (int i = 0; i < newArray.Length; i++)
            {
                if (i >= halfOfArrayLength)
                {
                    newArray[i] = array[++ind];
                    // Decrementing to initialize the index of old array
                    ind--;
                }
                else
                {
                    newArray[i] = array[ind];
                }

                ind++;
            }
            // return the new array
            return newArray;
        }
    }
}
