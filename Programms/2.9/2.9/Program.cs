using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._9
{
    /// <summary>
    /// Эта программа находит в массиве пару элементов с наибольшим произведением
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] {1,4,6,8,9,8 };
            int max1 = array[0];
            int max2;
            int index_max1 = 0;
            int index_max2 = 0;

            for (int i=0; i< array.Length; i++)
                if (array[i]>max1)
                {
                    max2 = max1;
                    index_max2 = index_max1;
                    max1 = array[i];
                    index_max1 = i;
                }

           

            Console.WriteLine(index_max1+" "+index_max2);

        }
    }
}
