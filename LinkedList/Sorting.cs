using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    class Sorting
    {

        private static void printArray(int[] numberArray)
        {

            foreach (int num in numberArray)
            {
                Console.Write(num + " ");
            }
        }

        private static void log(string searchAlgo, string logType, int[] numberArray, int? iteration = null)
        {
            // return;
            if (logType == "Start")
            {
                Console.Write("\nProgram for sorting a numeric array using " + searchAlgo + " Sorting:");
                printArray(numberArray);
            }
            else if (logType == "End")
            {
                Console.Write("\nThe numbers in ascending orders are:");
                printArray(numberArray);
            }
            else if (logType == "Iteration")
            {
                Console.Write("\n Iteration " + iteration.ToString() + ": ");
                printArray(numberArray);
            }

        }
        public static void bubbleSort(int[] array)
        {

            //   array = new int[] { 89, 76, 45, 92, 67, 12, 99 };
            bool flag = true;
            int temp;
            int numLength = array.Length;
            log("Bubble", "Start", array);
            //sorting an array
            for (int i = 0; (i < numLength - 1) && flag; i++)
            {
                flag = false;
                for (int j = 0; j < numLength - 1; j++)
                {
                    if (array[j + 1] < array[j])
                    {
                        temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                        flag = true;
                    }
                }

                log("Bubble", "Iteration", array, i);
            }
            //Sorted array
            log("Bubble", "End", array);

        }

        public static void InsertionSorting(int[] array)
        {
            // array = new int[] { 89, 76, 45, 92, 67, 12, 99 };

            int numLength = array.Length;

            log("Insert", "Start", array);

            for (int i = 1; i < numLength; i++)
            {
                for (int j = i; j > 0; j--)
                {
                    if (array[j - 1] > array[j])
                    {
                        int temp = array[j - 1];
                        array[j - 1] = array[j];
                        array[j] = temp;
                    }
                    else
                        break;
                }
                log("Insert", "Iteration", array, i);
            }

            log("Insert", "End", array);
        }

        public static void SelectionSort(int[] array)
        {

            //array =new int[] { 89, 76, 45, 92, 67, 12, 99 };
            int array_size = array.Length;
            log("Selection", "Start", array);
            int tmp, min_key;

            for (int i = 0; i < array_size - 1; i++)
            {
                min_key = i;

                for (int j = i + 1; j < array_size; j++)
                {
                    if (array[j] < array[min_key])
                    {
                        min_key = j;
                    }
                }

                tmp = array[min_key];
                array[min_key] = array[i];
                array[i] = tmp;

                log("Selection", "Iteration", array);
            }

            log("Selection", "End", array);

        }

        public static void MergeSort(int[] numbers)
        {
            //numbers = new int[] { 89, 76, 45, 92, 67, 12, 99 };
            int len = numbers.Length;

            log("Merge", "Start", numbers);
            MergeSort_Recursive(numbers, 0, len - 1);
            log("Merge", "End", numbers);



        }

        private static void MergeSort_Recursive(int[] numbers, int left, int right)
        {

            int mid;

            if (right > left)
            {
                mid = (right + left) / 2;
                MergeSort_Recursive(numbers, left, mid);
                MergeSort_Recursive(numbers, (mid + 1), right);

                DoMerge(numbers, left, (mid + 1), right);
            }
        }

        static void DoMerge(int[] numbers, int left, int mid, int right)
        {
            int[] temp = new int[numbers.Length];
            int i, left_end, num_elements, tmp_pos;

            left_end = (mid - 1);
            tmp_pos = left;
            num_elements = (right - left + 1);

            while ((left <= left_end) && (mid <= right))
            {
                if (numbers[left] <= numbers[mid])
                    temp[tmp_pos++] = numbers[left++];
                else
                    temp[tmp_pos++] = numbers[mid++];
            }

            while (left <= left_end)
                temp[tmp_pos++] = numbers[left++];

            while (mid <= right)
                temp[tmp_pos++] = numbers[mid++];

            for (i = 0; i < num_elements; i++)
            {
                numbers[right] = temp[right];
                right--;
            }

        }

        static int Partition(int[] numbers, int left, int right)
        {
            int pivot = numbers[left];
            while (true)
            {
                while (numbers[left] < pivot)
                    left++;

                while (numbers[right] > pivot)
                    right--;

                if (left < right)
                {
                    //Swap
                    int temp = numbers[right];
                    numbers[right] = numbers[left];
                    numbers[left] = temp;
                }
                else
                {
                    return right;
                }
            }
        }

        static void QuickSort(int[] arr, int left, int right)
        {
            // For Recusrion  
            if (left < right)
            {
                int pivot = Partition(arr, left, right);

                if (pivot > 1)
                    QuickSort(arr, left, pivot - 1);

                if (pivot + 1 < right)
                    QuickSort(arr, pivot + 1, right);
            }
        }

        public static void QuickSort(int[] numbers)
        {
            //numbers = new int[] { 89, 76, 45, 92, 67, 12, 99 };
            int len = numbers.Length;

            log("Quick", "Start", numbers);
            QuickSort(numbers, 0, len - 1);
            log("Quick", "End", numbers);

        }
    }
}
