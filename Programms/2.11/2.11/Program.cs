using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._11
{
    /// <summary>
    /// Эта программа обходит матрицу змейкой по столбцам
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            int[,] array = new int[3, 4];

            for (int i = 0; i < array.GetLength(0); i++)
                for (int j = 0; j < array.GetLength(1); j++)
                    array[i, j] = i + j;

            for (int i = 0; i < array.GetLength(0); i++)
            {
                if (i % 2 == 0)
                {
                    for (int j = 0; j < array.GetLength(1); j++)
                        Console.Write(array[i, j] + " ");
                    Console.WriteLine();
                }
                else
                {
                    for (int j = array.GetLength(1) - 1; j >= 0; j--)
                        Console.Write(array[i, j] + " ");
                    Console.WriteLine();
                }

            }
        }
    }
}
