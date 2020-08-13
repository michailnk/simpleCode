using System;
namespace Sorting {
    class Program {
        static Random rn = new Random();
        static int[] Sort(int[] arr) {
            for (int i = 0; i < arr.Length-1; i++) {
                for (int j = i; j < arr.Length; j++) {
                    if (arr[i] > arr[j]) {
                        int temp = arr[j];
                        arr[j] = arr[i];
                        arr[i] = temp;
                    }
                }
            }
            return arr;
        }
        static void Main(string[] args) {
            int[] arr = new int[10];
            for (int i = 0; i < 10; i++) {
                arr[i] = rn.Next(0, 100);
            }
            //the array before sorted
            PrintArray(arr);
            // after sorted

            PrintArray(Sort(arr));
        }

        static void PrintArray(int[] arr) {
            foreach (int item in arr) {
                Console.Write(item+" ");
            }
            Console.WriteLine();
        }
    }
}
