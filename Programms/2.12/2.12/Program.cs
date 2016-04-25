using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._12
{
    /// <summary>
    /// Эта программа обходит матрицу по спирали
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            int[,] array = new int[4, 4];

            for (int i = 0; i < array.GetLength(0); i++)
                for (int j = 0; j < array.GetLength(1); j++)
                    array[i, j] = i + j;

            int i1 = 0;
            int j2 = 1;
            int j1 = 0;
            int i2 = 1;
            //int k = 0;

            while (i1 <= array.GetLength(0)/2)
            {
                for (int j = j1; j < array.GetLength(1) - j1; j++)
                    Console.Write(array[i1, j] + " ");
                i1++;
                if (!(i1 <= array.GetLength(0) / 2))
                    break;
                Console.WriteLine();

                for (int i = i1; i <= array.GetLength(0) - i1; i++)
                    Console.Write(array[i, array.GetLength(1) - j2] + " ");
                j2++;
                Console.WriteLine();

                for (int j = array.GetLength(1) - j2; j >= j1; j--)
                    Console.Write(array[array.GetLength(0) - i2, j] + " ");
                i2++;
                Console.WriteLine();
                j1++;
                for (int i = array.GetLength(0) - i2; i >= j1; i--)
                    Console.Write(array[i, j2 -2]+" ");
                

            }


        }
    }
}
