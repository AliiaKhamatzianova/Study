using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._4
{
    class Program
    {
        static void PrintMatrix(int[][] matrix)
        {
            for (int i = 0; i < matrix.Length; i++)
            {
                for (int j = 0; j < matrix[i].Length; j++)
                    System.Console.Write(matrix[i][j] + " ");
                System.Console.WriteLine();
            }
        }

        static void SpiralFill(int[][] matrix)
        {
            int tmp = 0;
            int counter = 1;
            int l = 0;
            int r = matrix[tmp].Length - 1;
            int u = 0;
            int d = matrix.Length - 1;

            while (l <= r && d >= u)
            {
                for (int j = l; j <= r; j++)
                    matrix[u][j] = counter++;
                for (int i = u + 1; i <= d; i++)
                    matrix[i][r] = counter++;
                if (u != d)
                    for (int j = r - 1; j >= l; j--)
                        matrix[d][j] = counter++;
                if (l != r)
                    for (int i = d - 1; i > u; i--)
                        matrix[i][l] = counter++;
                // tmp++;
                //r=matrix[tmp].Length-1;
                r--;
                l++;
                u++;
                d--;
            }
        }
        static void Main(string[] args)
        {
            int[][] matrix = new int[3][];
            for (int i = 0; i < matrix.Length; i++)
                matrix[i] = new int[5];
            SpiralFill(matrix);
            PrintMatrix(matrix);
        }
    }
}
