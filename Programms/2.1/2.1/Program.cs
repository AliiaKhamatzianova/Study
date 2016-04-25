using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._1
{
    /// <summary>
    /// Это программа для заполнения массива чережованием 1/-1
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество элементов массива");
            try
            {
                int n = Int32.Parse(Console.ReadLine());
                int[] array = new int[n];

                for (int i = 0; i < array.Length; i++)
                {
                    array[i] = (i % 2 == 0) ? 1 : -1;
                }

                for (int i = 0; i < array.Length; i++)
                {
                    Console.Write(array[i] + " ");
                }

                Console.WriteLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}
