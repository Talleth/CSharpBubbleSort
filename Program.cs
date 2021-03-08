using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndividualProject
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] arrayToSort = { 3, 44, 45, 10, 15, 16, 9, 11 };

            Program.BubbleSort(arrayToSort, arrayToSort.Length);
            Program.PrintArray(arrayToSort);
        }

        public static void PrintArray(int[] arrayToPrint)
        {
            for (int i = 0; i < arrayToPrint.Length; i++)
                Console.WriteLine(arrayToPrint[i]);
        }

        public static int[] BubbleSort(int[] arrayToSort, int arrayLength)
        {
            // Iterate full array
            for (int i = 0; i < arrayLength - 1; i++)
            {
                // Iterate backwards until the spot is found
                for (int j = 0; j < arrayLength - i - 1; j++)
                {
                    // When spot is found swap
                    if (arrayToSort[j] > arrayToSort[j + 1])
                    {
                        int tempNumber = arrayToSort[j];

                        arrayToSort[j] = arrayToSort[j + 1];
                        arrayToSort[j + 1] = tempNumber;
                    }
                }
            }

            return arrayToSort;
        }
    }
}
