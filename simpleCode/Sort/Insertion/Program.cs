using System;

namespace Insertion {
    class Program {
        static Random rn = new Random();
        static void InsertionSort(int[] arr) {
            int sortedRange = 1; // variable denoting the sorted part.by default any single array is sorted
            while (sortedRange < arr.Length) {
                if (arr[sortedRange].CompareTo(arr[sortedRange-1]) < 0) {
                    int insertPossition = FindInsertion(arr, sortedRange );
                    Insert(arr, insertPossition, sortedRange);
                }
                sortedRange++;
            }
        }

        private static int FindInsertion(int[] arr, int indexChangePosition) {
            for (int i = 0; i < arr.Length; i++) {
                if (arr[i].CompareTo(arr[indexChangePosition]) > 0)
                    return i;
            }
            throw new InvalidCastException("index not found");
        }

        private static void Insert(int[] arr, int indexSetPositon, int sortedRange) {
            int temp = arr[indexSetPositon];
            arr[indexSetPositon] = arr[sortedRange];
            for (int i = sortedRange; i> indexSetPositon; i--) {
                arr[i] = arr[i - 1];
            }
            arr[indexSetPositon + 1] = temp;
        }

        static void Main(string[] args) {

            Console.WriteLine(1.CompareTo(4));
            int[] arr = new int[10];
            for (int i = 0; i < 10; i++) {
                arr[i] = rn.Next(0, 100);
                Console.Write(arr[i] + " ");
            }

            InsertionSort(arr);
            Console.WriteLine();
            for (int i = 0; i < arr.Length; i++) {
                Console.Write(arr[i] + " ");
            }
        }
    }
}
