using System;

namespace MergeSort {

    class Program {
        static void MergSort(int[] array) {
            if (array.Length <= 1)
                return;

            int leftSize = array.Length / 2;
            int rigthSize = array.Length - leftSize;

            int[] left = new int[leftSize];
            int[] right = new int[rigthSize];

            Array.Copy(array, 0, left, 0, leftSize);
            Array.Copy(array, 0, right, 0, rigthSize);

            MergSort(left);
            MergSort(right);

            Merg(array, left, right);
        }

        private static void Merg(int[] array, int[] left, int[] right) {


            throw new NotImplementedException();
        }

        static void Main(string[] args) {

        }
    }
}
