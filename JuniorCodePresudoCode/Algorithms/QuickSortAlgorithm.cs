using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuniorCodePresudoCode.Algorithms
{
    public class QuickSortAlgorithm
    {
        public int[] Sort(int[] inputArray)
        {
            int[] sortedArray = QuickSort(inputArray, 0, inputArray.Length - 1);

            Console.WriteLine($"Sorted array: {string.Join(", ", sortedArray)}");

            return sortedArray;
        }

        private static int[] QuickSort(int[] array, int left, int right)
        {
            if (left >= right)
            {
                return array;
            }

            int pivotIndex = GetPivotIndex(array, left, right);

            QuickSort(array, left, pivotIndex - 1);
            QuickSort(array, pivotIndex + 1, right);


            return array;
        }

        private static int GetPivotIndex(int[] array, int left, int right)
        {
            int pivot = left - 1;

            for (int i = left; i <= right; i++)
            {
                if (array[i] < array[right])
                {
                    pivot++;
                    Swap(ref array[pivot], ref array[i]);
                }

            }

            pivot++;
            Swap(ref array[pivot], ref array[right]);

            return pivot;
        }

        private static void Swap(ref int left, ref int right)
        {
            int temp = left;
            left = right;
            right = temp;
        }
    }
}
