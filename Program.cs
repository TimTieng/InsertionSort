/*
Prompt: Given an unsorted array of integers, return a sorted array using the 
insertion sort algorithm
*/

using System;

namespace InsertionSort
{
    class Program
    {
        static void Main(string[] args)
        {
            //Test 1
            int[] testArr = {1,4,3,67,3,0,45,5};
            InsertionSort(testArr);

            // Test 2
            int[] testArr2 = {202,56,2,76,343,0,8};
            Console.WriteLine("\n---------------");
            InsertionSort(testArr2);
        }
        public static void InsertionSort(int[] array)
        {
            // Account for an empty array being provided
            if(array.Length == 0)
            {
                Console.WriteLine("You provided an empty array, nothing to sort");
            }  
            // Create a nested loop to iterate through and conduct the swap
            // Start at 1 because we assume value at index 0 is a sorted value
            for (int i = 1; i < array.Length; i++)
            {
                // Continue to evaluate while condition index is greater than 0 and swapping needs to occur
                int j = i;
                while (j > 0 && array[j] < array[j-1])
                {
                    SwapFunction(j, j-1, array);
                    // decrement to facilitate loop condition
                    j--;
                }
            }
            for(int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            } 
        }
        // Helper Swap function 
        public static void SwapFunction(int i, int j, int[] array)
        {
            int tempValue;

            tempValue = array[i];
            array[i] = array[j];
            array[j] = tempValue;
        }
    }
}
