using System;

namespace MergeSort
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] numberArray = { 8, 4, 23, 42, 16, 15 };
            int[] reverSorted = { 20, 18, 12, 8, 5, -2 };
            int[] fewUnique = { 5, 12, 7, 5, 5, 7 };
            int[] nearlySorted = { 2, 3, 5, 7, 13, 11 };


            Console.WriteLine($"This is before the sort {String.Join(", ", numberArray)}");
            int[] result = MergeSort(numberArray);
            Console.WriteLine($"This is after the sort {String.Join(", ", result)}");

            Console.WriteLine();
            Console.WriteLine("REVERSE-SORTED");
            Console.WriteLine($"This is before the sort {String.Join(", ", reverSorted)}");
            int[] result1 = MergeSort(reverSorted);
            Console.WriteLine($"This is after the sort {String.Join(", ", result1)}");

            Console.WriteLine();
            Console.WriteLine("FEW UNIQUES");
            Console.WriteLine($"This is before the sort {String.Join(", ", fewUnique)}");
            int[] result2 = MergeSort(fewUnique);
            Console.WriteLine($"This is after the sort {String.Join(", ", result2)}");

            Console.WriteLine();
            Console.WriteLine("NEARLY-SORTED");
            Console.WriteLine($"This is before the sort {String.Join(", ", nearlySorted)}");
            int[] result3 = MergeSort(nearlySorted);
            Console.WriteLine($"This is after the sort {String.Join(", ", result3)}");

        }

        /// <summary>
        /// This sorts left and right and after its sorted it sorts entire array
        /// </summary>
        /// <param name="arr">array to be sorted</param>
        /// <returns>sorted Array</returns>
        public static int[] MergeSort(int[] arr)
        {
            int n = arr.Length;

            if (n > 1)
            {
                int mid = n / 2;
                int[] left = new int[mid];
                int[] right;

                if (n % 2 == 0) { right = new int[mid]; }
                else { right = new int[mid + 1]; }

                for (int i = 0; i < mid; i++)
                {
                    left[i] = arr[i];
                }
                int j = 0;
                for (int i = mid; i < n; i++)
                {
                    right[j++] = arr[i];
                }

                left = MergeSort(left);

                right = MergeSort(right);

                arr = Merge(left, right, arr);
            }

            return arr;
        }

        /// <summary>
        /// Method that will be used to sort array
        /// </summary>
        /// <param name="left">left of the array</param>
        /// <param name="right">right side of the array</param>
        /// <param name="arr">entire array</param>
        /// <returns>sorted array</returns>
        public static int[] Merge(int[] left, int[] right, int[] arr)
        {
            int i = 0;
            int j = 0;
            int k = 0;

            while(i < left.Length && j < right.Length)
            {
                if(left[i] <= right[j])
                {
                    arr[k] = left[i];
                    i += 1;
                }
                else
                {
                    arr[k] = right[j];
                    j += 1;
                }
                k += 1;
            
            }
            if (i == left.Length)
            {
                for (int q = k; q < arr.Length; q++)
                {
                    arr[q] = right[j++];
                }
            }
            else
            {
                for (int q = k; q < arr.Length; q++)
                {
                    arr[q] = left[i++];
                }
            }
            return arr;
        }
    }
}
