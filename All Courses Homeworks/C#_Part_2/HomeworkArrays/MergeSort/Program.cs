//Problem 13.* Merge sort
//Write a program that sorts an array of integers using the Merge sort algorithm.


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MergeSort
{
    class MergeSortArray
    {
        /* Procedure for merging two sorted array.
        *Note that both array are part of single array. arr1[start.....mid] and arr2[mid+1 ... end]*/
        void mergeArray(int[] arr, int start, int mid, int end)
        {
            /* Create a temporary array for stroing merged array (Length of temp array will be
             * sum of size of both array to be merged)*/
            int[] temp = new int[end - start + 1];

            int i = start, j = mid + 1, k = 0;
            // Now traverse both array simultaniously and store the smallest element of both to temp array
            while (i <= mid && j <= end)
            {
                if (arr[i] < arr[j])
                {
                    temp[k] = arr[i];
                    k++;
                    i++;
                }
                else
                {
                    temp[k] = arr[j];
                    k++;
                    j++;
                }
            }
            // If there is any element remain in first array then add it to temp array
            while (i <= mid)
            {
                temp[k] = arr[i];
                k++;
                i++;
            }
            // If any element remain in second array then add it to temp array
            while (j <= end)
            {
                temp[k] = arr[j];
                k++;
                j++;
            }
            // Now temp has merged sorted element of both array

            // Traverse temp array and store element of temp array to original array
            k = 0;
            i = start;
            while (k < temp.Length && i <= end)
            {
                arr[i] = temp[k];
                i++;
                k++;
            }
        }
        // Recursive Merge Procedure
        void mergesort(int[] arr, int start, int end)
        {
            if (start < end)
            {
                int mid = (end + start) / 2;
                mergesort(arr, start, mid);
                mergesort(arr, mid + 1, end);
                mergeArray(arr, start, mid, end);
            }
        }

        // Main driver function
        static void Main(string[] args)
        {

            int[] arr = { 5, 9, 2, 3, 6, 4, 11, 10, 8, 14 }; // this is the array to be sorted

            MergeSortArray merge = new MergeSortArray();

            // Calling Merge Procedure
            merge.mergesort(arr, 0, arr.Length - 1);

            // Printing Sorted array. after merge sort
            foreach (int a in arr)
            {
                Console.Write(a + " ");
            }
        }
    }
}