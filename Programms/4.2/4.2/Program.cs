using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _4._2
{
    class Program
    {
        public static int [][] ReadMatrix (StreamReader input)
        {
            using (input)
            {
                var n_m = input.ReadLine().Split(' ').ToArray();
                int n = Int32.Parse(n_m[0]);
                int m = Int32.Parse(n_m[1]);

                int[][] matrix = new int[n][];
                for (int k = 0; k < n; k++)
                    matrix[k] = new int[m];
                int i = 0;
                while(!input.EndOfStream)
                {
                    var tmp= input.ReadLine().Split(' ').ToArray();
                    for (int j = 0; j < m; j++)
                        matrix[i][j] = Int32.Parse(tmp[j]);
                    i++;

                }

                return matrix;
            }
        }

        public static int [][] Transporate (int [][]matrix)
        {
            int[][] result = new int[matrix[0].Length][];
            for (int i = 0; i < result.Length; i++)
                result[i] = new int[matrix.Length];

            for (int j = 0; j < matrix[0].Length; j++)
                for (int i = 0; i < matrix.Length; i++)
                    result[j][i] = matrix[i][j];
     
            return result;
        }

        public static void PrintMatrix (int [][] matrix)
        {
            var output_file = new FileInfo("output.txt");
            if (output_file.Exists)
            {
                output_file.Delete();
            }
            var output = new StreamWriter("output.txt", true);
            using (output)
            {
                for (int i = 0; i < matrix.Length; i++)
                {
                    for (int j = 0; j < matrix[0].Length; j++)
                        if (j!=matrix[0].Length-1)
                        output.Write(matrix[i][j]+" ");
                    else
                            output.Write(matrix[i][j]);
                    output.WriteLine();
                }
            }
        }
        static void Main(string[] args)
        {

            var input = new StreamReader("input.txt");
           // int[][] matrix = ReadMatrix(input);

            //for (int i=0; i<matrix.Length;i++)
            //{
            //    for (int j = 0; j < matrix[i].Length; j++)
            //        Console.Write(matrix[i][j]+" ");
            //    Console.WriteLine();
            //}

            //int[][] result = Transporate(matrix);
            PrintMatrix(Transporate(ReadMatrix(input)));

            //for (int i = 0; i < result.Length; i++)
            //{
            //    for (int j = 0; j < result[i].Length; j++)
            //        Console.Write(result[i][j] + " ");
            //    Console.WriteLine();
            //}
        }
    }
}
