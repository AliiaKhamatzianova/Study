using System;

namespace Sortings
{
    public class Sorting
    {
        public static int SelectBearingElement(int []array)
        {
            int [] a = new int [3];
            if (array.Length >= 3)
            {
                a[0] = array[0];
                a[1] = array[(array.Length - 1) / 2];
                a[2] = array[array.Length - 1];
            }
            else if (array.Length == 2)
            {
                a[0] = array[0];
                a[1] = array[(array.Length - 1)];
                a[2] = array[array.Length - 1];
            }
            else if (array.Length == 1)
            {
                a[0] = array[0];
                a[1] = a[0];
                a[2] = a[0];
            }
            else
                throw new Exception ("Пустой массив не может быть отсортирован");

            int min = a[0];
            int max = a[0];

            for (int i = 0; i < 3; i++)
            {
                if (a[i] <= min)
                    min = a[i];
                if (a[i] >= max)
                    max = a[i];
            }

            for (int i = 0; i < 3; i++)
            {
                if (a[i] < max && a[i] > min)
                    return a[i];
                if (a[i] == max && a[i] == min)
                    return a[i];
                if (a[i] == max && a[i] != min)
                    return max;
                if (a[i] != max && a[i] == min)
                    return min;
            }

            return 0;

            }

        public static void Swap (ref int a1, ref int a2)
        {
            int tmp = a1;
            a1 = a2;
            a2 = tmp;
        }

        public static void QuickSort(int[] array, int left, int right)
        {
            int noll = left;
            int last = right;

            int bearingPosition = (noll + right) / 2;
            int bearing_element = array[bearingPosition]; //SelectBearingElement(array);
            //int left = 0;
            //int right = array.Length - 1;

        while (left<=right)
            {
                while (array[left] < bearing_element && left < right-1)
                    left++;

                //if (array[left] > bearing_element)
                //    Swap(ref array[left], ref array[right]);
                while (array[right] >= bearing_element && right > left)
                        right--;
                //if(array[right] >= bearing_element)
                //    Swap(ref array[left], ref array[right]);

                //if (left == right)
                //    break;

                if (left < right)
                {
                    if (left == bearingPosition)
                    {
                        Swap(ref array[left], ref array[right]);
                        bearingPosition = right;
                    }else
                    if (right == bearingPosition)
                    {
                        Swap(ref array[left], ref array[right]);
                        bearingPosition = left;
                    }
                    else
                        Swap(ref array[left], ref array[right]);

                }
                else if (left == right)
                {
                    if (array[left] > bearing_element)
                    {
                        Swap(ref array[left], ref array[bearingPosition]);
                        bearingPosition = left;
                    }
                    break;
                }
            }

            if (right > noll)
                QuickSort(array,noll, right);
            if (last-1 > left)
                QuickSort(array, left, last);

        }
    }
}