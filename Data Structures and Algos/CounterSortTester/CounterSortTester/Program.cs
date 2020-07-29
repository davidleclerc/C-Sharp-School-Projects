using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// David Leclerc
// CSC-210-H101 Data Structures
// 2/21/2020

namespace CounterSortTester
{
    class Program
    {

        static void Main(string[] args)
        {
            for(int i = 0; i<1000; i++)
            {
                int[] dataArray = randomNums();
                CounterSorter(dataArray);
                if (!CheckSorted(dataArray)){
                    Console.WriteLine("array number " + i + " is not sorted");
                }
            }
            
        }

        //counter sort method
        public static int[] CounterSorter(int[] dataArray)
        {
            //create counter, number of indices equals number of possible values in data array
            int[] counterArray = new int[100];
            for (int i = 0; i < dataArray.Length; i++)
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
                if (i % 10 == 0)
                {
                    Console.WriteLine(" ");

                }
                i++;
            }
            Console.WriteLine();
        }
        private static Random randNum = new Random();
        public static int[] randomNums()
        {
            
            int[] dataArray = new int[100000];
            for (int i = 0; i < dataArray.Length; i++)
            {
                dataArray[i] = randNum.Next(1, 100);
            }
            return dataArray;
        }

        public static bool CheckSorted(int[] dataArray)
        {
            for (int i = 0; i < dataArray.Length; i++)
            {
                if (dataArray[i] > dataArray[i + 1]){
                    return false;
                }
            }
            return true;
        }
    }
}
