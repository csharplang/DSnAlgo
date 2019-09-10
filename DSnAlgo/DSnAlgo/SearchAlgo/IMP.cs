using System;

namespace DSnAlgo.SearchAlgo
{
    public static class IMP
    {
        public static void LinearSearch()
        {
            Console.WriteLine("------ Linear Search ------");
            int[] array = { 6, 55, 5, 3, 7, 2, 9, 4, 8, 10 };
            Console.Write("Enter The Number To Search:");
            String input = Console.ReadLine();
            int itemSearch = Convert.ToInt32(input);
            int index = LIB.LinearSearch(array, itemSearch);
            if (index != -1)
            {
                Console.WriteLine("Number :" + itemSearch + " found in array at index=" + index);
            }
            else
            {
                Console.WriteLine("Number :" + itemSearch + " not found in array");
            }
        }

        public static void BinarySearch()
        {
            Console.WriteLine("------ Binary Search ------");
            int[] array = { 6, 55, 5, 3, 7, 2, 9, 4, 8, 10 };

            //Array must be sorted
            Array.Sort(array);
            Console.WriteLine("[{0}]", string.Join(", ", array));

            Console.Write("Enter The Number To Search:");
            String input = Console.ReadLine();
            int itemSearch = Convert.ToInt32(input);
            int index = LIB.IntArrayBinarySearch(array, itemSearch);
            if (index != -1)
            {
                Console.WriteLine("Number :" + itemSearch + " found in array at index=" + index);
            }
            else
            {
                Console.WriteLine("Number :" + itemSearch + " not found in array");
            }
        }


        public static void BubbleSort()
        {
            int[] array = { 6, 55, 5, 3, 7, 2, 9, 4, 8, 10 };
            Console.Write("Before Sort: ");
            Console.WriteLine("[{0}]", string.Join(", ", array));

            LIB.BubbleSort(array);
            Console.Write("After Sort by BubbleSort: ");
            Console.WriteLine("[{0}]", string.Join(", ", array));

        }




    }
}