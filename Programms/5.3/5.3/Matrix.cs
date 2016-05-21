using System;
namespace _5._3
{
    public class Matrix
    {
        public int[][] M { get; private set; }

        public Matrix(int[][] v)
        {
            if (v == null || v.Length == 0)
            {
                throw new NullReferenceException("Matrix is null!");
            }
            else 
                if (v[0].Length==0)
            {
                throw new NullReferenceException("Matrix is null!");
            }

            M = new int[v.Length][];
            for (int i = 0; i < v.Length; i++)
                M[i] = new int[v[0].Length];
            v.CopyTo(M, 0);
        }

        public Matrix(Matrix a) : this(a.M) { }

        public int[][] Transporate()
        {
            int[][] result = new int[M[0].Length][];
            for (int i = 0; i < result.Length; i++)
                result[i] = new int[M.Length];

            for (int j = 0; j < M[0].Length; j++)
                for (int i = 0; i < M.Length; i++)
                    result[j][i] = M[i][j];

            return result;
        }

        public int[][] MultiplicationOnScalar(int scalar)
        {
            int[][] result = new int[M.Length][];
            for (int i = 0; i < result.Length; i++)
                result[i] = new int[M[0].Length];

            for (int i = 0; i < M.Length; i++)
                for (int j = 0; j < M[0].Length; j++)
                    result[i][j] = M[i][j]*scalar;

            return result;
        }


        public int[] MultiplicationArrayOnMatrix(int [] array)
        {
            
            if (array.Length != M.Length)
            {
                throw new ArgumentException("Matrix and array have different length");
            }

            int[] result = new int[M[0].Length];

            for (int k = 0; k < result.Length; k++)
                for (int i = 0; i < array.Length; i++)
                    result[k]+= M[i][k] * array[i];

            return result;
        }

        public int[] MultiplicationMatrixOnArray(int[] array)
        {

            if (array.Length != M[0].Length)
            {
                throw new ArgumentException("Matrix and array have different length");
            }

            int[] result = new int[M.Length];

            for (int k = 0; k < M.Length; k++)
                for (int i = 0; i < array.Length; i++)
                    result[k] += M[k][i] * array[i];

            return result;
        }

        public int[][] GetSubMatrix(int row1, int column1, int row2, int column2)
        {

            if ( M.Length < row1 || row1 < 0 || column1 < 0 || M[0].Length < column1 || M.Length < row2 || row2 < 0 || column2 < 0 || M[0].Length < column2 || row2 < row1 || column2 < column1 )
            {
                throw new ArgumentException("Invalid range!");
            }

            int[][] result = new int[row2-row1+1][];

            for (int i = 0; i < result.Length; i++)
                result[i] = new int[column2 - column1 + 1];

            int r = 0;
            for (int i = row1; i <= row2; i++)
            {
                int c = 0;
                for (int j = column1; j <= column2; j++)
                {
                    result[r][c] = M[i][j];
                    c++;
                }
                r++;

            }

            return result;
        }
    }
}