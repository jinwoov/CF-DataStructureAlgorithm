using System;

namespace QuickSortt
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numberArr = { 8, 4, 23, 42, 16, 15 };
            int[] reverseArr = { 20, 18, 12, 8, 5, -2 };
            int[] fewArr = { 5, 12, 7, 5, 5, 7 };
            int[] nearlyArr = { 2, 3, 5, 7, 13, 11 };

            int length = numberArr.Length - 1;

            Console.WriteLine("QUICKSORT");
            Console.WriteLine($"This is before the sort: {String.Join(", ", numberArr)}");
            QuickSort(numberArr, 0, length);
            Console.WriteLine($"This is after the sort: {String.Join(", ", numberArr)}");

            Console.WriteLine();
            Console.WriteLine("REVERSE SORTED");
            Console.WriteLine($"This is before the sort: {String.Join(", ", reverseArr)}");
            QuickSort(reverseArr, 0, length);
            Console.WriteLine($"This is after the sort: {String.Join(", ", reverseArr)}");

            Console.WriteLine();
            Console.WriteLine("FEW UNIQUE");
            Console.WriteLine($"This is before the sort: {String.Join(", ", fewArr)}");
            QuickSort(fewArr, 0, length);
            Console.WriteLine($"This is after the sort: {String.Join(", ", fewArr)}");

            Console.WriteLine();
            Console.WriteLine("NEARLY SORTED");
            Console.WriteLine($"This is before the sort: {String.Join(", ", nearlyArr)}");
            QuickSort(nearlyArr, 0, length);
            Console.WriteLine($"This is after the sort: {String.Join(", ", nearlyArr)}");
        }

        public static void QuickSort(int[] arr, int left, int right)
        {
            if (left < right)
            {
                int position = Partition(arr, left, right);

                QuickSort(arr, left, position - 1);

                QuickSort(arr, position + 1, right);
            }


        }

        public static int Partition(int[] arr, int left, int right)
        {
            int pivot = arr[right];

            int low = left - 1;

            for (int i = left; i < right; i++)
            {
                if (arr[i] <= pivot)
                {
                    low++;
                    Swap(arr, i, low);
                }
            }
            Swap(arr, right, low + 1);

            return low + 1;
        }

        public static void Swap(int[] arr, int mid, int low)
        {
            int temp;

            temp = arr[mid];

            arr[mid] = arr[low];

            arr[low] = temp;
        }
    }
}
