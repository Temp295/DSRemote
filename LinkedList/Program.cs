using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace LinkedList
{

    class ThreadParams
    {
       public  string searchAlgo;
        public int[] numberArray;

    }
    class Program
    {
        public int MyProperty { get; set; }


        public static void CallToChildThread(object data)
        {
            switch (((ThreadParams)data).searchAlgo)
            {
                case "Bubble":
                    Sorting.bubbleSort(((ThreadParams)data).numberArray);
                    break;
                case "Insertion":
                    Sorting.InsertionSorting(((ThreadParams)data).numberArray);
                    break;
                case "Select":
                    Sorting.SelectionSort(((ThreadParams)data).numberArray);
                    break;
                case "Merge":
                    Sorting.MergeSort(((ThreadParams)data).numberArray);
                    break;
                default:
                    break;
            }
        }

       public static void Main(string[] args)
        {
            //int length = 100;
            //int[] number = new int[length]; //{ 89, 76, 45, 92, 67, 12, 99 };

            //for (int i = 0; i < length; i++)
            //{
            //    number[i] = new Random().Next();
            //}
            int[] number ={ 2, 76, 45, 92, 67, 12, 1 };

            //Thread myThread = new Thread(new ParameterizedThreadStart(CallToChildThread));

            //Thread myThread1 = new Thread(new ParameterizedThreadStart(CallToChildThread));

            //Thread myThread2 = new Thread(new ParameterizedThreadStart(CallToChildThread));

            //Thread myThread3 = new Thread(new ParameterizedThreadStart(CallToChildThread));

            //DateTime bubbleSortStart = DateTime.Now;
            //myThread.Start(new ThreadParams { searchAlgo = "Bubble", numberArray = number });

            //DateTime insertSortStart = DateTime.Now;
            //myThread1.Start(new ThreadParams { searchAlgo = "Insertion", numberArray = number });
            //DateTime selectSortStart = DateTime.Now;
            //myThread2.Start(new ThreadParams { searchAlgo = "Select", numberArray = number });

            //DateTime mergeSortStart = DateTime.Now;
            //myThread3.Start(new ThreadParams { searchAlgo = "Merge", numberArray = number });
            //DateTime mergeSortEnd = DateTime.Now;

            //myThread.Join();
            //myThread1.Join();
            //myThread2.Join();
            //myThread3.Join();
            //Console.WriteLine("\nTime taken for bubble sort:" + bubbleSortStart +" " + insertSortStart +" "+(insertSortStart - bubbleSortStart));
            //Console.WriteLine("Time taken for Insert sort:" + insertSortStart + " " + selectSortStart + " " + (selectSortStart - insertSortStart));
            //Console.WriteLine("Time taken for Selection sort:" + selectSortStart + " " + mergeSortStart + " " + (mergeSortStart - selectSortStart));
            //Console.WriteLine("Time taken for Merge sort:" + mergeSortStart + " " + mergeSortEnd + " " + (mergeSortEnd - mergeSortStart));





            //DateTime bubbleSortStart = DateTime.Now;
            //number = new int[] { 2, 76, 45, 92, 67, 12, 1 };
            //Sorting.bubbleSort(number);   //O(n2)
            //DateTime insertSortStart = DateTime.Now;
            //number =new int[]{ 2, 76, 45, 92, 67, 12, 1 };
            //Sorting.InsertionSorting(number);  //O(n2)
            //DateTime selectSortStart = DateTime.Now;
            //number = new int[] { 2, 76, 45, 92, 67, 12, 1 };
            //Sorting.SelectionSort(number);   //O(n2)
            //DateTime mergeSortStart = DateTime.Now;
            //Sorting.MergeSort(number);              //Ο(n log n)
            //DateTime mergeSortEnd = DateTime.Now;

            number = new int[] { 2, 76, 45, 92, 67, 12, 1 };
            Sorting.QuickSort(number);
            //Console.WriteLine("\nTime taken for bubble sort:" + (insertSortStart-bubbleSortStart));
            //Console.WriteLine("Time taken for Insert sort:" + (selectSortStart-insertSortStart));
            //Console.WriteLine("Time taken for Selection sort:" + (mergeSortStart - selectSortStart));
            //Console.WriteLine("Time taken for Merge sort:" + (mergeSortEnd - mergeSortStart));

            Console.ReadLine();
            
        }
    }

}
