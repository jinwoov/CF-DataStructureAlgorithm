using System;

namespace BinarySearch
{
    public class Program
    {
        static void Main(string[] args)
        {
            // creating a int variable to show it in console
            int[] array = { 1, 2, 3, 4, 5, 6 };
            int finalNumber = BinarySearch(array, 4);
            // checking final answer
            Console.WriteLine("Expecting 3 as the final answer");
            Console.WriteLine($"This is the final value: {finalNumber}");
        }

        public static int BinarySearch(int[] array, int searchValue)
        {
            // this will start from farthest left
            int leftSide = 0;

            // this wil start from farthest right
            int rightSide = array.Length - 1;

            // this while loop will check if element at specific position matches search value until leftSide is greater than rightSide variable
            while (leftSide <= rightSide)
            {
                // creating middle ground variable
                int index = (leftSide + rightSide) / 2;

                // checking if element at middle matches the given value then returns the that position
                if (array[index] == searchValue) { return index; }

                //Otherwise these condition will trigger which if given value is less than the element, it will reset the rightSide to index minus one
                if (searchValue < array[index]) 
                {
                    // minus one because element at current index wasn't matching
                    rightSide = index - 1;
                }
                // if the searchValue is greater than the element than it will reset the leftSide variable
                else
                {
                    // plus one because element at current index wasn't matching
                    leftSide = index + 1;
                }
            }
            // this is when logic in the while loop fails which means none of the element matches given value(searchValue)
            return -1;
        }
    }
}
