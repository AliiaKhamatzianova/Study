using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    /// <summary>
    /// обход матрицы по спирали и змейкой по диагонали
    /// </summary>
    class Program
    {
        static void PrintMatrix (int [,] x)
        {
            for (int i = 0; i < x.GetLength(0); i++)
            {
                for (int j = 0; j < x.GetLength(1); j++)
                    Console.Write(x[i, j] + "\t");
                Console.WriteLine();
            }
        }


        static void FillSpiral (int [,] x)
        {
            int counter = 1;
            int l = 0;
            int r = x.GetLength(1) - 1;
            int u = 0;
            int d = x.GetLength(0) - 1;

            while (l<=r && d>=u)
            {
                for (int j = l; j < r; j++)
                    x[u, j] = counter++;
                for (int i = u + 1; i <= d; i++)
                    x[i, r] = counter++;
                if (u!=d)
                for (int j = r - 1; j >= l; j--)
                    x[d, j] = counter++;
                if (l!=r)
                for (int i = d - 1; i > u; i--)
                    x[i, l] = counter++;
                r--;
                l++;
                u++;
                d--;
            }

        }

        static void PrintDiagonal (int [,] x, int diag)
        {
            int i, j;
            if (diag<x.GetLength(0))
            {
                j = 0;
                i = diag;
            }
            else
            {
                i = x.GetLength(0)-1;
                j = diag - x.GetLength(0) + 1;
            }

            while (i>=0 && j<x.GetLength(1))
            {
                Console.Write(x[i--,j++]+" ");
            }
        }

        static void PrintDiagRev (int [,] x, int diag)
        {
            int i, j;

            if (diag<x.GetLength(1))
            {
                i = 0;
                j = diag;
            }
            else
            {
                i = diag - x.GetLength(1) + 1;
                j = x.GetLength(1) - 1;
            }

            while (i<x.GetLength(0)&&j>=0)
            {
                Console.Write(x[i++, j--] + " ");
            }
        }
        static void PrintSnake (int [,] x)
        {
            for (int k = 0; k < x.GetLength(0) + x.GetLength(1); k++)
                if (k%2==0)
                    PrintDiagonal(x, k);
            else
                PrintDiagRev(x, k);
        }
        static void Main(string[] args)
        {
            int[,] x = new int[3, 4];
            //FillSpiral(x);
            int count = 1;
            for (int i = 0; i < x.GetLength(0); i++)
            {
                for (int j = 0; j < x.GetLength(1); j++)
                    x[i, j] = count++;
            }

            PrintMatrix(x);
            Console.WriteLine();
            PrintSnake(x);
        }
    }
}
