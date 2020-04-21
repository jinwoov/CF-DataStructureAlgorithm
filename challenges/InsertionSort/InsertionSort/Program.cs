using System;

namespace InsertionSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 8, 4, 23, 42, 16, 15 };

            Console.WriteLine($"This is before the sort {String.Join(", ", array)}"); 

            int [] newArray = InsertionSort(array);

            Console.WriteLine($"This is after the sort {String.Join(", ", newArray)}");

            Console.WriteLine();
            Console.WriteLine("REVERSE SORTED");
            int[] reverseSorted = { 20, 18, 12, 8, 5, -2 };

            Console.WriteLine($"This is before the sort {String.Join(", ", reverseSorted)}");

            int[] newReverseSorted = InsertionSort(reverseSorted);

            Console.WriteLine($"This is after the sort {String.Join(", ", newReverseSorted)}");

            Console.WriteLine();
            Console.WriteLine("FEW UNIQUES SORTED");
            int[] fewUnique = { 5, 12, 7, 5, 5, 7 };
            Console.WriteLine($"This is before the sort {String.Join(", ", fewUnique)}");

            Console.WriteLine($"This is after the sort {String.Join(", ", InsertionSort(fewUnique))}");


            Console.WriteLine();
            Console.WriteLine("NEARLY SORTED");
            int[] nearlySorted = { 2, 3, 5, 7, 13, 11 };

            Console.WriteLine($"This is before the sort {String.Join(", ", nearlySorted)}");

            Console.WriteLine($"This is after the sort {String.Join(", ", InsertionSort(nearlySorted))}");

        }

        /// <summary>
        /// Insertion sort method
        /// </summary>
        /// <param name="arr">integer array</param>
        /// <returns>sorted array</returns>
        static int[] InsertionSort(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                int j = i - 1;
                int temp = arr[i];

                while(j >= 0 && temp < arr[j])
                {
                    arr[j + 1] = arr[j];
                    j -= 1;
                }
                arr[j + 1] = temp;
            }
            return arr;
        }
    }
}
