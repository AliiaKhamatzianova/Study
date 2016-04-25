using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._8
{
    /// <summary>
    /// Эта программа если сумма всех элементов массива четная, умножает все элементы на 3, в противном случае, умножает все нечетные элементы на 2.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] {1,5,6,8,0,9 };
            int s = 0;
            for (int i = 0; i < array.Length; i++)
                s += array[i];

            if (s%2==0)
            {
                for (int i = 0; i < array.Length; i++)
                    array[i] *= 3;
            }
            else
            {
                for (int i = 1; i < array.Length; i += 2)
                    array[i] *= 2;
            }
            for (int i = 0; i < array.Length; i++)
                Console.Write(array[i]+" ");
            Console.WriteLine();
        }
    }
}
