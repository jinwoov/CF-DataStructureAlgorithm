using System;

namespace InsertionSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 4, 8, 15, 42, 16, 23 };

            Console.WriteLine($"This is before the sort {String.Join(", ", array)}"); 

            int [] newArray = InsertionSort(array);

            Console.WriteLine($"This is after the sort {String.Join(", ", newArray)}");

        }

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
