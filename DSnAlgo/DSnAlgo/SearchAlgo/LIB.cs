using System;

namespace DSnAlgo.SearchAlgo
{
    public static class LIB
    {
        public static int LinearSearch(int[] Arr, int item)
        {
            int index = -1;
            for (int i = 0; i < Arr.Length; i++)
            {
                if (Arr[i] == item)
                {
                    index = i;
                    break;
                }
            }
            return index;
        }

        public static int IntArrayBinarySearch(int[] data, int item)
        {

            int min = 0;
            int N = data.Length;
            int max = N - 1;
            do
            {
                int mid = (min + max) / 2;
                if (item > data[mid])
                    min = mid + 1;
                else
                    max = mid - 1;
                if (data[mid] == item)
                    return mid;
                //if (min > max)
                //   break;
            } while (min <= max);
            return -1;
        }
        public static Array BubbleSort(int[] list)
        {
            int temp;
            for (int j = 0; j <= list.Length - 2; j++)
            {
                for (int i = 0; i <= list.Length - 2; i++)
                {
                    if (list[i] > list[i + 1])
                    {
                        temp = list[i + 1];
                        list[i + 1] = list[i];
                        list[i] = temp;
                    }
                }
            }
            return list;
        }




    }
}