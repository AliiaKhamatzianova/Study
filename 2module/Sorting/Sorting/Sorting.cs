using System;

namespace Sortings
{
    public static class Sorting
    {
        public static void Swap(int [] array, int index1, int index2)
        {
            int tmp = array[index1];
            array[index1] = array[index2];
            array[index2] = tmp;
        } 

        public static void SelectionSort(int[] array)
        {
            
            int min = array[0];
            int min_index = 0;

            int k = 0;
            while (k != array.Length - 1)
            {
                min = array[k];
                min_index = k;
                for (int i = k+1; i < array.Length; i++)
                    if (array[i] < min)
                    {
                        min = array[i];
                        min_index = i;
                    }
                Swap(array,k,min_index);
                k++;
                
            }

        }

        public static void BubbleSort(int[] array)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                bool swapped = false;
                for (int j = 0; j < array.Length - i - 1; j++)
                    if (array[j] > array[j + 1])
                    {
                        Swap(array, j, j + 1);
                        swapped = true;
                    }

                if (!swapped)
                    break;
            }
        }

        public static void ShellSort(int[] array)
        {
            for (int d = array.Length/2; d > 0; d/=2 )
                for (int i = d; i < array.Length; i++)
                {
                    for (int j = i -d; j >= 0; j-=d)
                        if (array[j] > array[j + d])
                            Swap(array, j, j + d);
                }
        }

        public static void InsertionSort(int[] array)
        {
            for (int i = 1; i < array.Length; i++)
                for (int j = i; j > 0; j--)
                    if (array[j] < array[j - 1])
                        Swap(array,j,j-1);
        }
    }
}