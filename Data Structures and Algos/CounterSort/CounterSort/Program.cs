using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// David Leclerc
// CSC-210-H101 Data Structures
// 2/14/2020

namespace CounterSort
{
    class Program
    {
        
        static void Main(string[] args)
        {
            //create 4 arrays with different specifications
            int[] data1 = new int[] {1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,};
            int[] data2 = new int[] {1,1,1,1,1,1,2,2,2,2,2,2,3,3,3,3,3,3,4,4,4,4,4,4,5,5,5,5,5,5,5,6,6,6,6,6,6,6,7,7,7,7,8,8,8,8,9,9,9,9,9};
            int[] data3 = new int[] {9,9,9,9,9,8,8,8,8,8,7,7,7,7,7,6,6,6,6,6,6,6,6,6,5,5,5,5,5,5,5,5,4,4,4,4,4,4,4,3,3,3,3,3,3,2,2,2,2,1,1,1};
            int[] data4 = new int[] {2,5,3,5,6,8,4,3,6,8,4,3,2,4,6,8,9,5,4,2,1,3,5,7,8,6,5,3,2,2,3,5,6,7,8,6,5,4,3,2,2,4,5,6,2,8,7,6,4,3,1,9};

            //print the arrays, then call sort method and print sorted arrays
            Console.WriteLine("All values the same, before sort: ");
            PrintArray(data1);
            CounterSorter(data1);
            Console.WriteLine("After sort: ");
            PrintArray(data1);
            Console.WriteLine("Different values already in order, before sort: ");
            PrintArray(data2);
            CounterSorter(data2);
            Console.WriteLine("Different values already in order, after sort: ");
            PrintArray(data2);
            Console.WriteLine("Different values in reverse order, before sort: ");
            PrintArray(data3);
            CounterSorter(data3);
            Console.WriteLine("Different values in reverse order, after sort: ");
            PrintArray(data3);
            Console.WriteLine("Different values in random order, before sort: ");
            PrintArray(data4);
            CounterSorter(data4);
            Console.WriteLine("Different values in random order, after sort: ");
            PrintArray(data4);
            Console.ReadKey();
        }

        //counter sort method
        public static int[] CounterSorter(int[] dataArray)
        {
            //create counter, number of indices equals number of possible values in data array
            int[] counterArray = new int[10];
            for ( int i = 0;i < dataArray.Length;i++)
            {
                //each time a number appears in data array, increment that index in counter
                counterArray[dataArray[i]]++;
            }
            //placeholder for data array index
            int k = 0;
            for (int j = 0; j < counterArray.Length; j++)
            {
                //overwrite data array with values based on the number of times that value was counted
                while (counterArray[j] > 0)
                {
                    dataArray[k] = j;
                    counterArray[j] -= 1;
                    k++;
                }
            }
           
           return dataArray;
        }

        public static void PrintArray(int[] dataArray)
        {
            int i = 0;
            foreach (var item in dataArray)
            {
                Console.Write(item + " ");
                if (i%10 == 0)
                {
                    Console.WriteLine(" ");

                }
                i++;
            }
            Console.WriteLine();
        }
    }
}
