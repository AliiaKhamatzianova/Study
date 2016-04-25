using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._6
{
    /// <summary>
    /// Это программа для циклического сдвига массива влево/вправо
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 1,2,3,4,5 };
            int[] array_copy = new int[array.Length];
            array.CopyTo(array_copy,0);

            int step = 3;


            if (step < 0)
            {
                for (int i = 0; i < array.Length; i++)
                {
                    if (i + step < 0)
                        array[i] = array_copy[array_copy.Length + i + step];
                    else
                        array[i] = array_copy[i + step];
                }

                for (int i = 0; i < array.Length; i++)
                    Console.Write(array[i]);
            }

            else
            {
                for (int i = 0; i < array.Length; i++)
                {
                    if (i + step < array.Length)
                        array[i] = array_copy[i + step];
                    else
                        array[i] = array_copy[i + step - array_copy.Length];
                }

                for (int i = 0; i < array.Length; i++)
                    Console.Write(array[i]);
            }

            Console.WriteLine();
        }
    }
}
